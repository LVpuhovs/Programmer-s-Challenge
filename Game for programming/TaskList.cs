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
    public partial class TaskList : Form
    {
        private User user;
        private Language valoda;
        private DataTable tasksTable = new DataTable();

        public TaskList(User user, Language valoda)
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
            taskTableLoad();
        }

        private void taskTableLoad()
        {
            TaskPannel.Controls.Clear();
            TaskPannel.AutoScroll = true;
            TaskPannel.WrapContents = false;
            TaskPannel.FlowDirection = FlowDirection.TopDown;

            int counter = 1;
            foreach (DataRow row in tasksTable.Rows)
            {
                Panel panel = new Panel();
                panel.Width = TaskPannel.Width - 25;
                panel.Height = 25;

                Label idlbl = new Label();
                idlbl.Text = counter.ToString();
                idlbl.Width = 50;
                idlbl.TextAlign = ContentAlignment.MiddleLeft;

                Label taskLV = new Label();
                taskLV.Text = row["TaskLV"].ToString();
                taskLV.Width = 400;
                taskLV.Left = idlbl.Right + 10;
                taskLV.TextAlign = ContentAlignment.MiddleLeft;

                Label Difficulty = new Label();
                Difficulty.Text = row["Difficulty"].ToString();
                Difficulty.Width = 50;
                Difficulty.Left = taskLV.Right + 10;
                Difficulty.TextAlign = ContentAlignment.MiddleLeft;

                Label taskENG = new Label();
                taskENG.Text = row["TaskEng"].ToString();
                taskENG.Width = 400;
                taskENG.Left = Difficulty.Right + 10;
                taskENG.TextAlign = ContentAlignment.MiddleLeft;

                panel.Controls.Add(idlbl);
                panel.Controls.Add(taskLV);
                panel.Controls.Add(Difficulty);
                panel.Controls.Add(taskENG);
                
                TaskPannel.Controls.Add(panel);
                


                counter++;
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(user);
            this.Hide();
            menu.Show();
        }
    }
}
