using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace Game_for_programming
{
    public partial class Game : Form
    {
        public Language valoda;
        private User user;
        public Language programmingLanguage;
        private DataTable tasksTable = new DataTable();
        private DataTable userTasksTable = new DataTable();
        private int taskId;
        public Game(Language language, User user, Language selectedLanguage, int taskId)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.user = user;
            valoda = language;
            this.programmingLanguage = selectedLanguage;
            this.taskId = taskId;
            UpdateTexts();
            selectedLanguageLBL.Text = programmingLanguage.ToString();

            userTasksTable = DataManager.Instance.DataSet.Tables["UserTasks"];
            tasksTable = DataManager.Instance.DataSet.Tables["Tasks"];

            if (tasksTable == null)
            {
                if (valoda.ToString() == "Latviešu")
                    MessageBox.Show("Uzdevumu tabula nav ielādēta.");
                    
                else if (valoda.ToString() == "English")
                    MessageBox.Show("Couldn't load task table.");
                
                return;
            }

            DataRow[] selectedTask = tasksTable.Select($"IdTasks = {taskId}");
            if (selectedTask.Length > 0)
            {
                if (valoda.ToString() == "Latviešu")
                {
                    string task = selectedTask[0]["TaskLV"].ToString();
                    TaskLbl.Text = task;
                    string description = selectedTask[0]["DescriptionLV"].ToString();
                    MessageBox.Show($"{description}", "Apraksts");
                }
                else if (valoda.ToString() == "English")
                {
                    string task = selectedTask[0]["TaskEng"].ToString();
                    TaskLbl.Text = task;
                    string description = selectedTask[0]["DescriptionEng"].ToString();
                    MessageBox.Show($"{description}", "Description");
                }
                
            }
            else
            {
                
                if (valoda.ToString() == "Latviešu")
                    TaskLbl.Text = "Uzdevums nav atrasts";
                    

                else if (valoda.ToString() == "English")
                    TaskLbl.Text = "Couldn't find the task";
            }

            taskPanel.AutoSize = true;
            taskPanel.WrapContents = true;
            taskPanel.Controls.Add(TaskLbl);
        }
        private void UpdateTexts()
        {
            if (valoda.ToString() == "English")
            {
                runButton.Text = "Run";
                DoneButton.Text = "Done";
                BackButton.Text = "Back";
                OutputLbl.Text = "Output";
                DescriptionButton.Text = "Description";
            }
            else if (valoda.ToString() == "Latviešu")
            {
                runButton.Text = "Palaist";
                DoneButton.Text = "Pabeigt";
                BackButton.Text = "Atpakaļ";
                OutputLbl.Text = "Izvade";
                DescriptionButton.Text = "Apraksts";
            }
        }
        private async void runButton_Click(object sender, EventArgs e)
        {
            string userCode = userCodeTxtBx.Text;
            string selectedLanguage = programmingLanguage.ToString();
            switch (selectedLanguage)
            {
                case "C#":
                    await ExecuteCSharpCode(userCode);
                    break;

                case "JAVA":
                    outputTxtBx.Text = ExecuteJavaCode(userCode);
                    break;
                case "Python":
                    outputTxtBx.Text = executePythonCode(userCode);
                    break;
                default:
                    outputTxtBx.Text = "unsupported language";
                    break;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Levels levels = new Levels(valoda, user, programmingLanguage);
            this.Hide();
            levels.Show();
        }

        // Roslyn metode
        // piemērs https://stackoverflow.com/questions/32769630/how-to-compile-a-c-sharp-file-with-roslyn-programmatically
        private async Task ExecuteCSharpCode(string code)
        {
            var stringWriter = new StringWriter();
            var originalOutput = Console.Out;
            Console.SetOut(stringWriter);

            var scriptOptions = ScriptOptions.Default
                .WithReferences(
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(StringBuilder).Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(Console).Assembly.Location))
                .WithImports("System", "System.Linq", "System.Text");

            if (code.Contains("while(true") || code.Contains("for(;;") || code.Contains("Thread.Sleep"))
            {
                outputTxtBx.Text = valoda.ToString() == "Latviešu"
                    ? "Kods satur iespējamu bezgalīgu ciklu un tika bloķēts."
                    : "Code contains a potential infinite loop and was blocked.";
                Console.SetOut(originalOutput);
                stringWriter.Dispose();
                return;
            }

            Exception scriptException = null;
            var threadFinished = false;

            Thread scriptThread = new Thread(() =>
            {
                try
                {
                    var task = CSharpScript.RunAsync(code, scriptOptions);
                    task.Wait();
                }
                catch (Exception ex)
                {
                    scriptException = ex;
                }
                threadFinished = true;
            });

            scriptThread.IsBackground = true;
            scriptThread.Start();

            int timeoutMs = 3000;
            int checkInterval = 100;

            for (int waited = 0; waited < timeoutMs && !threadFinished; waited += checkInterval)
            {
                await Task.Delay(checkInterval);
            }

            if (!threadFinished)
            {
                scriptThread.Abort();
                outputTxtBx.Text = valoda.ToString() == "Latviešu"
                    ? "Izpilde tika atcelta – skripts bija pārāk ilgs."
                    : "Execution cancelled – script took too long.";
            }
            else if (scriptException is CompilationErrorException cee)
            {
                outputTxtBx.Text = $"Kļūdas:\n{string.Join("\n", cee.Diagnostics)}";
            }
            else if (scriptException != null)
            {
                outputTxtBx.Text = valoda.ToString() == "Latviešu"
                    ? $"Izpildes kļūda:\n{scriptException.Message}"
                    : $"Run Error:\n{scriptException.Message}";
            }
            else
            {
                outputTxtBx.Text = stringWriter.ToString();
            }

            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }

        // piemērs JAVA kodam ņemts no https://www.quora.com/Can-we-compile-and-run-a-Java-file-using-C
        private string ExecuteJavaCode(string code)
        {
            string filePath = "Main.java";
            File.WriteAllText(filePath, "public class Main { public static void main(String[] args) { " + code + "} }");

            try
            {
                ProcessStartInfo start = new ProcessStartInfo("javac", filePath)
                {
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = Process.Start(start);
                process.WaitForExit();

                if (process.ExitCode != 0)
                    return process.StandardError.ReadToEnd();

                ProcessStartInfo run = new ProcessStartInfo("java", "Main")
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                process = Process.Start(run);
                string output = process.StandardOutput.ReadToEnd();
                string errorOutput = process.StandardError.ReadToEnd();

                process.WaitForExit();
                if (!string.IsNullOrEmpty(errorOutput))
                {
                    return "Error: " + errorOutput;
                }
                return output;
            }
            catch (Exception ex)
            {
                return $"Izpildes kļūda: {ex.Message}";
            }
        }
        // python kodam izmantots piemērs https://medium.com/@hanxuyang0826/triggering-python-code-from-c-a-practical-guide-84b17d593dc6 un java palaisanai kods
        // kods nodaļā Detailed Example: Generating Bokeh Visualizations
        private string executePythonCode(string code)
        {
            string filepath = "python.py";
            File.WriteAllText(filepath, code);

            try
            {
                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = filepath,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };
                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        return result;
                    }
                }
            }catch (Exception ex)
            {
                return $"Izpildes kļūda: {ex.Message}";
            }
            
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string userAnswer = outputTxtBx.Text.Replace("\r\n", " ").Replace("\n", " ").Trim();

            bool isCorrect = DataManager.Instance.saveUserAnwser(user.IdUser, taskId, userAnswer, programmingLanguage.ToString());
            if (isCorrect)
            {
                if (valoda.ToString() == "Latviešu")
                    MessageBox.Show("Pareizi!");
                else if (valoda.ToString() == "English")
                    MessageBox.Show("Correct!");
                Levels levels = new Levels(valoda, user, programmingLanguage);
                this.Hide();
                levels.Show();
            }
            else
            {
                if (valoda.ToString() == "Latviešu")
                    MessageBox.Show("Nepareizi!");
                else if (valoda.ToString() == "English")
                    MessageBox.Show("Incorrect!");
            }
        }

        private void DescriptionButton_Click(object sender, EventArgs e)
        {
            DataRow[] selectedTask = tasksTable.Select($"IdTasks = {taskId}");
            if (valoda.ToString() == "Latviešu")
            {
                string description = selectedTask[0]["DescriptionLV"].ToString();
                MessageBox.Show($"{description}", "Apraksts");
            }
            else if (valoda.ToString() == "English")
            {
                string description = selectedTask[0]["DescriptionEng"].ToString();
                MessageBox.Show($"{description}", "Description");
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Pause pause = new Pause(user, this);
                pause.ShowDialog();
            }
        }
    }
}

