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
            this.pausedtext = new System.Windows.Forms.Label();
            this.playerwintext = new System.Windows.Forms.Label();
            this.cpuwintext = new System.Windows.Forms.Label();
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
            this.player1ScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.player1ScoreLabel.Location = new System.Drawing.Point(288, 50);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(39, 45);
            this.player1ScoreLabel.TabIndex = 3;
            this.player1ScoreLabel.Text = "0";
            this.player1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCpuScoreLabel
            // 
            this.playerCpuScoreLabel.AutoSize = true;
            this.playerCpuScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playerCpuScoreLabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCpuScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.playerCpuScoreLabel.Location = new System.Drawing.Point(576, 50);
            this.playerCpuScoreLabel.Name = "playerCpuScoreLabel";
            this.playerCpuScoreLabel.Size = new System.Drawing.Size(39, 45);
            this.playerCpuScoreLabel.TabIndex = 4;
            this.playerCpuScoreLabel.Text = "0";
            this.playerCpuScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Interval = 10;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // pausedtext
            // 
            this.pausedtext.AutoSize = true;
            this.pausedtext.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausedtext.ForeColor = System.Drawing.SystemColors.Control;
            this.pausedtext.Location = new System.Drawing.Point(266, 187);
            this.pausedtext.Name = "pausedtext";
            this.pausedtext.Size = new System.Drawing.Size(366, 117);
            this.pausedtext.TabIndex = 5;
            this.pausedtext.Text = "PAUSED";
            // 
            // playerwintext
            // 
            this.playerwintext.AutoSize = true;
            this.playerwintext.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerwintext.ForeColor = System.Drawing.SystemColors.Control;
            this.playerwintext.Location = new System.Drawing.Point(262, 194);
            this.playerwintext.Name = "playerwintext";
            this.playerwintext.Size = new System.Drawing.Size(617, 117);
            this.playerwintext.TabIndex = 6;
            this.playerwintext.Text = "PLAYER WINS!";
            // 
            // cpuwintext
            // 
            this.cpuwintext.AutoSize = true;
            this.cpuwintext.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuwintext.ForeColor = System.Drawing.SystemColors.Control;
            this.cpuwintext.Location = new System.Drawing.Point(137, 194);
            this.cpuwintext.Name = "cpuwintext";
            this.cpuwintext.Size = new System.Drawing.Size(489, 117);
            this.cpuwintext.TabIndex = 7;
            this.cpuwintext.Text = "CPU WINS!";
            // 
            // Pong
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(890, 504);
            this.Controls.Add(this.cpuwintext);
            this.Controls.Add(this.playerwintext);
            this.Controls.Add(this.pausedtext);
            this.Controls.Add(this.playerCpuScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.playerCpu);
            this.Controls.Add(this.player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label pausedtext;
        private System.Windows.Forms.Label playerwintext;
        private System.Windows.Forms.Label cpuwintext;
    }
}