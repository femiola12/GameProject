using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class Easy : Form
    {
        public Easy()
        {
            InitializeComponent();
            Win.Visible = false;
            GameOver.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fans(5);
            defender(1);
            game_over();
            points();

        }

        private void game_over()
        {
            if (player1.Bounds.IntersectsWith(defender1.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }
            //if (player.Bounds.IntersectsWith(player_defender2.Bounds))
            //{
            //    timer.Enabled = false;
            //    gameOver.Visible = true;
            //}
            //if (player.Bounds.IntersectsWith(player_defender3.Bounds))
            //{
            //    timer.Enabled = false;
            //    gameOver.Visible = true;
            //}
        }

        int pointCoins = 1;
        private void points()
        {
            if (player1.Bounds.IntersectsWith(ballCoin1.Bounds))
            {
                pointCoins++;
                Score.Text = "Score=" + pointCoins.ToString();
                ballCoin1.Location = new Point(x, 0);
                Win.Visible = true;
                timer1.Enabled = false;
            }
        }
        Random rn = new Random();
        int x;
        private void defender(int defenderSpeed)
        {

            if (defender1.Top >= 500)
            {
                x = rn.Next(0, 200);
                defender1.Top = 0;

                defender1.Location = new Point(x, 0);
            }
            else
            {
                defender1.Top += defenderSpeed;
            }
            //if (defender2.Top >= 500)
            //{
            //     x = rn.Next(0, 400);
            //    defender2.Top = 0;

            //     defender1.Location = new Point(x, 0);
            //}
            //else
            //{
            //    defender2.Top += defenderSpeed;
            //}
            //if (defender3.Top >= 500)
            //{
            //     x = rn.Next(200, 350);
            //    defender3.Top = 0;

            //     defender1.Location = new Point(x, 0);
            //}
            //else
            //{
            //    defender3.Top += defenderSpeed;
            //}
            //if (defender4.Top >= 500)
            //{
            //     x = rn.Next(0, 122);
            //    defender4.Top = 0;

            //     defender1.Location = new Point(x, 0);
            //}
            //else
            //{
            //    defender4.Top += defenderSpeed;
            //}
        }

        private void fans(int fanSpeed)
        {
            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += fanSpeed;
            }

            if (pictureBox6.Top >= 500)
            {
                pictureBox6.Top = 0;
            }
            else
            {
                pictureBox6.Top += fanSpeed;
            }

            if (pictureBox7.Top >= 500)
            {
                pictureBox7.Top = 0;
            }
            else
            {
                pictureBox7.Top += fanSpeed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += fanSpeed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += fanSpeed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += fanSpeed;
            }
            if(ballCoin1.Top >= 500)
            {
                ballCoin1.Top = 0;
            }
            else
            {
                ballCoin1.Top += fanSpeed;
            }
        }

        private void player_Keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(player1.Left > 60)
                player1.Left += -10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if(player1.Right < 310)
                player1.Left += 10;
            }
        }
    }
}
