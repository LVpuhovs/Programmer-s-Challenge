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
    public partial class Menu : Form
    {
        public Language valoda;
        private User user;
        public Menu(User loggedInUser = null)
        {
            InitializeComponent();
            valoda = new Language("English");

            if (loggedInUser != null)
            {
                user = loggedInUser;
                UsernameLbl.Text = "Hey, " + user.Username.ToString() + "!";
                signinbtn.Hide();
                signupbtn.Hide();
                SignOutBtn.Show();
            }
            else
            {
                SignOutBtn.Hide();
                
            }
        }

        private void English_Click(object sender, EventArgs e)
        {
            valoda.language = "English";
            PlayBtn.Text = "Play";
            SettingsBtn.Text = "Settings";
            QuitBtn.Text = "Quit";
            signinbtn.Text = "Sign In";
            signupbtn.Text = "Sign Up";
            SignOutBtn.Text = "Sign Out";
        }

        private void Latvian_Click(object sender, EventArgs e)
        {
            valoda.language = "Latviešu";
            PlayBtn.Text = "Spēlēt";
            SettingsBtn.Text = "Iestatījumi";
            QuitBtn.Text = "Iziet";
            signinbtn.Text = "Pieslēgties";
            signupbtn.Text = "Pievienoties";
            SignOutBtn.Text = "Atslēgties";
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if(user == null)
            {
                signin signin = new signin();
                this.Hide();
                signin.Show();
            }
            else
            {
                LanguageSelection languageSelection = new LanguageSelection(valoda, user);
                this.Hide();
                languageSelection.Show();
            }
           
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                signin signin = new signin();
                this.Hide();
                signin.Show();
            }
            
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            user = null;
            signinbtn.Show();
            signupbtn.Show();
            SignOutBtn.Hide();
            UsernameLbl.Text = "";

        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                Signup signup = new Signup();
                this.Hide();
                signup.Show();
            }
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            using (Settings settings = new Settings())
            {
                settings.ShowDialog();
            }


        }
    }
}
