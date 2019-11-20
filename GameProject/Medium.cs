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
    public partial class Medium : Form
    {
        public Medium()
        {
            InitializeComponent();
            winSliver.Visible = false;
            GameOver.Visible = false;
            RestartPanel.Visible = false;

        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            football_Fans(6);
            defend_Player(3);
            ball(3);
            player_points();
           // game_over();

        }


        private void game_over()
        {
            if (player2.Bounds.IntersectsWith(defender2.Bounds))
            {
                gameTimer.Enabled = false;
                RestartPanel.Visible = true;
                GameOver.Visible = true;
            }
            if (player2.Bounds.IntersectsWith(defender3.Bounds))
            {
                gameTimer.Enabled = false;
                RestartPanel.Visible = true;
                GameOver.Visible = true;
            }
            if (player2.Bounds.IntersectsWith(defender5.Bounds))
            {
                gameTimer.Enabled = false;
                RestartPanel.Visible = true;
                GameOver.Visible = true;
            }

            if (player2.Bounds.IntersectsWith(con2.Bounds))
            {
                gameTimer.Enabled = false;
                RestartPanel.Visible = true;
                GameOver.Visible = true;
            }
        }

        int ballPoints = 0;
        private void player_points()
        {
            if (player2.Bounds.IntersectsWith(ballcoins1.Bounds))
            {
                ballPoints++;
                Points.Text = "Points =" + ballPoints.ToString();
                x = rd.Next(40, 300);
                ballcoins1.Location = new Point(x, 0);
            }

            if (player2.Bounds.IntersectsWith(ballcoins2.Bounds))
            {
                ballPoints++;
                Points.Text = "Points =" + ballPoints.ToString();
                x = rd.Next(40, 300);
                ballcoins2.Location = new Point(x, 0);
            }

            if (player2.Bounds.IntersectsWith(ballcoins3.Bounds))
            {
                ballPoints++;
                Points.Text = "Points =" + ballPoints.ToString();
                x = rd.Next(50, 400);
                ballcoins3.Location = new Point(x, 0);
            }

            if (player2.Bounds.IntersectsWith(ballcoins4.Bounds))
            {
                ballPoints++;
                Points.Text = "Points =" + ballPoints.ToString();
                x = rd.Next(50, 400);
                ballcoins3.Location = new Point(x, 0);
            }
            else
            {
                if (ballPoints == 15)
                {
                    winSliver.Visible = true;
                    gameTimer.Enabled = false;
                }
            }
        }

        private void ball(int ballSpeed)
        {
            if (ballcoins1.Top >= 500)
            {
                x = rd.Next(60, 100);
                ballcoins1.Top = 0;
            }
            else
            {
                ballcoins1.Top += ballSpeed;
            }

            if (ballcoins2.Top >= 500)
            {
                x = rd.Next(20, 200);
                ballcoins2.Top = 0;
            }
            else
            {
                ballcoins2.Top += ballSpeed;
            }

            if (ballcoins3.Top >= 500)
            {
                x = rd.Next(20, 200);
                ballcoins3.Top = 0;
            }
            else
            {
                ballcoins3.Top += ballSpeed;
            }

            if (ballcoins4.Top >= 500)
            {
                x = rd.Next(20, 350);
                ballcoins4.Top = 0;
            }
            else
            {
                ballcoins4.Top += ballSpeed;
            }
        }



        Random rd = new Random();
        int x;
        private void defend_Player(int defenderSpeed)
        {

            if (defender2.Top >= 500)
            {
                x = rd.Next(60, 122);
                defender2.Top = 0;

                defender2.Location = new Point(x, 0);
            }
            else
            {
                defender2.Top += defenderSpeed;
            }
            if (defender3.Top >= 500)
            {
                x = rd.Next(60, 100);
                defender3.Top = 0;

                defender3.Location = new Point(x, 0);
            }
            else
            {
                defender3.Top += defenderSpeed;
            }
            //if (defender4.Top >= 500)
            //{
            //    x = rd.Next(0, 350);
            //    defender4.Top = 0;

            //    defender4.Location = new Point(x, 0);
            //}
            //else
            //{
            //    defender4.Top += defenderSpeed;
            //}
            if (defender5.Top >= 500)
            {
                x = rd.Next(0, 200);
                defender5.Top = 0;

                defender5.Location = new Point(x, 0);
            }
            else
            {
                defender5.Top += defenderSpeed;
            }

            if (con2.Top >= 500)
            {
                x = rd.Next(0, 200);
                con2.Top = 0;

                con2.Location = new Point(x, 0);
            }
            else
            {
                con2.Top += defenderSpeed;
            }
        }
        private void football_Fans(int footballFanSpeed)
        {
            if(fan1.Top >= 100)
            {
                fan1.Top = 0;
            }
            else
            {
                fan1.Top += footballFanSpeed;
            }

            if (fan2.Top >= 500)
            {
                fan2.Top = 0;
            }
            else
            {
                fan2.Top += footballFanSpeed;
            }

            if (fan3.Top >= 500)
            {
                fan3.Top = 0;
            }
            else
            {
                fan3.Top += footballFanSpeed;
            }

            if (fan4.Top >= 500)
            {
                fan4.Top = 0;
            }
            else
            {
                fan4.Top += footballFanSpeed;
            }
            if (fan5.Top >= 500)
            {
                fan5.Top = 0;
            }
            else
            {
                fan5.Top += footballFanSpeed;
            }
            if (fan6.Top >= 500)
            {
                fan6.Top = 0;
            }
            else
            {
                fan6.Top += footballFanSpeed;
            }
            if (fan7.Top >= 500)
            {
                fan7.Top = 0;
            }
            else
            {
                fan7.Top += footballFanSpeed;
            }
            if (fan8.Top >= 500)
            {
                fan8.Top = 0;
            }
            else
            {
                fan8.Top += footballFanSpeed;
            }

        }

        private void playerKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (player2.Left > 60)
                    player2.Left += -20;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (player2.Right < 314)
                    player2.Left += 20;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Medium med = new Medium();
            med.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Difficultys dif = new Difficultys();
            dif.Show();
            Hide();
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
