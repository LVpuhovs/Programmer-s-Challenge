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
    public partial class Settings : Form
    {
        private bool isMuted = false;
        public Settings()
        {
            InitializeComponent();
           
        }

        private void Mute_CheckedChanged(object sender, EventArgs e)
        {
            if (isMuted == false)
            {
                MusicManager.SetVolume(0);
                isMuted = true;
            }
            else if (isMuted == true)
            {
                isMuted = false;
                MusicManager.SetVolume(40);
            }
        }

        private void volumeChange_ValueChanged(object sender, EventArgs e)
        {
            int newVolume = volumeChange.Value;
            MusicManager.SetVolume(newVolume);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
