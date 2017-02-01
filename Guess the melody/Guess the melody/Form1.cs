using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_melody
{
    public partial class fMain : Form
    {
        fParams fp;
        fGame fg;
        public fMain()
        {
            InitializeComponent();

            fp = new fParams();
            fg = new fGame();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_params_Click(object sender, EventArgs e)
        {           
            fp.ShowDialog();
        }

        private void button_game_Click(object sender, EventArgs e)
        {
            fg.ShowDialog();
        }
    }
}
