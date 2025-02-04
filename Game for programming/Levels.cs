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
        public Levels(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void level1Btn_Click(object sender, EventArgs e)
        {
            Game game = new Game(valoda,user);
            this.Hide();
            game.Show();
        }
    }
}
