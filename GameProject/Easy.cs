using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Windows.Media;


namespace GameProject
{
    public partial class Easy : Form
    {
        private SoundPlayer Player = new SoundPlayer();
        public Easy()
        {
            InitializeComponent();
            Win.Visible = false;
            GameOver.Visible = false;
            RestartPanel.Visible = false;
            SaveGame.Visible = false;



      }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fans(9);
            defender(5);
            game_over();
            points();
            ball(3);
        }



        
        private void game_over()
        {
            if (player1.Bounds.IntersectsWith(defender1.Bounds))
            {
                timer1.Enabled = false;
                RestartPanel.Visible = true;
                GameOver.Visible = true;
                System.Media.SoundPlayer sound3 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Crowd Voices Angry.wav");
                sound3.Play();

            }
            if (player1.Bounds.IntersectsWith(defender2.Bounds))
            {
                timer1.Enabled = false;
                RestartPanel.Visible = true;
                GameOver.Visible = true;

                System.Media.SoundPlayer sound3 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Crowd Voices Angry.wav");
                sound3.Play();
            }
            if (player1.Bounds.IntersectsWith(defender3.Bounds))
            {
                timer1.Enabled = false;
                RestartPanel.Visible = true;
                GameOver.Visible = true;

                System.Media.SoundPlayer sound3 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Crowd Voices Angry.wav");
                sound3.Play();
            }
            if (player1.Bounds.IntersectsWith(defender4.Bounds))
            {
                timer1.Enabled = false;
                RestartPanel.Visible = true;
                GameOver.Visible = true;
                System.Media.SoundPlayer sound3 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Crowd Voices Angry.wav");
                sound3.Play();
            }
            if(GameOver.Visible == true)
            {
                SaveGame.Visible = true;
               
                scoreTextBox.Text = pointCoins.ToString();
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
                //System.Media.SoundPlayer sound3 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Coin Pickup Sound.wav");
                //sound3.Play();
            }

            if (player1.Bounds.IntersectsWith(ballCoin2.Bounds))
            {
                pointCoins++;
                Score.Text = "Score=" + pointCoins.ToString();
                x = rn.Next(50, 300);
                ballCoin2.Location = new Point(x, 0);
                //System.Media.SoundPlayer sound3 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Coin Pickup Sound.wav");
                //sound3.Play();

            }

            if (player1.Bounds.IntersectsWith(ballCoin3.Bounds))
            {
                pointCoins++;
                Score.Text = "Score=" + pointCoins.ToString();
                x = rn.Next(50, 300);
                ballCoin3.Location = new Point(x, 0);
                //System.Media.SoundPlayer sound3 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Coin Pickup Sound.wav");
                //sound3.Play();

            }
            if (player1.Bounds.IntersectsWith(ballCoin4.Bounds))
            {
                pointCoins++;
                Score.Text = "Score=" + pointCoins.ToString();
                x = rn.Next(50, 300);
                ballCoin4.Location = new Point(x, 0);
                //System.Media.SoundPlayer sound3 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Coin Pickup Sound.wav");
                //sound3.Play();

            }
            else
            {
                if(pointCoins == 5)
                {
                    Win.Visible = true;
                    RestartPanel.Visible = true;
                    timer1.Enabled = false;
                    System.Media.SoundPlayer sound4 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\UEFA Champions League .wav");
                    sound4.Play();


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
            if (pictureBox.Top >= 500)
            {
                pictureBox.Top = 0;
            }
            else
            {
                pictureBox.Top += fanSpeed;
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

            if (pictureBox8.Top >= 500)
            {
                pictureBox8.Top = 0;
            }
            else
            {
                pictureBox8.Top += fanSpeed;
            }
            if (pictureBox9.Top >= 500)
            {
                pictureBox9.Top = 0;
            }
            else
            {
                pictureBox9.Top += fanSpeed;
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

        private void restartButton_Click(object sender, EventArgs e)
        {
            Easy ea = new Easy();
            ea.Show();
            Hide();
            System.Media.SoundPlayer sound4 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\UEFA Champions League .wav");
            sound4.Stop();
            System.Media.SoundPlayer sound5 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Sports Stadium Crowd Cheering.wav");
            sound5.PlayLooping();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Difficultys dif = new Difficultys();
            dif.Show();
            Hide();
            System.Media.SoundPlayer sound4 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\UEFA Champions League .wav");
            sound4.Stop();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Same Old Story.wav");
            player.Play();
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private  void Save_Button_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Scores\\" + NametextBox.Text + " " + scoreTextBox.Text + ".txt");
            //sw.WriteLine(label1.Text + " " + NametextBox.Text);
            //sw.WriteLine(Scorelabel.Text + " " + scoreTextBox.Text);
            //sw.Close();

            
            TextWriter txt = new StreamWriter(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\GameProject\GameProject\bin\Debug\Scores\Scores.txt");
            txt.WriteLine($"\n");
            txt.WriteLine(label1.Text + " " + NametextBox.Text);
            txt.WriteLine(Scorelabel.Text + " " + scoreTextBox.Text);
            //txt.WriteLine(richTextBox1.Text);
            txt.Close();






            StreamReader sw1 = new StreamReader(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\GameProject\GameProject\bin\Debug\Scores\Scores.txt");

            richTextBox1.Text = sw1.ReadToEnd();
            sw1.Dispose();
            sw1.Close();

        }

        private void Easy_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound5 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Sports Stadium Crowd Cheering.wav");
            sound5.PlayLooping();
        }
    }
}
