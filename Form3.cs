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
    public partial class selectFighter : Form
    {
        //declares initial variables
        //public static int player1Fighter = 0;
        //public static int player2Fighter = 0;
        bool p1R = false;
        bool p2R = false;
        public selectFighter()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //returns to menu form
            mainMenu frm4 = new mainMenu();
            frm4.Show();
            this.Hide();
        }

        private void btnf1p1_Click(object sender, EventArgs e)
        {
            ////selects player 1 fighter 1
            c1.player1Fighter = 1;
            btnf1p1.FlatAppearance.BorderColor = Color.Red;
            btnf2p1.FlatAppearance.BorderColor = Color.Gray;
            btnf3p1.FlatAppearance.BorderColor = Color.Gray;
            btnf4p1.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnf2p1_Click(object sender, EventArgs e)
        {
            //selects player 1 fighter 2
            c1.player1Fighter = 2;
            btnf2p1.FlatAppearance.BorderColor = Color.Red;
            btnf1p1.FlatAppearance.BorderColor = Color.Gray;
            btnf3p1.FlatAppearance.BorderColor = Color.Gray;
            btnf4p1.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnf3p1_Click(object sender, EventArgs e)
        {
            ////selects player 1 fighter 3
            c1.player1Fighter = 3;
            btnf3p1.FlatAppearance.BorderColor = Color.Red;
            btnf2p1.FlatAppearance.BorderColor = Color.Gray;
            btnf1p1.FlatAppearance.BorderColor = Color.Gray;
            btnf4p1.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnf4p1_Click(object sender, EventArgs e)
        {
            ////selects player 1 fighter 4
            c1.player1Fighter = 4;
            btnf4p1.FlatAppearance.BorderColor = Color.Red;
            btnf2p1.FlatAppearance.BorderColor = Color.Gray;
            btnf3p1.FlatAppearance.BorderColor = Color.Gray;
            btnf1p1.FlatAppearance.BorderColor = Color.Gray;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ////selects player 2 fighter 1
            c1.player2Fighter = 1;
            button7.FlatAppearance.BorderColor = Color.Red;
            btnf2p2.FlatAppearance.BorderColor = Color.Gray;
            btnf3p2.FlatAppearance.BorderColor = Color.Gray;
            btnf4p2.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnf2p2_Click(object sender, EventArgs e)
        {
        //    //selects player 2 fighter 2
            c1.player2Fighter = 2;
            btnf2p2.FlatAppearance.BorderColor = Color.Red;
            button7.FlatAppearance.BorderColor = Color.Gray;
            btnf3p2.FlatAppearance.BorderColor = Color.Gray;
            btnf4p2.FlatAppearance.BorderColor = Color.Gray;
       }

        private void btnf3p2_Click(object sender, EventArgs e)
        {
            ////selects player 2 fighter 3
            c1.player2Fighter = 3;
            btnf3p2.FlatAppearance.BorderColor = Color.Red;
            button7.FlatAppearance.BorderColor = Color.Gray;
            btnf2p2.FlatAppearance.BorderColor = Color.Gray;
            btnf4p2.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnf4p2_Click(object sender, EventArgs e)
        {
            ////selects player 2 fighter 4
            c1.player2Fighter = 4;
            btnf4p2.FlatAppearance.BorderColor = Color.Red;
            button7.FlatAppearance.BorderColor = Color.Gray;
            btnf3p2.FlatAppearance.BorderColor = Color.Gray;
            btnf2p2.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            //checks for player 1 to be ready
            if (c1.player1Fighter != 0)
            {
                p1R = true;
                btnConfirm1.FlatAppearance.BorderColor = Color.Green;
            }
            if (p1R & p2R & c1.player1Fighter != 0 & c1.player2Fighter != 0)
            {
                //insert form link to fight
                //MessageBox.Show("working");
                fightStage frm5 = new fightStage();
                frm5.Show();
                this.Hide();
            }
        }

        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            //checks for player 2 to be ready
            if (c1.player2Fighter != 0)
            {
                p2R = true;
                btnConfirm2.FlatAppearance.BorderColor = Color.Green;
            }
            if (p1R & p2R & c1.player1Fighter != 0 & c1.player2Fighter != 0)
            {
                //insert form link to fight
                fightStage frm5 = new fightStage();
                frm5.Show();
                this.Hide();
            }
        }
    }
}
