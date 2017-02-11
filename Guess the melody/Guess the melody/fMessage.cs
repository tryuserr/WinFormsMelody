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
    
    public partial class fMessage : Form
    {
        int timeanswer = 10;
        public fMessage()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeanswer--;
            label_time.Text = timeanswer.ToString();
            if (timeanswer == 0)
            {
                timer.Stop();
            }

        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }
    }
}
