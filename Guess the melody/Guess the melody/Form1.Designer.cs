namespace Guess_the_melody
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.button_game = new System.Windows.Forms.Button();
            this.button_params = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_game
            // 
            this.button_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_game.Location = new System.Drawing.Point(71, 21);
            this.button_game.Name = "button_game";
            this.button_game.Size = new System.Drawing.Size(156, 47);
            this.button_game.TabIndex = 0;
            this.button_game.Text = "Game";
            this.button_game.UseVisualStyleBackColor = true;
            this.button_game.Click += new System.EventHandler(this.button_game_Click);
            // 
            // button_params
            // 
            this.button_params.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_params.Location = new System.Drawing.Point(71, 74);
            this.button_params.Name = "button_params";
            this.button_params.Size = new System.Drawing.Size(156, 47);
            this.button_params.TabIndex = 1;
            this.button_params.Text = "Settings";
            this.button_params.UseVisualStyleBackColor = true;
            this.button_params.Click += new System.EventHandler(this.button_params_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(71, 127);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(156, 47);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_the_melody.Properties.Resources._3D_Music_Words_Wallpaper__E_Entertainment;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_params);
            this.Controls.Add(this.button_game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Guess the melody";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_game;
        private System.Windows.Forms.Button button_params;
        private System.Windows.Forms.Button button_exit;
    }
}

