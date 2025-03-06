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
    public partial class signin : Form
    {
        private DataTable userTable = new DataTable();
        public signin()
        {
            InitializeComponent();
            userTable = DataManager.Instance.DataSet.Tables["Users"];
            passwordTxtBx.PasswordChar = '*';
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBx.Text.Trim();
            string password = passwordTxtBx.Text.Trim();

            User user = DataManager.Instance.AuthenticateUser(username, password);

            if (user != null)
            {
                MessageBox.Show($"Logged in with user: {user.Username}");
                new Menu(user).Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void signupLbl_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.Show();
        }
    }
}
