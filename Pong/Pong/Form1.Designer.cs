namespace Pong
{
    partial class PongMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongMenu));
            this.startgame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startgame
            // 
            this.startgame.Location = new System.Drawing.Point(238, 259);
            this.startgame.Name = "startgame";
            this.startgame.Size = new System.Drawing.Size(239, 23);
            this.startgame.TabIndex = 0;
            this.startgame.Text = "Play";
            this.startgame.UseVisualStyleBackColor = true;
            this.startgame.Click += new System.EventHandler(this.startgame_Click);
            // 
            // PongMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(710, 405);
            this.Controls.Add(this.startgame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PongMenu";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startgame;
    }
}

