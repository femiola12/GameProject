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
            fans(3);
            defender(1);
            game_over();
            points();
            ball(3);

        }

        private void game_over()
        {
            if (player1.Bounds.IntersectsWith(defender1.Bounds))
            {
                timer1.Enabled = false;
                
                GameOver.Visible = true;
            }
            if (player1.Bounds.IntersectsWith(defender2.Bounds))
            {
                timer1.Enabled = false;
                
                GameOver.Visible = true;
            }
            if (player1.Bounds.IntersectsWith(defender3.Bounds))
            {
                timer1.Enabled = false;
                
                GameOver.Visible = true;
            }
            if (player1.Bounds.IntersectsWith(defender4.Bounds))
            {
                timer1.Enabled = false;
               
                GameOver.Visible = true;
            }
        }

        int pointCoins = 0;

        private void points()
        {
            if (player1.Bounds.IntersectsWith(ballCoin1.Bounds))
            {
                pointCoins++;
                Score.Text = "Score=" + pointCoins.ToString();
                x = rn.Next(50, 300);
                ballCoin1.Location = new Point(x, 0);   
            }

            if (player1.Bounds.IntersectsWith(ballCoin2.Bounds))
            {
                pointCoins++;
                Score.Text = "Score=" + pointCoins.ToString();
                x = rn.Next(50, 300);
                ballCoin2.Location = new Point(x, 0);
            }

            if (player1.Bounds.IntersectsWith(ballCoin3.Bounds))
            {
                pointCoins++;
                Score.Text = "Score=" + pointCoins.ToString();
                x = rn.Next(50, 300);
                ballCoin3.Location = new Point(x, 0);
            }
            if (player1.Bounds.IntersectsWith(ballCoin4.Bounds))
            {
                pointCoins++;
                Score.Text = "Score=" + pointCoins.ToString();
                x = rn.Next(50, 300);
                ballCoin4.Location = new Point(x, 0);
            }
            else
            {
                if(pointCoins == 25)
                {
                    Win.Visible = true;
                    timer1.Enabled = false;
                }
            }


        }





        Random rn = new Random();
        int x;
        private void defender(int defenderSpeed)
        {

            if (defender1.Top >= 500)
            {
                x = rn.Next(0, 122);
                defender1.Top = 0;

                defender1.Location = new Point(x, 0);
            }
            else
            {
                defender1.Top += defenderSpeed;
            }
            if (defender2.Top >= 500)
            {
                x = rn.Next(0, 400);
                defender2.Top = 0;

                defender1.Location = new Point(x, 0);
            }
            else
            {
                defender2.Top += defenderSpeed;
            }
            if (defender3.Top >= 500)
            {
                x = rn.Next(0, 350);
                defender3.Top = 0;

                defender1.Location = new Point(x, 0);
            }
            else
            {
                defender3.Top += defenderSpeed;
            }
            if (defender4.Top >= 500)
            {
                x = rn.Next(0, 122);
                defender4.Top = 0;

                defender1.Location = new Point(x, 0);
            }
            else
            {
                defender4.Top += defenderSpeed;
            }
        }


        private void ball(int ballSpeed)
        {
            if (ballCoin1.Top >= 500)
            {
                x = rn.Next(60, 122);
                ballCoin1.Top = 0;
            }
            else
            {
                ballCoin1.Top += ballSpeed;
            }

            if (ballCoin2.Top >= 500)
            {
                x = rn.Next(60, 100);
                ballCoin2.Top = 0;
            }
            else
            {
                ballCoin2.Top += ballSpeed;
            }

            if (ballCoin3.Top >= 500)
            {
                x = rn.Next(0, 350);
                ballCoin3.Top = 0;
            }
            else
            {
                ballCoin3.Top += ballSpeed;
            }
            if (ballCoin4.Top >= 500)
            {
                x = rn.Next(0, 122);
                ballCoin4.Top = 0;
            }
            else
            {
                ballCoin4.Top += ballSpeed;
            }
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
        }

        private void player_Keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(player1.Left > 60)
                player1.Left += -20;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if(player1.Right < 310)
                player1.Left += 20;
            }

        }
    }
}
