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
            this.KeyPreview = true;
            Backbtn.Text = valoda.ToString() == "Latviešu"? "Atpakaļ": "Back";

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

            Button addTask = new Button();
            
            addTask.Width = 100;
            addTask.Height = 40;
            addTask.Text =valoda.ToString() == "Latviešu"? "Pievienot Uzdevumu": "Add task";
            TaskPannel.Controls.Add(addTask);
            addTask.Click += (s, e) => 
            {
                TaskAdd taskAddForm = new TaskAdd(user, valoda);
                this.Close();
                taskAddForm.Show();
            };
            

            int counter = 1;
            foreach (DataRow row in tasksTable.Rows)
            {
                Panel panel = new Panel();
                panel.Width = TaskPannel.Width - 5;
                panel.Height = 40;

                Label idlbl = new Label();
                idlbl.Text = counter.ToString();
                idlbl.Width = 50;
                idlbl.TextAlign = ContentAlignment.MiddleLeft;

                Label taskLV = new Label();
                taskLV.Text = row["TaskLV"].ToString();
                taskLV.Width = 400;
                taskLV.Left = idlbl.Right + 5;
                taskLV.TextAlign = ContentAlignment.MiddleLeft;

                Label Difficulty = new Label();
                Difficulty.Text = row["Difficulty"].ToString();
                Difficulty.Width = 50;
                Difficulty.Left = taskLV.Right + 5;
                Difficulty.TextAlign = ContentAlignment.MiddleLeft;

                Label taskENG = new Label();
                taskENG.Text = row["TaskEng"].ToString();
                taskENG.Width = 400;
                taskENG.Left = Difficulty.Right + 5;
                taskENG.TextAlign = ContentAlignment.MiddleLeft;

                Button removeTask = new Button();
                removeTask.Width = 100;
                removeTask.Height = 40; 
                removeTask.Text = valoda.ToString() == "Latviešu"? "Noņemt Uzdevumu": "Remove Task";
                removeTask.Left = taskENG.Right + 5;

                Button editTask = new Button();
                editTask.Width = 100;
                editTask.Height = 40;
                editTask.Text = valoda.ToString() == "Latviešu" ? "Rediģēt Uzdevumu" : "Edit Task";
                editTask.Left = removeTask.Right + 5;
                editTask.Click += (s, e) =>
                {
                    TaskAdd taskEditForm = new TaskAdd(user, valoda, row);
                    this.Close();
                    taskEditForm.Show();
                };

                panel.Controls.Add(idlbl);
                panel.Controls.Add(taskLV);
                panel.Controls.Add(Difficulty);
                panel.Controls.Add(taskENG);
                panel.Controls.Add(removeTask);
                panel.Controls.Add(editTask);
                removeTask.Click += (s, e) =>
                {
                    var confirm = MessageBox.Show(valoda.ToString() == "Latviešu"?
                        "Vai esi pārliecināts, ka vēlies izdzēst uzdevumu?":"Are you sure to delete this task?",
                        "Confirm Delete", MessageBoxButtons.YesNo);

                    if (confirm != DialogResult.Yes)
                        return;

                    int taskId = Convert.ToInt32(row["idTasks"]);
                    DataRow[] rowsToDelete = tasksTable.Select($"IdTasks = {taskId}");
                    DataManager.Instance.deleteTasks(taskId);
                    DataManager.Instance.LoadData(Program.connectionString);

                    taskTableLoad();
                };
                
                
                TaskPannel.Controls.Add(panel);
                


                counter++;
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(user);
            DataManager.Instance.LoadData(Program.connectionString);
            this.Close();
            menu.Show();
        }

        private void TaskList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Pause pause = new Pause(user, this);
                pause.ShowDialog();
            }
        }
    }
}
