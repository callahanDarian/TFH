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
    public partial class fightStage : Form
    {
        public fightStage()
        {
            InitializeComponent();
        }
        public void punch()
        {
            //punch
            int p2y = player2.Left;
            if ((player2.Left - player1.Right) <= 20)
            {
                var t = Task.Run(async delegate
                {
                    await Task.Delay(50);
                    return 42;
                });
                c1.p2Health = c1.p2Health - 50;
                lblP2Health.Text = ("" + c1.p2Health);
                if (c1.p2Health <= 0)
                {
                    MessageBox.Show("Player 1 Wins");
                    mainMenu Form2 = new mainMenu();
                    Form2.Show();
                    this.Hide();
                }
                while (player2.Left < (p2y + 40) & player2.Right <= 1032)
                {
                    player2.Left = player2.Left + 25;
                    t.Wait();
                }
            }
        }
        public void jump()
        {
            //jump on W key
            while (player1.Top > (c1.player1Y - 70))
            {
                var t = Task.Run(async delegate
                {
                    await Task.Delay(100);
                    return 42;
                });
                player1.Top = player1.Top - 10;
                t.Wait();
            }
            while (c1.player1Y > player1.Top)
            {
                var t = Task.Run(async delegate
                {
                    await Task.Delay(10);
                    return 42;
                });
                player1.Top = player1.Top + 25;
                t.Wait();
            }
        }
        //
        //AI CODE
        //
        public void ai()
        {
            int p1y = player1.Left;
            if ((player2.Left - player1.Right) <= 20)
            {
                //ai punch
                if (c1.player2Fighter == 1)
                    player2.Image = Properties.Resources.BrosiusAPunchP2;
                if (c1.player2Fighter == 2)
                    player2.Image = Properties.Resources.BrosiusBPunchP2;
                if (c1.player2Fighter == 3)
                    player2.Image = Properties.Resources.ERRORAPunchP2;
                if (c1.player2Fighter == 4)
                    player2.Image = Properties.Resources.ERRORBPunchP2;
                var t = Task.Run(async delegate
                {
                    await Task.Delay(50);
                    return 42;
                });
                c1.p1Health = c1.p1Health - 50;
                while (player2.Left < (p1y + 40) & player1.Right <= 1032)
                {
                    player1.Left = player1.Left - 50;
                    t.Wait();
                }

                lblP1Health.Text = ("" + c1.p1Health);
            }
            //ai win code
            if (c1.p1Health <= 0)
            {
                MessageBox.Show("Player 2 Wins");
                mainMenu Form2 = new mainMenu();
                Form2.Show();
                this.Hide();
            }
            //ai movement
            if (player1.Right < player2.Left)
            {
                if (c1.player2Fighter == 1)
                    player2.Image = Properties.Resources.BrosiusWalkFowardAP2;
                if (c1.player2Fighter == 2)
                    player2.Image = Properties.Resources.BrosiusBWalkP2;
                if (c1.player2Fighter == 3)
                    player2.Image = Properties.Resources.ERRORAWalkP2;
                if (c1.player2Fighter == 4)
                    player2.Image = Properties.Resources.ERROR_B_Walk_P2;
                player2.Left = player2.Left - 25;
                var t = Task.Run(async delegate
                {
                    await Task.Delay(100);
                    return 42;
                });
                t.Wait();
            }
        }
        private void fightStage_Load(object sender, EventArgs e)
        {
           //sets player fighter sprites

            //player 1
            if (c1.player1Fighter == 1)
                player1.Image = Properties.Resources.BrosiusStandAP1;
            if (c1.player1Fighter == 2)
                player1.Image = Properties.Resources.BrosiusStandBP1;
            if (c1.player1Fighter == 3)
                player1.Image = Properties.Resources.ERROR_A_Stand_P1;
            if (c1.player1Fighter == 4)
                player1.Image = Properties.Resources.ERROR_B_Stand_P1;

            //player 2
            if (c1.player2Fighter == 1)
                player2.Image = Properties.Resources.BrosiusStandAP2;
            if (c1.player2Fighter == 2)
                player2.Image = Properties.Resources.BrosiusStandBP2;
            if (c1.player2Fighter == 3)
                player2.Image = Properties.Resources.ERROR_A_Stand_P2;
            if (c1.player2Fighter == 4)
                player2.Image = Properties.Resources.ERROR_B_Stand_P2;

            lblP1Health.Text = ("" + c1.p1Health);
            lblP2Health.Text = ("" + c1.p2Health);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ai();
            if (c1.player1Fighter == 1)
                player1.Image = Properties.Resources.BrosiusStandAP1;
            if (c1.player1Fighter == 2)
                player1.Image = Properties.Resources.BrosiusStandBP1;
            if (c1.player1Fighter == 3)
                player1.Image = Properties.Resources.ERROR_A_Stand_P1;
            if (c1.player1Fighter == 4)
                player1.Image = Properties.Resources.ERROR_B_Stand_P1;

                lblP1R.Text = ("" + player1.Right);
                lblP2L.Text = ("" + player2.Left);
                //walk to the left P1
                if (keyData == Keys.A & player1.Left > 0)
                {
                    if (c1.player1Fighter == 1)
                        player1.Image = Properties.Resources.BrosiusWalkBackwardAP1;
                    if (c1.player1Fighter == 2)
                        player1.Image = Properties.Resources.Brosius_B_WalkBackwards_P1;
                    if (c1.player1Fighter == 3)
                        player1.Image = Properties.Resources.ERROR_A_WalkBackwards_P1;
                    if (c1.player1Fighter == 4)
                        player1.Image = Properties.Resources.ERROR_B_WalkBackwards_P1;
                    player1.Left = player1.Location.X - 25;
                    return true;
                }

                //walk to the right P1
                if (keyData == Keys.D & (player1.Right) <= player2.Left)
                {
                    player1.Left = player1.Location.X + 25;
                    if (c1.player1Fighter == 1)
                        player1.Image = Properties.Resources.BrosiusWalkFowardAP1;
                    if (c1.player1Fighter == 2)
                        player1.Image = Properties.Resources.Brosius_B_Walk_P1;
                    if (c1.player1Fighter == 3)
                        player1.Image = Properties.Resources.ERROR_A_Walk_P1;
                    if (c1.player1Fighter == 4)
                        player1.Image = Properties.Resources.ERROR_B_Walk_P1;
                    return true;
                }

                //punch on space button P1
                if (keyData == Keys.Space)
                {
                    if (c1.player1Fighter == 1)
                        player1.Image = Properties.Resources.Brosius_A_Punch_P1;
                    if (c1.player1Fighter == 2)
                        player1.Image = Properties.Resources.Brosius_B_Punch_P1;
                    if (c1.player1Fighter == 3)
                        player1.Image = Properties.Resources.ERROR_A_Punch_P1;
                    if (c1.player1Fighter == 4)
                        player1.Image = Properties.Resources.ERROR_B_Punch_P1;
                    punch();
                    if (c1.player1Fighter == 1)
                        player1.Image = Properties.Resources.BrosiusStandAP1;
                    if (c1.player1Fighter == 2)
                        player1.Image = Properties.Resources.BrosiusStandBP1;
                    if (c1.player1Fighter == 3)
                        player1.Image = Properties.Resources.ERROR_A_Stand_P1;
                    if (c1.player1Fighter == 4)
                        player1.Image = Properties.Resources.ERROR_B_Stand_P1;
                    return true;
                }

                //jump on W button P1
                if (keyData == Keys.W & player1.Location.Y == c1.player1Y)
                {
                    if (c1.player1Fighter == 1)
                        player1.Image = Properties.Resources.Brosius_A_Squat_P1;
                    if (c1.player1Fighter == 2)
                        player1.Image = Properties.Resources.Brosius_B_Squat_P1;
                    if (c1.player1Fighter == 3)
                        player1.Image = Properties.Resources.ERROR_A_Squat_P1;
                    if (c1.player1Fighter == 4)
                        player1.Image = Properties.Resources.ERROR_B_Squat_P1;
                    jump();
                    return true;
                }

            // P1 win
                if (c1.p2Health <= 0)
                {
                    MessageBox.Show("Player 1 Wins");
                    mainMenu Form2 = new mainMenu();
                    Form2.Show();
                    this.Hide();
                }
            // P2 win
            if (c1.p1Health <=0)
            {
                MessageBox.Show("Player 1 Wins");
                mainMenu Form2 = new mainMenu();
                Form2.Show();
                this.Hide();
            }
                return base.ProcessCmdKey(ref msg, keyData);
            }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void player2_Click(object sender, EventArgs e)
        {
        }
        private void btnBtn_Click(object sender, EventArgs e)
        {   
        }
        private void player1_Click(object sender, EventArgs e)
        {
        }
    }
}
