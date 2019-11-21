using System;
using System.Windows.Forms;
using System.Media;

namespace GameProject
{
    public partial class Difficultys : Form
    {
        public Difficultys()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Same Old Story.wav");
            player1.Stop();

            Easy es = new Easy();
            es.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Same Old Story.wav");
            player1.Stop();
            HardLevel hd = new HardLevel();
            hd.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Same Old Story.wav");
            player1.Stop();
            Medium me = new Medium();
            me.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GameStartMenu gsm = new GameStartMenu();
            gsm.Show();
            Hide();
            System.Media.SoundPlayer menuSound = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Same Old Story.wav");
            menuSound.PlayLooping();
        }
    }
}
