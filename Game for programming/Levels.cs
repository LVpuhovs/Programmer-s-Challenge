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
        public Levels(Language valoda, User user, Language selectedLanguage)
        {
            InitializeComponent();
            this.user = user;
            this.selectedLanguage = selectedLanguage;
            this.valoda = valoda;
            tasksTable = DataManager.Instance.DataSet.Tables["Tasks"];
            if (tasksTable == null)
            {
                MessageBox.Show("Uzdevumu tabula nav ielādēta.");
                return;
            }
        }
        private void levelsLoad(object sender, EventArgs e)
        {
            levelsPanel.Controls.Clear();

            int x = 10, y = 10;
            int buttonWidth = 100;
            int buttonHeight = 40;
            int spacing = 10;

            int counter = 1;

            foreach (DataRow row in tasksTable.Rows)
            {
                Button taskButton = new Button();
                taskButton.Text = $"Level {counter}";
                taskButton.Width = buttonWidth;
                taskButton.Height = buttonHeight;
                taskButton.Left = x;
                taskButton.Top = y;

                var taskRow = row;
                taskButton.Click += (s, args) =>
                {
                    int taskId = Convert.ToInt32(taskRow["idTasks"]);
                    Game game = new Game(valoda, user, selectedLanguage, taskId);
                    this.Hide();
                    game.Show();
                };

                levelsPanel.Controls.Add(taskButton);

                y += buttonHeight + spacing;
                counter++;
            }
        }

      

        private void BackButton_Click(object sender, EventArgs e)
        {
            LanguageSelection languageSelection = new LanguageSelection(valoda, user);
            this.Hide();
            languageSelection.Show();
        }
    }
}
