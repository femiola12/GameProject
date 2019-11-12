﻿using System;
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
    public partial class HardLevel : Form
    {
        public HardLevel()
        {
            InitializeComponent();
            GoldWin.Visible = false;
            GameOver.Visible = false;
            RestartPanel.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            goalPost_Move(gameSpeed);
            defender(gameSpeed);
            game_over();
            scores(gameSpeed);
            collect_coins();
        }


        private void scores(int speed)
        {
                if (coin1.Top >= 500)
                {
                    x = rn.Next(0, 122);
                    

                    coin1.Location = new Point(x, 0);
                }
                else
                {
                    coin1.Top += speed;
                }

            if (coin2.Top >= 500)
            {
                x = rn.Next(0, 122);


                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = rn.Next(0, 122);


                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = rn.Next(0, 122);


                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
            if (pictureBox10.Top >= 500)
            {
                x = rn.Next(0, 122);


                pictureBox10.Location = new Point(x, 0);
            }
            else
            {
                pictureBox10.Top += speed;
            }
        }



        int collectionCoins = 0;

        private void collect_coins()
        {
            if (player.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectionCoins++;
                Score.Text = "Score=" + collectionCoins.ToString();
                coin1.Location = new Point(x, 0);
            }
            if (player.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectionCoins++;
                Score.Text = "Score=" + collectionCoins.ToString();
                coin2.Location = new Point(x, 0);
            }
            if (player.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectionCoins++;
                Score.Text = "Score=" + collectionCoins.ToString();
                coin3.Location = new Point(x, 0);
            }
            if (player.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectionCoins++;
                Score.Text = "Score=" + collectionCoins.ToString();
                coin4.Location = new Point(x, 0);
            }
            if (player.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                collectionCoins++;
                Score.Text = "Score=" + collectionCoins.ToString();
                pictureBox10.Location = new Point(x, 0);
            }

            else
            {
                if (collectionCoins == 10)
                {
                    GoldWin.Visible = true;
                    timer.Enabled = false;
                    RestartPanel.Visible = true;
                }
            }
        }

        Random rn = new Random();
        int x;

        private void defender(int speed)
        {

            if (player_defender1.Top >= 500)
            {
                x = rn.Next(0, 122);
                player_defender1.Top = 0;
                
                player_defender1.Location = new Point(x, 0);
            }
            if(coin1.Top > 500)
            {
                x = rn.Next(0, 122);
                coin1.Top = 0;

                coin1.Location = new Point(x, 0);
            }
            else
            {
                player_defender1.Top += speed;
            }


            if (player_defender2.Top >= 500)
            {
                player_defender2.Top = 0;
                x = rn.Next(0,100);
               player_defender2.Location = new Point(x, 0);
            }
            else
            {
                player_defender2.Top += speed;
            }


            if (player_defender3.Top >= 500)
            {
                player_defender3.Top = 0;
                x = rn.Next(100, 300);
                player_defender3.Location = new Point(x, 0);
            }
            else
            {
                player_defender3.Top += speed;
            }

        }

        private void game_over()
        {
            if (player.Bounds.IntersectsWith(player_defender1.Bounds))
            {
                timer.Enabled = false;
                GameOver.Visible = true;
                RestartPanel.Visible = true;
            }
            if (player.Bounds.IntersectsWith(player_defender2.Bounds))
            {
                timer.Enabled = false;
                GameOver.Visible = true;
                RestartPanel.Visible = true;
            }
            if (player.Bounds.IntersectsWith(player_defender3.Bounds))
            {
                timer.Enabled = false;
                GameOver.Visible = true;
                RestartPanel.Visible = true;
            }
            //if (player.Bounds.IntersectsWith(con1.Bounds))
            //{
            //    timer.Enabled = false;
            //    GameOver.Visible = true;
            //}
            if (player.Bounds.IntersectsWith(con2.Bounds))
            {
                timer.Enabled = false;
                GameOver.Visible = true;
                RestartPanel.Visible = true;
            }
            if (player.Bounds.IntersectsWith(con3.Bounds))
            {
                timer.Enabled = false;
                GameOver.Visible = true;
                RestartPanel.Visible = true;
            }
            if (player.Bounds.IntersectsWith(con4.Bounds))
            {
                timer.Enabled = false;
                GameOver.Visible = true;
                RestartPanel.Visible = true;
            }
            if (player.Bounds.IntersectsWith(con5.Bounds))
            {
                timer.Enabled = false;
                GameOver.Visible = true;
                RestartPanel.Visible = true;
            }
        }

        //Here I am creating a method of the pitch speed
        private void goalPost_Move(int pitchSpeed) 
        {

            if (con3.Top >= 500)
            {
                con3.Top = 0;
            }
            else
            {
                con3.Top += pitchSpeed;
            }

            if (con2.Top >= 500)
            {
                con2.Top = 0;
            }
            else
            {
                con2.Top += pitchSpeed;
            }

            if (con5.Top >= 500)
            {
                con5.Top = 0;
            }
            else
            {
                con5.Top += pitchSpeed;
            }

            if (pictureBox6.Top >= 500)
            {
                pictureBox6.Top = 0;
            }
            else
            {
                pictureBox6.Top += pitchSpeed;
            }

            //if (con1.Top >= 500)
            //{
            //    con1.Top = 0;
            //}
            //else
            //{
            //    con1.Top += pitchSpeed;
            //}

            if (con4.Top >= 500)
            {
                con4.Top = 0;
            }
            else
            {
                con4.Top += pitchSpeed;
            }


        }

        int gameSpeed = 0;
        private void Player_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(player.Left>0)
                player.Left += -8;


            }
            if (e.KeyCode == Keys.Right) 
            
            {
                if(player.Right<300)
                player.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 21)
                {
                    gameSpeed++;
                }
                
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }


        }



        private void restartButton_Click_1(object sender, EventArgs e)
        {
            HardLevel hd = new HardLevel();
            hd.Show();
            Hide();
        }
    }
}
