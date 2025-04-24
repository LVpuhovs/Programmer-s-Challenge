using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        private int taskId;
        public Game(Language language, User user, Language selectedLanguage, int taskId)
        {
            InitializeComponent();
            this.user = user;
            valoda = language;
            valoda = new Language("English");
            this.programmingLanguage = selectedLanguage;
            UpdateTexts();
            selectedLanguageLBL.Text = programmingLanguage.ToString();


            tasksTable = DataManager.Instance.DataSet.Tables["Tasks"];
            if (tasksTable == null)
            {
                MessageBox.Show("Uzdevumu tabula nav ielādēta.");
                return;
            }

            DataRow[] selectedTask = tasksTable.Select($"IdTasks = {taskId}");
            if (selectedTask.Length > 0)
            {
                string task = selectedTask[0]["Task"].ToString();
                TaskLbl.Text = task;
            }
            else
            {
                TaskLbl.Text = "Uzdevums nav atrasts";

            }

            taskPanel.AutoSize = true;
            taskPanel.WrapContents = true;
            taskPanel.Controls.Add(TaskLbl);
        }
        private void UpdateTexts()
        {
            if (valoda.language == "English")
            {
                runButton.Text = "Run";
                DoneButton.Text = "Next";
                BackButton.Text = "Back";
            }
            else if (valoda.language == "Latviešu")
            {
                runButton.Text = "Palaist";
                DoneButton.Text = "Nākamais";
                BackButton.Text = "Atpakaļ";
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
        private async Task ExecuteCSharpCode(string code)
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            try
            {
                var scriptOptions = ScriptOptions.Default
                .WithReferences(AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => !string.IsNullOrWhiteSpace(a.Location))
                .Select(a => MetadataReference.CreateFromFile(a.Location)))
                .WithImports("System",
                    "System.Collections.Generic",
                    "System.Linq",
                    "System.Text",
                    "System.Windows.Forms",
                    "System.IO",
                    "System.Threading.Tasks");

                await CSharpScript.RunAsync(code, scriptOptions);
                outputTxtBx.Text = stringWriter.ToString();
            }
            catch (CompilationErrorException ex)
            {
                outputTxtBx.Text = $"Kļūdas:\n{string.Join("\n", ex.Diagnostics)}";
            }
            catch (Exception ex)
            {
                outputTxtBx.Text = $"Izpildes kļūda:\n{ex.Message}";
            }
            finally
            {
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
            }

        }
        // piemers JAVA kodam nemts no https://www.quora.com/Can-we-compile-and-run-a-Java-file-using-C
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
            
        }
    }
}

