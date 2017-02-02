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
    public partial class fGame : Form
    {
        Random rnd;
        public fGame()
        {
            InitializeComponent();
            rnd = new Random();
        }

        void MakeMusic()
        {
            int n = rnd.Next(0, Victorina.list.Count - 1);
            WMP.URL = Victorina.list[n];
            Victorina.list.RemoveAt(n);

            label_melodycounter.Text = Victorina.list.Count.ToString();
        }

        private void button_nextmelody_Click(object sender, EventArgs e)
        {
            MakeMusic();
            timer.Start();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            timer.Start();
            WMP.Ctlcontrols.play();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            label_melodycounter.Text = Victorina.list.Count.ToString();
            progressBar.Value = 0;
            progressBar.Maximum = Victorina.gameDuration;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;
            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Stop();
                WMP.Ctlcontrols.stop();
            }
        }
    }
}
