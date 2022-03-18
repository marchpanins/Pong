namespace Pong
{
    partial class Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.player1 = new System.Windows.Forms.PictureBox();
            this.playerCpu = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.playerCpuScoreLabel = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.Control;
            this.player1.Location = new System.Drawing.Point(12, 167);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(19, 137);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // playerCpu
            // 
            this.playerCpu.BackColor = System.Drawing.SystemColors.Control;
            this.playerCpu.Location = new System.Drawing.Point(859, 167);
            this.playerCpu.Name = "playerCpu";
            this.playerCpu.Size = new System.Drawing.Size(19, 137);
            this.playerCpu.TabIndex = 1;
            this.playerCpu.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Control;
            this.ball.Location = new System.Drawing.Point(429, 216);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(18, 18);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.Location = new System.Drawing.Point(213, 43);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(24, 27);
            this.player1ScoreLabel.TabIndex = 3;
            this.player1ScoreLabel.Text = "0";
            // 
            // playerCpuScoreLabel
            // 
            this.playerCpuScoreLabel.AutoSize = true;
            this.playerCpuScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.playerCpuScoreLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCpuScoreLabel.Location = new System.Drawing.Point(647, 43);
            this.playerCpuScoreLabel.Name = "playerCpuScoreLabel";
            this.playerCpuScoreLabel.Size = new System.Drawing.Size(24, 27);
            this.playerCpuScoreLabel.TabIndex = 4;
            this.playerCpuScoreLabel.Text = "0";
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Interval = 10;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // Pong
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(890, 504);
            this.Controls.Add(this.playerCpuScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.playerCpu);
            this.Controls.Add(this.player1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox playerCpu;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label playerCpuScoreLabel;
        private System.Windows.Forms.Timer pongTimer;
    }
}