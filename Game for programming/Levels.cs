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
        public Levels(Language valoda, User user, Language selectedLanguage)
        {
            InitializeComponent();
            this.user = user;
            this.selectedLanguage = selectedLanguage;
            this.valoda = valoda;
        }

        private void level1Btn_Click(object sender, EventArgs e)
        {
            Game game = new Game(valoda,user,selectedLanguage);
            this.Hide();
            game.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LanguageSelection languageSelection = new LanguageSelection(valoda, user);
            this.Hide();
            languageSelection.Show();
        }
    }
}
