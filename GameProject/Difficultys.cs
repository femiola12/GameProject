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
            Easy Check = new Easy();
            Check.Show();
            Hide();
        }
    }
}
