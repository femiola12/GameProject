namespace GameProject
{
    partial class Easy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Easy));
            this.defender1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.defender2 = new System.Windows.Forms.PictureBox();
            this.defender3 = new System.Windows.Forms.PictureBox();
            this.defender4 = new System.Windows.Forms.PictureBox();
            this.Win = new System.Windows.Forms.PictureBox();
            this.GameOver = new System.Windows.Forms.PictureBox();
            this.ballCoin3 = new System.Windows.Forms.PictureBox();
            this.ballCoin2 = new System.Windows.Forms.PictureBox();
            this.ballCoin1 = new System.Windows.Forms.PictureBox();
            this.ballCoin4 = new System.Windows.Forms.PictureBox();
            this.RestartPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Quit_button = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.defender1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defender2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defender3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defender4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballCoin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballCoin4)).BeginInit();
            this.RestartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // defender1
            // 
            this.defender1.BackColor = System.Drawing.Color.Red;
            this.defender1.Image = ((System.Drawing.Image)(resources.GetObject("defender1.Image")));
            this.defender1.Location = new System.Drawing.Point(70, 27);
            this.defender1.Name = "defender1";
            this.defender1.Size = new System.Drawing.Size(84, 77);
            this.defender1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defender1.TabIndex = 0;
            this.defender1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(393, 511);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(281, 175);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-170, 345);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(281, 175);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-170, 517);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(281, 175);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(-178, 170);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(281, 175);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // player1
            // 
            this.player1.Image = ((System.Drawing.Image)(resources.GetObject("player1.Image")));
            this.player1.Location = new System.Drawing.Point(148, 558);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(62, 91);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 7;
            this.player1.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(190, 34);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(146, 34);
            this.Score.TabIndex = 8;
            this.Score.Text = "Points : 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Score);
            this.panel1.Location = new System.Drawing.Point(-16, 668);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 241);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // defender2
            // 
            this.defender2.BackColor = System.Drawing.Color.Red;
            this.defender2.Image = ((System.Drawing.Image)(resources.GetObject("defender2.Image")));
            this.defender2.Location = new System.Drawing.Point(311, 27);
            this.defender2.Name = "defender2";
            this.defender2.Size = new System.Drawing.Size(62, 65);
            this.defender2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defender2.TabIndex = 10;
            this.defender2.TabStop = false;
            // 
            // defender3
            // 
            this.defender3.BackColor = System.Drawing.Color.Red;
            this.defender3.Image = ((System.Drawing.Image)(resources.GetObject("defender3.Image")));
            this.defender3.Location = new System.Drawing.Point(95, 141);
            this.defender3.Name = "defender3";
            this.defender3.Size = new System.Drawing.Size(86, 80);
            this.defender3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defender3.TabIndex = 11;
            this.defender3.TabStop = false;
            // 
            // defender4
            // 
            this.defender4.BackColor = System.Drawing.Color.Red;
            this.defender4.Image = ((System.Drawing.Image)(resources.GetObject("defender4.Image")));
            this.defender4.Location = new System.Drawing.Point(326, 240);
            this.defender4.Name = "defender4";
            this.defender4.Size = new System.Drawing.Size(62, 65);
            this.defender4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defender4.TabIndex = 12;
            this.defender4.TabStop = false;
            // 
            // Win
            // 
            this.Win.Image = ((System.Drawing.Image)(resources.GetObject("Win.Image")));
            this.Win.Location = new System.Drawing.Point(95, 186);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(301, 138);
            this.Win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Win.TabIndex = 13;
            this.Win.TabStop = false;
            // 
            // GameOver
            // 
            this.GameOver.Image = ((System.Drawing.Image)(resources.GetObject("GameOver.Image")));
            this.GameOver.Location = new System.Drawing.Point(85, 192);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(336, 125);
            this.GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameOver.TabIndex = 14;
            this.GameOver.TabStop = false;
            this.GameOver.Click += new System.EventHandler(this.GameOver_Click);
            // 
            // ballCoin3
            // 
            this.ballCoin3.Image = ((System.Drawing.Image)(resources.GetObject("ballCoin3.Image")));
            this.ballCoin3.Location = new System.Drawing.Point(263, 186);
            this.ballCoin3.Name = "ballCoin3";
            this.ballCoin3.Size = new System.Drawing.Size(35, 35);
            this.ballCoin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballCoin3.TabIndex = 21;
            this.ballCoin3.TabStop = false;
            // 
            // ballCoin2
            // 
            this.ballCoin2.Image = ((System.Drawing.Image)(resources.GetObject("ballCoin2.Image")));
            this.ballCoin2.Location = new System.Drawing.Point(131, 282);
            this.ballCoin2.Name = "ballCoin2";
            this.ballCoin2.Size = new System.Drawing.Size(35, 35);
            this.ballCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballCoin2.TabIndex = 22;
            this.ballCoin2.TabStop = false;
            // 
            // ballCoin1
            // 
            this.ballCoin1.Image = ((System.Drawing.Image)(resources.GetObject("ballCoin1.Image")));
            this.ballCoin1.Location = new System.Drawing.Point(360, 131);
            this.ballCoin1.Name = "ballCoin1";
            this.ballCoin1.Size = new System.Drawing.Size(35, 35);
            this.ballCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballCoin1.TabIndex = 23;
            this.ballCoin1.TabStop = false;
            // 
            // ballCoin4
            // 
            this.ballCoin4.Image = ((System.Drawing.Image)(resources.GetObject("ballCoin4.Image")));
            this.ballCoin4.Location = new System.Drawing.Point(199, 56);
            this.ballCoin4.Name = "ballCoin4";
            this.ballCoin4.Size = new System.Drawing.Size(35, 35);
            this.ballCoin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballCoin4.TabIndex = 24;
            this.ballCoin4.TabStop = false;
            // 
            // RestartPanel
            // 
            this.RestartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RestartPanel.Controls.Add(this.button4);
            this.RestartPanel.Controls.Add(this.Quit_button);
            this.RestartPanel.Controls.Add(this.restartButton);
            this.RestartPanel.Location = new System.Drawing.Point(95, 311);
            this.RestartPanel.Name = "RestartPanel";
            this.RestartPanel.Size = new System.Drawing.Size(319, 257);
            this.RestartPanel.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(97, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 70);
            this.button4.TabIndex = 29;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Quit_button
            // 
            this.Quit_button.BackColor = System.Drawing.Color.Transparent;
            this.Quit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quit_button.BackgroundImage")));
            this.Quit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Quit_button.FlatAppearance.BorderSize = 0;
            this.Quit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit_button.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_button.ForeColor = System.Drawing.Color.Yellow;
            this.Quit_button.Location = new System.Drawing.Point(104, 171);
            this.Quit_button.Name = "Quit_button";
            this.Quit_button.Size = new System.Drawing.Size(128, 70);
            this.Quit_button.TabIndex = 28;
            this.Quit_button.UseVisualStyleBackColor = false;
            this.Quit_button.Click += new System.EventHandler(this.Quit_button_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartButton.BackgroundImage")));
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.ForeColor = System.Drawing.Color.Red;
            this.restartButton.Location = new System.Drawing.Point(104, 19);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(128, 70);
            this.restartButton.TabIndex = 27;
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(-181, 14);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(281, 175);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(384, 345);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(281, 175);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(380, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(370, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(281, 175);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 33;
            this.pictureBox.TabStop = false;
            // 
            // Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(507, 825);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RestartPanel);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.Win);
            this.Controls.Add(this.ballCoin4);
            this.Controls.Add(this.ballCoin1);
            this.Controls.Add(this.ballCoin2);
            this.Controls.Add(this.ballCoin3);
            this.Controls.Add(this.defender4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.defender2);
            this.Controls.Add(this.defender1);
            this.Controls.Add(this.defender3);
            this.MaximizeBox = false;
            this.Name = "Easy";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.player_Keydown);
            ((System.ComponentModel.ISupportInitialize)(this.defender1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defender2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defender3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defender4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballCoin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballCoin4)).EndInit();
            this.RestartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox defender1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox defender2;
        private System.Windows.Forms.PictureBox defender3;
        private System.Windows.Forms.PictureBox defender4;
        private System.Windows.Forms.PictureBox Win;
        private System.Windows.Forms.PictureBox GameOver;
        private System.Windows.Forms.PictureBox ballCoin3;
        private System.Windows.Forms.PictureBox ballCoin2;
        private System.Windows.Forms.PictureBox ballCoin1;
        private System.Windows.Forms.PictureBox ballCoin4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel RestartPanel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button Quit_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}