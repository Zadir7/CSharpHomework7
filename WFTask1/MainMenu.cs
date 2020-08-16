using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTask1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        private void buttonPlayDouble_Click(object sender, EventArgs e)
        {
            new DoubleGame().ShowDialog();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPlayGuessing_Click(object sender, EventArgs e)
        {
            new GuessingGame().ShowDialog();
        }
    }
}
