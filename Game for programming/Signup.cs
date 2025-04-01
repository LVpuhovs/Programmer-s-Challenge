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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            PasswordTxtBx.PasswordChar = '*';
        }

        private void SignInLbl_Click(object sender, EventArgs e)
        {
            signin signin = new signin();
            this.Hide();
            signin.Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBx.Text.Trim();
            string name = NameTxtBx.Text.Trim();
            string password = PasswordTxtBx.Text.Trim();
            string email = EmailTxtBx.Text.Trim();

            string role = "";
            if (RoleSelection.CheckedItems.Count > 0)
            {
                role = RoleSelection.CheckedItems[0].ToString();
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || 
                string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
            {
               
                
                MessageBox.Show("Please fill in all fields and select a role.");
                return;
                
            }
            
            DataManager.Instance.AddUser(username, name, password, email, role);
        }

        private void RoleSelection_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < RoleSelection.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    RoleSelection.SetItemChecked(i, false);
                }
            }
        }
    }
}
