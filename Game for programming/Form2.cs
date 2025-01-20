using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace Game_for_programming
{
    public partial class Form2 : Form
    {
        public Language valoda;
        public Form2(Language language)
        {
            InitializeComponent();
            valoda = language;
            UpdateTexts();
        }
        private void UpdateTexts()
        {
            if (valoda.language == "English")
            {
                runButton.Text = "Run";
                NextButton.Text = "Next";
                BackButton.Text = "Back";
            }
            else if (valoda.language == "Latviešu")
            {
                runButton.Text = "Palaist";
                NextButton.Text = "Nākamais";
                BackButton.Text = "Atpakaļ";
            }
        }
        private async void runButton_Click(object sender, EventArgs e)
        {
            string userCode = userCodeTxtBx.Text;
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            try
            {
                var scriptOptions = ScriptOptions.Default
                .WithReferences(AppDomain.CurrentDomain.GetAssemblies())
                .WithImports("System",
                    "System.Collections.Generic",
                    "System.Linq",
                    "System.Text",
                    "System.Windows.Forms",
                    "System.IO",
                    "System.Threading.Tasks");

                await CSharpScript.RunAsync(userCode, scriptOptions);
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

        private void BackButton_Click(object sender, EventArgs e)
        {

        }
    }
}
