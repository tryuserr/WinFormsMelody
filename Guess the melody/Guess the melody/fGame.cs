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
        int musicduration;
        public fGame()
        {
            InitializeComponent();
            rnd = new Random();
            progressBar.Maximum = Victorina.gameDuration;
        }

        void MakeMusic()
        {
            if (Victorina.list.Count == 0)
            {
                EndGame();
            }
            else
            {
                musicduration = Victorina.musicDuration;                
                int n = rnd.Next(0, Victorina.list.Count - 1);
                WMP.URL = Victorina.list[n];
                Victorina.answer = System.IO.Path.GetFileNameWithoutExtension(WMP.URL);
                Victorina.list.RemoveAt(n);
                label_melodycounter.Text = Victorina.list.Count.ToString();
            }
        }

        void GamePause()
        {
            timer.Stop();
            WMP.Ctlcontrols.stop();
        }

        void GamePlay()
        {
            timer.Start();
            WMP.Ctlcontrols.play();
        }

        void EndGame()
        {
            WMP.Ctlcontrols.stop();
            timer.Stop();            
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
            GamePlay();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GamePause();
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
            musicduration--;

            if (progressBar.Value == progressBar.Maximum)
            {
                EndGame();
                return;
            }
            if (musicduration == 0)
            {
                MakeMusic();
            }
        }              

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                if (timer.Enabled == false)
                {
                    return;
                }

                GamePause();
                fMessage fm = new fMessage();
                fm.label_player.Text = "Player 1";
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    label_firstplayer.Text = Convert.ToString(Convert.ToInt32(label_firstplayer.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }

            if (e.KeyData == Keys.P)
            {
                if (timer.Enabled == false)
                {
                    return;
                }
                GamePause();
                fMessage fm = new fMessage();
                fm.label_player.Text = "Player 2";
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    label_secondplayer.Text = Convert.ToString(Convert.ToInt32(label_secondplayer.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }
    }
}
