namespace Teacher_Fight_Hallway
{
    partial class fightStage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fightStage));
            this.lblP1R = new System.Windows.Forms.Label();
            this.lblP2L = new System.Windows.Forms.Label();
            this.lblP1Health = new System.Windows.Forms.Label();
            this.lblP2Health = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblP1R
            // 
            this.lblP1R.AutoSize = true;
            this.lblP1R.Location = new System.Drawing.Point(292, 497);
            this.lblP1R.Name = "lblP1R";
            this.lblP1R.Size = new System.Drawing.Size(35, 13);
            this.lblP1R.TabIndex = 2;
            this.lblP1R.Text = "label1";
            // 
            // lblP2L
            // 
            this.lblP2L.AutoSize = true;
            this.lblP2L.Location = new System.Drawing.Point(720, 510);
            this.lblP2L.Name = "lblP2L";
            this.lblP2L.Size = new System.Drawing.Size(35, 13);
            this.lblP2L.TabIndex = 3;
            this.lblP2L.Text = "label2";
            // 
            // lblP1Health
            // 
            this.lblP1Health.AutoSize = true;
            this.lblP1Health.BackColor = System.Drawing.Color.Transparent;
            this.lblP1Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Health.Location = new System.Drawing.Point(173, 34);
            this.lblP1Health.Name = "lblP1Health";
            this.lblP1Health.Size = new System.Drawing.Size(66, 24);
            this.lblP1Health.TabIndex = 4;
            this.lblP1Health.Text = "label1";
            // 
            // lblP2Health
            // 
            this.lblP2Health.AutoSize = true;
            this.lblP2Health.BackColor = System.Drawing.Color.Transparent;
            this.lblP2Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Health.Location = new System.Drawing.Point(676, 32);
            this.lblP2Health.Name = "lblP2Health";
            this.lblP2Health.Size = new System.Drawing.Size(66, 24);
            this.lblP2Health.TabIndex = 5;
            this.lblP2Health.Text = "label1";
            // 
            // player2
            // 
            this.player2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Image = global::Teacher_Fight_Hallway.Properties.Resources.BrosiusStandAP2;
            this.player2.Location = new System.Drawing.Point(635, 290);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(163, 177);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // player1
            // 
            this.player1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = global::Teacher_Fight_Hallway.Properties.Resources.ERROR_B_Punch_P1;
            this.player1.Location = new System.Drawing.Point(190, 290);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(137, 177);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // fightStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Teacher_Fight_Hallway.Properties.Resources.Stage;
            this.ClientSize = new System.Drawing.Size(1012, 562);
            this.Controls.Add(this.lblP2Health);
            this.Controls.Add(this.lblP1Health);
            this.Controls.Add(this.lblP2L);
            this.Controls.Add(this.lblP1R);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "fightStage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Fight";
            this.Load += new System.EventHandler(this.fightStage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label lblP1R;
        private System.Windows.Forms.Label lblP2L;
        private System.Windows.Forms.Label lblP1Health;
        private System.Windows.Forms.Label lblP2Health;

    }
}