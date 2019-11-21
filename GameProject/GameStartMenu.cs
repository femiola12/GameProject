using System;
using System.Windows.Forms;

namespace GameProject
{
    public partial class GameStartMenu : Form
    {
        public GameStartMenu()
        {
            InitializeComponent();

            System.Media.SoundPlayer menuSound = new System.Media.SoundPlayer(@"C:\Users\FOladiji\Engineering45\WEEK3\Day5\Same Old Story.wav");
            menuSound.PlayLooping();
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {

             Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Difficultys Check = new Difficultys();
            Check.Show();
            Hide();


        }
    }
}

