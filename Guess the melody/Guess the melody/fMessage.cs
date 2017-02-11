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
        public int timeanswer;
        public fMessage()
        {          
            InitializeComponent();
            timeanswer = Victorina.timeforanswer;
            timer.Start();
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

        private void label_showanswer_Click(object sender, EventArgs e)
        {
            label_showanswer.Text = Victorina.answer;
        }
    }
}
