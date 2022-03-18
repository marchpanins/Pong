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
        public PongMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startgame_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Pong();
            myForm.Show();
        }
    }
}
