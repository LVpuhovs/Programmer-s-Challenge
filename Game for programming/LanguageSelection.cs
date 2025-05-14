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
    public partial class LanguageSelection : Form
    {
        public Language valoda;
        public Language selectedLanguage;
        private User user;
        public LanguageSelection(Language language, User loggedInUser = null)
        {
            InitializeComponent();
            this.KeyPreview = true;
            valoda = language;
            selectedLanguage = new Language("C#");
            if (valoda.ToString() == "Latviešu")
                PreferedLanguageLbl.Text = "Izvēlies vēlamo valodu";

            else if (valoda.ToString() == "English")
                PreferedLanguageLbl.Text = "Choose Prefferred Language";
            if (loggedInUser != null)
            {
                user = loggedInUser;
               
            }
        }

        private void LanguageSelection_Load(object sender, EventArgs e)
        {

        }

        private void cSharpButton_Click(object sender, EventArgs e)
        {
            selectedLanguage = new Language("C#");
            Levels levels = new Levels(valoda, user, selectedLanguage);
            this.Hide();
            levels.Show();
        }

        private void JavaButton_Click(object sender, EventArgs e)
        {
            selectedLanguage = new Language("JAVA");
            Levels levels = new Levels(valoda, user, selectedLanguage);
            this.Hide();
            levels.Show();
        }

        private void PythonButton_Click(object sender, EventArgs e)
        {
            selectedLanguage = new Language("Python");
            Levels levels = new Levels(valoda, user, selectedLanguage);
            this.Hide();
            levels.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(user);
            this.Hide();
            menu.Show();
        }

        private void LanguageSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Pause pause = new Pause(user, this);
                pause.ShowDialog();
            }
        }
    }
}
