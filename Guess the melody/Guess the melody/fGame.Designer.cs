namespace Guess_the_melody
{
    partial class fGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.button_nextmelody = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_firstplayer = new System.Windows.Forms.Label();
            this.label_secondplayer = new System.Windows.Forms.Label();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_continue = new System.Windows.Forms.Button();
            this.label_melodycounter = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(206, 101);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(22, 19);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            // 
            // button_nextmelody
            // 
            this.button_nextmelody.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_nextmelody.Location = new System.Drawing.Point(83, 101);
            this.button_nextmelody.Name = "button_nextmelody";
            this.button_nextmelody.Size = new System.Drawing.Size(100, 38);
            this.button_nextmelody.TabIndex = 1;
            this.button_nextmelody.Text = "Next";
            this.button_nextmelody.UseVisualStyleBackColor = true;
            this.button_nextmelody.Click += new System.EventHandler(this.button_nextmelody_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(172, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2";
            // 
            // label_firstplayer
            // 
            this.label_firstplayer.AutoSize = true;
            this.label_firstplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_firstplayer.Location = new System.Drawing.Point(41, 54);
            this.label_firstplayer.Name = "label_firstplayer";
            this.label_firstplayer.Size = new System.Drawing.Size(26, 29);
            this.label_firstplayer.TabIndex = 4;
            this.label_firstplayer.Text = "0";
            // 
            // label_secondplayer
            // 
            this.label_secondplayer.AutoSize = true;
            this.label_secondplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_secondplayer.Location = new System.Drawing.Point(202, 54);
            this.label_secondplayer.Name = "label_secondplayer";
            this.label_secondplayer.Size = new System.Drawing.Size(26, 29);
            this.label_secondplayer.TabIndex = 5;
            this.label_secondplayer.Text = "0";
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(13, 195);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(94, 54);
            this.button_pause.TabIndex = 6;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_continue
            // 
            this.button_continue.Location = new System.Drawing.Point(177, 195);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(95, 54);
            this.button_continue.TabIndex = 7;
            this.button_continue.Text = "Continue";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
            // 
            // label_melodycounter
            // 
            this.label_melodycounter.AutoSize = true;
            this.label_melodycounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_melodycounter.Location = new System.Drawing.Point(123, 54);
            this.label_melodycounter.Name = "label_melodycounter";
            this.label_melodycounter.Size = new System.Drawing.Size(26, 29);
            this.label_melodycounter.TabIndex = 8;
            this.label_melodycounter.Text = "0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 158);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(259, 31);
            this.progressBar.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_the_melody.Properties.Resources._3D_Music_Words_Wallpaper__E_Entertainment;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label_melodycounter);
            this.Controls.Add(this.button_continue);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.label_secondplayer);
            this.Controls.Add(this.label_firstplayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_nextmelody);
            this.Controls.Add(this.WMP);
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "fGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button button_nextmelody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_firstplayer;
        private System.Windows.Forms.Label label_secondplayer;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_continue;
        private System.Windows.Forms.Label label_melodycounter;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}