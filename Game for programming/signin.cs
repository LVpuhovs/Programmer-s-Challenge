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
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            User user = (from DataRow row in userTable.Rows
                         where row["Username"].ToString() == usernameTxtBx.Text && row["Password"].ToString() == passwordTxtBx.Text
                         select new User
                         {
                             Username = row["Username"].ToString(),
                             Id = (int)row["ID"],
                             Email = row["Email"].ToString(),
                             Role = row["Role"].ToString(),
                         }).FirstOrDefault();
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
