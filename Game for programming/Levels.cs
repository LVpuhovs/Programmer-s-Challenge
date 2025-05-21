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
        }
        private void levelsLoad(object sender, EventArgs e)
        {
            levelsPanel.Controls.Clear();
            List<int> completedTasks = DataManager.Instance.getCompletedTaskId(user.IdUser, selectedLanguage.ToString());

            int x = 10, y = 10;
            int buttonWidth = 100;
            int buttonHeight = 40;
            int spacing = 10;
            int maxButtonsPerRow = 5;

            int counter = 1;

            foreach (DataRowView rowView in tasksTable.DefaultView)
            {
                DataRow row = rowView.Row;
                Button taskButton = new Button();

                if (valoda.ToString() == "Latviešu")
                    taskButton.Text = $"{counter} Līmenis";
                    
                else if (valoda.ToString() == "English")
                    taskButton.Text = $"Level {counter}";
                
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

                if (counter % maxButtonsPerRow == 0)
                {
                    x = 10;
                    y += buttonHeight + spacing;
                }

                counter++;
            }
        }

      

        private void BackButton_Click(object sender, EventArgs e)
        {
            LanguageSelection languageSelection = new LanguageSelection(valoda, user);
            this.Hide();
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
            levelsLoad(null, EventArgs.Empty);
        }
    }
}
