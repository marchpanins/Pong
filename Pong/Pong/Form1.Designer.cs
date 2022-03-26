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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongMenu));
            this.startgame = new System.Windows.Forms.Button();
            this.mainlogo1 = new System.Windows.Forms.PictureBox();
            this.mainlogo2 = new System.Windows.Forms.PictureBox();
            this.mainlogo3 = new System.Windows.Forms.PictureBox();
            this.mainmenulogo1 = new System.Windows.Forms.PictureBox();
            this.mainmenulogo2 = new System.Windows.Forms.PictureBox();
            this.mainmenulogo3 = new System.Windows.Forms.PictureBox();
            this.mainmenulogotimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainmenulogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainmenulogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainmenulogo3)).BeginInit();
            this.SuspendLayout();
            // 
            // startgame
            // 
            this.startgame.BackColor = System.Drawing.SystemColors.InfoText;
            this.startgame.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startgame.ForeColor = System.Drawing.SystemColors.Control;
            this.startgame.Location = new System.Drawing.Point(230, 300);
            this.startgame.Name = "startgame";
            this.startgame.Size = new System.Drawing.Size(239, 64);
            this.startgame.TabIndex = 0;
            this.startgame.Text = "Play";
            this.startgame.UseVisualStyleBackColor = false;
            this.startgame.Click += new System.EventHandler(this.startgame_Click);
            // 
            // mainlogo1
            // 
            this.mainlogo1.Image = global::Pong.Properties.Resources.pong_logo1;
            this.mainlogo1.Location = new System.Drawing.Point(150, 60);
            this.mainlogo1.Name = "mainlogo1";
            this.mainlogo1.Size = new System.Drawing.Size(400, 200);
            this.mainlogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainlogo1.TabIndex = 4;
            this.mainlogo1.TabStop = false;
            this.mainlogo1.Visible = false;
            // 
            // mainlogo2
            // 
            this.mainlogo2.Image = global::Pong.Properties.Resources.pong_logo2;
            this.mainlogo2.Location = new System.Drawing.Point(150, 60);
            this.mainlogo2.Name = "mainlogo2";
            this.mainlogo2.Size = new System.Drawing.Size(400, 200);
            this.mainlogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainlogo2.TabIndex = 3;
            this.mainlogo2.TabStop = false;
            this.mainlogo2.Visible = false;
            // 
            // mainlogo3
            // 
            this.mainlogo3.Image = global::Pong.Properties.Resources.pong_logo3;
            this.mainlogo3.Location = new System.Drawing.Point(150, 60);
            this.mainlogo3.Name = "mainlogo3";
            this.mainlogo3.Size = new System.Drawing.Size(400, 200);
            this.mainlogo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainlogo3.TabIndex = 2;
            this.mainlogo3.TabStop = false;
            this.mainlogo3.Visible = false;
            // 
            // mainmenulogo1
            // 
            this.mainmenulogo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainmenulogo1.Image = global::Pong.Properties.Resources.pong_logo1;
            this.mainmenulogo1.Location = new System.Drawing.Point(300, 66);
            this.mainmenulogo1.Name = "mainmenulogo1";
            this.mainmenulogo1.Size = new System.Drawing.Size(0, 0);
            this.mainmenulogo1.TabIndex = 1;
            this.mainmenulogo1.TabStop = false;
            // 
            // mainmenulogo2
            // 
            this.mainmenulogo2.Location = new System.Drawing.Point(300, 150);
            this.mainmenulogo2.Name = "mainmenulogo2";
            this.mainmenulogo2.Size = new System.Drawing.Size(0, 0);
            this.mainmenulogo2.TabIndex = 1;
            this.mainmenulogo2.TabStop = false;
            // 
            // mainmenulogo3
            // 
            this.mainmenulogo3.Location = new System.Drawing.Point(300, 150);
            this.mainmenulogo3.Name = "mainmenulogo3";
            this.mainmenulogo3.Size = new System.Drawing.Size(0, 0);
            this.mainmenulogo3.TabIndex = 1;
            this.mainmenulogo3.TabStop = false;
            // 
            // mainmenulogotimer
            // 
            this.mainmenulogotimer.Interval = 200;
            this.mainmenulogotimer.Tick += new System.EventHandler(this.mainmenulogotimer_Tick);
            // 
            // PongMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(710, 405);
            this.Controls.Add(this.mainlogo1);
            this.Controls.Add(this.mainlogo2);
            this.Controls.Add(this.mainlogo3);
            this.Controls.Add(this.mainmenulogo1);
            this.Controls.Add(this.mainmenulogo2);
            this.Controls.Add(this.mainmenulogo3);
            this.Controls.Add(this.startgame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PongMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainmenulogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainmenulogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainmenulogo3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startgame;
        private System.Windows.Forms.PictureBox mainmenulogo3;
        private System.Windows.Forms.PictureBox mainmenulogo2;
        private System.Windows.Forms.PictureBox mainmenulogo1;
        private System.Windows.Forms.PictureBox mainlogo3;
        private System.Windows.Forms.PictureBox mainlogo2;
        private System.Windows.Forms.PictureBox mainlogo1;
        private System.Windows.Forms.Timer mainmenulogotimer;
    }
}

