namespace Guess_the_melody
{
    partial class fParams
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
            this.listBox_music = new System.Windows.Forms.ListBox();
            this.button_selectfolder = new System.Windows.Forms.Button();
            this.button_clearlist = new System.Windows.Forms.Button();
            this.checkBox_usesubdirs = new System.Windows.Forms.CheckBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_musicduration = new System.Windows.Forms.ComboBox();
            this.comboBox_gameduration = new System.Windows.Forms.ComboBox();
            this.Timeforanswer_label = new System.Windows.Forms.Label();
            this.Gametime_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_music
            // 
            this.listBox_music.FormattingEnabled = true;
            this.listBox_music.Location = new System.Drawing.Point(1, 1);
            this.listBox_music.Name = "listBox_music";
            this.listBox_music.Size = new System.Drawing.Size(419, 147);
            this.listBox_music.TabIndex = 0;
            // 
            // button_selectfolder
            // 
            this.button_selectfolder.Location = new System.Drawing.Point(13, 155);
            this.button_selectfolder.Name = "button_selectfolder";
            this.button_selectfolder.Size = new System.Drawing.Size(75, 23);
            this.button_selectfolder.TabIndex = 1;
            this.button_selectfolder.Text = "Select folder";
            this.button_selectfolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_selectfolder.UseVisualStyleBackColor = true;
            this.button_selectfolder.Click += new System.EventHandler(this.button_selectfolder_Click);
            // 
            // button_clearlist
            // 
            this.button_clearlist.Location = new System.Drawing.Point(95, 155);
            this.button_clearlist.Name = "button_clearlist";
            this.button_clearlist.Size = new System.Drawing.Size(75, 23);
            this.button_clearlist.TabIndex = 2;
            this.button_clearlist.Text = "Clear list";
            this.button_clearlist.UseVisualStyleBackColor = true;
            this.button_clearlist.Click += new System.EventHandler(this.button_clearlist_Click);
            // 
            // checkBox_usesubdirs
            // 
            this.checkBox_usesubdirs.AutoSize = true;
            this.checkBox_usesubdirs.Location = new System.Drawing.Point(327, 159);
            this.checkBox_usesubdirs.Name = "checkBox_usesubdirs";
            this.checkBox_usesubdirs.Size = new System.Drawing.Size(81, 17);
            this.checkBox_usesubdirs.TabIndex = 3;
            this.checkBox_usesubdirs.Text = "Use subdirs";
            this.checkBox_usesubdirs.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(406, 280);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(325, 280);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_musicduration);
            this.groupBox1.Controls.Add(this.comboBox_gameduration);
            this.groupBox1.Controls.Add(this.Timeforanswer_label);
            this.groupBox1.Controls.Add(this.Gametime_label);
            this.groupBox1.Location = new System.Drawing.Point(13, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game settings";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(214, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(50, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "P";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 1";
            // 
            // comboBox_musicduration
            // 
            this.comboBox_musicduration.FormattingEnabled = true;
            this.comboBox_musicduration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.comboBox_musicduration.Location = new System.Drawing.Point(108, 37);
            this.comboBox_musicduration.Name = "comboBox_musicduration";
            this.comboBox_musicduration.Size = new System.Drawing.Size(49, 21);
            this.comboBox_musicduration.TabIndex = 3;
            this.comboBox_musicduration.Text = "20";
            // 
            // comboBox_gameduration
            // 
            this.comboBox_gameduration.FormattingEnabled = true;
            this.comboBox_gameduration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.comboBox_gameduration.Location = new System.Drawing.Point(108, 17);
            this.comboBox_gameduration.Name = "comboBox_gameduration";
            this.comboBox_gameduration.Size = new System.Drawing.Size(49, 21);
            this.comboBox_gameduration.TabIndex = 2;
            this.comboBox_gameduration.Text = "30";
            // 
            // Timeforanswer_label
            // 
            this.Timeforanswer_label.AutoSize = true;
            this.Timeforanswer_label.Location = new System.Drawing.Point(7, 37);
            this.Timeforanswer_label.Name = "Timeforanswer_label";
            this.Timeforanswer_label.Size = new System.Drawing.Size(82, 13);
            this.Timeforanswer_label.TabIndex = 1;
            this.Timeforanswer_label.Text = "Time for answer";
            // 
            // Gametime_label
            // 
            this.Gametime_label.AutoSize = true;
            this.Gametime_label.Location = new System.Drawing.Point(7, 20);
            this.Gametime_label.Name = "Gametime_label";
            this.Gametime_label.Size = new System.Drawing.Size(57, 13);
            this.Gametime_label.TabIndex = 0;
            this.Gametime_label.Text = "Game time";
            // 
            // fParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.checkBox_usesubdirs);
            this.Controls.Add(this.button_clearlist);
            this.Controls.Add(this.button_selectfolder);
            this.Controls.Add(this.listBox_music);
            this.Name = "fParams";
            this.Text = "Params";
            this.Load += new System.EventHandler(this.fParams_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_music;
        private System.Windows.Forms.Button button_selectfolder;
        private System.Windows.Forms.Button button_clearlist;
        private System.Windows.Forms.CheckBox checkBox_usesubdirs;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_musicduration;
        private System.Windows.Forms.ComboBox comboBox_gameduration;
        private System.Windows.Forms.Label Timeforanswer_label;
        private System.Windows.Forms.Label Gametime_label;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}