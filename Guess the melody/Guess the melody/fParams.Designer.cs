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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_selectfolder = new System.Windows.Forms.Button();
            this.button_clearlist = new System.Windows.Forms.Button();
            this.checkBox_usesubdirs = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(419, 147);
            this.listBox1.TabIndex = 0;
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
            // 
            // button_clearlist
            // 
            this.button_clearlist.Location = new System.Drawing.Point(95, 155);
            this.button_clearlist.Name = "button_clearlist";
            this.button_clearlist.Size = new System.Drawing.Size(75, 23);
            this.button_clearlist.TabIndex = 2;
            this.button_clearlist.Text = "Clear list";
            this.button_clearlist.UseVisualStyleBackColor = true;
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
            // fParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 315);
            this.Controls.Add(this.checkBox_usesubdirs);
            this.Controls.Add(this.button_clearlist);
            this.Controls.Add(this.button_selectfolder);
            this.Controls.Add(this.listBox1);
            this.Name = "fParams";
            this.Text = "Params";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_selectfolder;
        private System.Windows.Forms.Button button_clearlist;
        private System.Windows.Forms.CheckBox checkBox_usesubdirs;
    }
}