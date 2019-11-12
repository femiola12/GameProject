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
    public partial class GameStartMenu : Form
    {
        public GameStartMenu()
        {
            InitializeComponent();

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

