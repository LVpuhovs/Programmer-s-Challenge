using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_for_programming
{
    public partial class Levels : Form
    {
        private User user;
        private Language valoda;
        private Language selectedLanguage;
        private DataTable tasksTable = new DataTable();
        public Levels(Language language, User user, Language selectedLanguage)
        {
            InitializeComponent();
            DataManager.Instance.LoadData(Program.connectionString);
            this.KeyPreview = true;
            this.user = user;
            this.selectedLanguage = selectedLanguage;
            this.valoda = language;

            if (valoda.ToString() == "Latviešu")
                LevelsLbl.Text = "Līmeņi";

            else if (valoda.ToString() == "English")
                LevelsLbl.Text = "Levels";


            tasksTable = DataManager.Instance.DataSet.Tables["Tasks"];
            if (tasksTable == null)
            {
                if (valoda.ToString() == "Latviešu")
                    MessageBox.Show("Uzdevumu tabula nav ielādēta.");

                else if (valoda.ToString() == "English")
                    MessageBox.Show("Couldn't load task table.");
                return;
            }
            InitializeDifficultyOrder();
            levelsLoad();
        }
        private void InitializeDifficultyOrder()
        {

            if (!tasksTable.Columns.Contains("DifficultyOrder"))
            {
                tasksTable.Columns.Add("DifficultyOrder", typeof(int));
            }
            updateDifficultyValues();
        }

        private void updateDifficultyValues()
        {
            foreach (DataRow row in tasksTable.Rows)
            {
                switch (row["Difficulty"].ToString())
                {
                    case "Easy":
                        row["DifficultyOrder"] = 1;
                        break;
                    case "Medium":
                        row["DifficultyOrder"] = 2;
                        break;
                    case "Hard":
                        row["DifficultyOrder"] = 3;
                        break;
                    default:
                        row["DifficultyOrder"] = 99;
                        break;
                }
            }
        }
        private void levelsLoad()
        {
            levelsPanel.Controls.Clear();

            DataManager.Instance.LoadData(Program.connectionString);
            tasksTable = DataManager.Instance.DataSet.Tables["Tasks"];
            InitializeDifficultyOrder();

            levelsPanel.AutoScroll = true;
            List<int> completedTasks = DataManager.Instance.getCompletedTaskId(user.IdUser, selectedLanguage.ToString());
            Dictionary<string, int> counter = new Dictionary<string, int>();
            int x = 10, y = 10;
            int buttonWidth = 100;
            int buttonHeight = 40;
            int spacing = 10;
            int maxButtonsPerRow = 5;
            int buttonsInRow = 0;
            string previousDifficulty = "";

            tasksTable.DefaultView.Sort = "DifficultyOrder ASC, idTasks ASC";

            foreach (DataRowView rowView in tasksTable.DefaultView)
            {
                DataRow row = rowView.Row;

                string currentDifficulty = row["Difficulty"].ToString();
                if (currentDifficulty != previousDifficulty)
                {
                    x = 10;
                    if (previousDifficulty != "")
                    {
                        y += buttonHeight + spacing * 2;
                    }

                    Label difficultyLabel = new Label();
                    difficultyLabel.AutoSize = true;
                    if (valoda.ToString() == "Latviešu")
                    {
                        if (currentDifficulty == "Easy")
                            difficultyLabel.Text = "Viegls";
                        else if (currentDifficulty == "Medium")
                            difficultyLabel.Text = "Vidējs";
                        else if (currentDifficulty == "Hard")
                            difficultyLabel.Text = "Grūts";
                        else
                            difficultyLabel.Text = currentDifficulty;
                    }
                    else
                    {
                        difficultyLabel.Text = currentDifficulty;
                    }
                    difficultyLabel.Location = new Point(x, y);
                    levelsPanel.Controls.Add(difficultyLabel);
                    y += difficultyLabel.Height + spacing;
                    x = 10;
                    previousDifficulty = currentDifficulty;
                    buttonsInRow = 0;

                    counter[currentDifficulty] = 1;
                }

                Button taskButton = new Button();
                int levelNr = counter[currentDifficulty];
                if (valoda.ToString() == "Latviešu")
                    taskButton.Text = $"{levelNr} Līmenis";

                else if (valoda.ToString() == "English")
                    taskButton.Text = $"Level {levelNr}";

                taskButton.Width = buttonWidth;
                taskButton.Height = buttonHeight;
                taskButton.Left = x;
                taskButton.Top = y;

                int taskId = Convert.ToInt32(row["idTasks"]);
                if (completedTasks.Contains(taskId))
                {
                    taskButton.BackColor = Color.LightGreen;
                }

                taskButton.Click += (s, args) =>
                {

                    Game game = new Game(valoda, user, selectedLanguage, taskId);
                    this.Hide();
                    game.Show();

                };

                levelsPanel.Controls.Add(taskButton);
                x += buttonWidth + spacing;
                buttonsInRow++;
                counter[currentDifficulty]++;

                if (buttonsInRow >= maxButtonsPerRow)
                {
                    x = 10;
                    y += buttonHeight + spacing;
                    buttonsInRow = 0;
                }

            

            }
        }

      

        private void BackButton_Click(object sender, EventArgs e)
        {
            LanguageSelection languageSelection = new LanguageSelection(valoda, user);
            this.Close();
            languageSelection.Show();
        }

        private void Levels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            { 
                Pause pause = new Pause(user, this);
                pause.ShowDialog();
            }
        }

        private void DifficultyFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDifficulty = DifficultyFilter.SelectedItem.ToString();

            if(selectedDifficulty == "All")
                tasksTable.DefaultView.RowFilter = string.Empty;
            else
                tasksTable.DefaultView.RowFilter = $"Difficulty = '{selectedDifficulty}'";
            levelsLoad();
        }
    }
}
