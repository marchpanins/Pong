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
    public partial class PongMenu : Form
    {
        int logonr;
        public PongMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logonr = 0;
            mainmenulogotimer.Enabled = true;
        }

        private void startgame_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Pong();
            myForm.Show();
        }

        private void mainmenulogotimer_Tick(object sender, EventArgs e)
        {
            //Makes the main menu logo look hand wobbly
            mainlogo1.Hide();
            mainlogo2.Hide();
            mainlogo3.Hide();
            if (logonr == 0)
            {
                mainlogo1.Show();
                logonr++;
            }
            else if (logonr == 1)
            {
                mainlogo2.Show();
                logonr++;
            }
            else if (logonr == 2)
            {
                mainlogo3.Show();
                logonr = 0;
            }
            
            
        }
    }
}
