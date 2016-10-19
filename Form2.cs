using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Fight_Hallway
{
    public partial class soundtrack : Form
    {
        public soundtrack()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //returns to menu form
            mainMenu Form2 = new mainMenu();
            Form2.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string song = listBox1.Text;
            if (song == "Kalimba"){
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "Resources.Kalimba";
                player.Play();
            }
        }
    }
}
