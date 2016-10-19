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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            //opens fighter selection form
            selectFighter frm3 = new selectFighter();
            frm3.Show();
            this.Hide();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            //opens soundtrack form
            soundtrack frm = new soundtrack();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exits program
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
