using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Pong : Form
    {
        //Size variables
        int bottomBoundary;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;

        //Location variables
        int ballXcoord = 5;
        int ballYcoord = 5;
        int cpuDir = 5;

        //Score variables
        int player1Score = 0;
        int playerCpuScore = 0;

        //Detection variables
        bool playerDetectedUp;
        bool playerDetectedDown;

        //Special keys
        int spaceBarClick = 0;

        public Pong()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - player1.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;

            //Centers and hides labels

            pausedtext.Hide();
            pausedtext.Left = (this.ClientSize.Width - pausedtext.Width) / 2;
            pausedtext.Top = (this.ClientSize.Height - pausedtext.Height) / 2;
            playerwintext.Hide();
            playerwintext.Left = (this.ClientSize.Width - playerwintext.Width) / 2;
            playerwintext.Top = (this.ClientSize.Height - playerwintext.Height) / 2;
            cpuwintext.Hide();
            cpuwintext.Left = (this.ClientSize.Width - cpuwintext.Width) / 2;
            cpuwintext.Top = (this.ClientSize.Height - cpuwintext.Height) / 2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            //When someone scores generates where to spawn ball
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            //Moves the ball
            ball.Top -= ballYcoord;
            ball.Left -= ballXcoord;
            //Cpu movement
            playerCpu.Top += cpuDir;
            //Check if ball hits paddle
            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(playerCpu.Bounds))
            {
                //Make ball go the opposite direction
                ballXcoord = -ballXcoord;
            }
            //Check if cpu is at the top or bottom of the form
            if (playerCpu.Top < 0 || playerCpu.Top > bottomBoundary)
            {
                cpuDir = -cpuDir;
            }
            //Check if cpu has scored
            if (ball.Left < 0)
            {
                ball.Left = xMidpoint;
                ball.Top = newSpot;
                ballXcoord = -ballXcoord;
                playerCpuScore++;
                playerCpuScoreLabel.Text = playerCpuScore.ToString();
            }
            //Check if player has scored
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = xMidpoint;
                ball.Top = newSpot;
                ballXcoord = -ballXcoord;
                player1Score++;
                player1ScoreLabel.Text = player1Score.ToString();
            }
            //Make sure ball stays in screen
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                ballYcoord = -ballYcoord;
            }
            //Move player up
            if (playerDetectedUp == true && player1.Top > 0)
            {
                player1.Top -= 10;
            }
            //Move player down
            if (playerDetectedDown == true && player1.Top < bottomBoundary)
            {
                player1.Top += 10;
            }
            //Check for winner
            if (player1Score > 4)
            {
                pongTimer.Stop();
                playerwintext.Show();
            }
            if (playerCpuScore > 4)
            {
                pongTimer.Stop();
                cpuwintext.Show();
            }

        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            //If player stops pressing up arrow, stop moving paddle up
            if (e.KeyCode == Keys.Up) { playerDetectedUp = false; }
            //If player stops pressing down arrow, stop moving paddle down
            if (e.KeyCode == Keys.Down) { playerDetectedDown = false; }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            //If player presses up arrow, move paddle up
            if(e.KeyCode == Keys.Up) { playerDetectedUp = true; }
            //If player presses down arrow, move paddle down
            if (e.KeyCode == Keys.Down) { playerDetectedDown = true; }

            //If player presses spacebar, pause the game
            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarClick % 2 == 0)
                {
                    pongTimer.Stop();
                    pausedtext.Show();
                }
                else
                {
                    pongTimer.Start();
                    pausedtext.Hide();
                }
                
            }
            spaceBarClick++;
        }
       
    }
}
