using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Guess_the_melody
{
    public partial class fParams : Form
    {
        public fParams()
        {
            InitializeComponent();
        }

        void SetParams()
        {
            checkBox_usesubdirs.Checked = Victorina.allDirectories;
            
            comboBox_gameduration.Text = Victorina.gameDuration.ToString();
            comboBox_musicduration.Text = Victorina.musicDuration.ToString();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = checkBox_usesubdirs.Checked;
            Victorina.gameDuration = Convert.ToInt32(comboBox_gameduration.Text);
            Victorina.musicDuration = Convert.ToInt32(comboBox_musicduration.Text);
            
            Victorina.WriteParams();

            this.Hide();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            SetParams();

            this.Hide();
        }

        private void button_selectfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.mp3",
                    checkBox_usesubdirs.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                Victorina.lastFolder = fbd.SelectedPath;

                listBox_music.Items.Clear();
                listBox_music.Items.AddRange(music_list);
                Victorina.list.Clear();
                Victorina.list.AddRange(music_list);
            }
        }

        private void button_clearlist_Click(object sender, EventArgs e)
        {

        }

        private void fParams_Load(object sender, EventArgs e)
        {
            SetParams();
            listBox_music.Items.Clear();
            listBox_music.Items.AddRange(Victorina.list.ToArray());
        }
    }
}
