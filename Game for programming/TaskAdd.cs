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
    public partial class TaskAdd : Form
    {
        private User user;
        private Language valoda;
        private DataTable tasksTable = new DataTable();
        public TaskAdd(User user, Language valoda)
        {
            InitializeComponent();
            this.user = user;
            this.valoda = valoda;
            tasksTable = DataManager.Instance.DataSet.Tables["Tasks"];
            if (tasksTable == null)
            {
                if (valoda.ToString() == "Latviešu")
                    MessageBox.Show("Uzdevumu tabula nav ielādēta.");

                else if (valoda.ToString() == "English")
                    MessageBox.Show("Couldn't load task table.");
                return;
            }

            TaskLVLBL.Text = valoda.ToString() == "Latviešu"? "Uzdevuma nosacījums latviešu valodā": "Task in Latvian";
            DescriptionLV.Text = valoda.ToString() == "Latviešu" ? "Uzdevuma apraksts latviešu valodā" : "Description in Latvian";
            TaskENGLbl.Text = valoda.ToString() == "Latviešu" ? "Uzdevuma nosacījums angļu valodā" : "Task in English";
            DescriptionEngLBL.Text = valoda.ToString() == "Latviešu" ? "Uzdevuma apraksts angļu valodā" : "Description in English";
            AnswerLbl.Text = valoda.ToString() == "Latviešu" ? "Atbilde" : "Answer";
            DifficultyLbl.Text = valoda.ToString() == "Latviešu" ? "Grūtības pakāpe" : "Difficulty";
            AddTaskBtn.Text = valoda.ToString() == "Latviešu" ? "Pievienot Uzdevumu" : "Add Task";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            TaskList taskList = new TaskList(user, valoda);
            taskList.Show();
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            string taskLV = TaskLVTxtBx.Text.Trim();
            string descriptionLV = DescriptionLVTxtBx.Text.Trim();
            string taskEng = TaskENGTxtBx.Text.Trim();
            string descriptionEng = DescriptionENGTxtBx.Text.Trim();
            string answer = AnswerTxtBx.Text.Trim();

            string difficulty = "";
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                difficulty = checkedListBox1.CheckedItems[0].ToString();
            }
            if(string.IsNullOrWhiteSpace(taskLV) && string.IsNullOrWhiteSpace(taskEng) ||
                string.IsNullOrWhiteSpace(descriptionLV) && string.IsNullOrWhiteSpace(descriptionEng) ||
                string.IsNullOrWhiteSpace(answer) || string.IsNullOrEmpty(difficulty))
            {
                MessageBox.Show(valoda.ToString() == "Latviešu"?
                    "Nepieciešams aizpildīt atbildes, grūības līmeņa, uzdevuma nosacījumu un aprakstu, vismaz vienā valodā, laukus!":
                    "Please fill fields in answer, difficulty, task and description in at least one language");
                return;
            }
            DataManager.Instance.saveTask(difficulty, taskLV, descriptionLV, taskEng, descriptionEng, answer);
            TaskList taskList = new TaskList(user, valoda);
            this.Close();
            taskList.Show();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }
    }
}
