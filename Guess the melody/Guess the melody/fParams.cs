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

        private void button_ok_Click(object sender, EventArgs e)
        {
            Victorina.WriteParams();
            this.Hide();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_selectfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.mp3",
                    checkBox_usesubdirs.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                listBox_music.Items.Clear();
                listBox_music.Items.AddRange(music_list);
                Victorina.list.Clear();
                Victorina.list.AddRange(music_list);
            }
        }

        private void button_clearlist_Click(object sender, EventArgs e)
        {

        }
    }
}
