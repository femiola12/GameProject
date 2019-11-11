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
    public partial class Difficultys : Form
    {
        public Difficultys()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Easy es = new Easy();
            es.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HardLevel hd = new HardLevel();
            hd.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medium me = new Medium();
            me.Show();
            Hide();
        }
    }
}
