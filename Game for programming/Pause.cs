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
    public partial class Pause : Form
    {
        private User user;
        private Form previousForm;
        public Pause(User currentUser, Form previousForm)
        {
            InitializeComponent();
            this.user = currentUser;
            this.previousForm = previousForm;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            using (Settings settings = new Settings())
            {
                settings.ShowDialog();
            }
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Close();
            previousForm.Close();
            new Menu(user).Show();
        }

        private void QuitGamebtn_Click(object sender, EventArgs e)
        {
            previousForm.Close();
            this.Close();
            Application.Exit();
        }
    }
}
