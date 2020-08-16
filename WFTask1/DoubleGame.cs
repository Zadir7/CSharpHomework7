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
    public partial class DoubleGame : Form
    {
        int targetNumber;
        int userNumber;
        Random r = new Random();
        Stack<int> steps = new Stack<int>();

        public void GameStart()
        {
            targetNumber = r.Next(16, 512);
            userNumber = 1;
            labelTarget.Text = $"Цель: {targetNumber}";
            labelGameStatus.Text = $"Доберитесь до цели!";
            steps.Clear();
            CheckNumber();
            buttonAdd.Enabled = true;
            buttonMultiply.Enabled = true;
        }
        public void CheckNumber()
        {
            labelCurrentNumber.Text = $"{userNumber}";
            labelSteps.Text = $"Шагов: {steps.Count}";

            if (steps.Count == 0)
            {
                buttonUndo.Enabled = false;
            } 
            else { buttonUndo.Enabled = true; }

            if (userNumber == targetNumber)
            {
                labelGameStatus.Text = $"Вы победили за {steps.Count} шагов!";
                GameOver();
            }
            if (userNumber > targetNumber)
            {
                labelGameStatus.Text = $"Вы проиграли =(\n Сделано {steps.Count} шагов.";
                GameOver();
            }
        }

        public void GameOver()
        {
            buttonAdd.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonUndo.Enabled = false;
        }
        public DoubleGame()
        {
            InitializeComponent();
            GameStart();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            GameOver();
            GameStart();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            userNumber += 1;
            steps.Push(1);
            CheckNumber();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            userNumber *= 2;
            steps.Push(2);
            CheckNumber();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            switch (steps.Pop())
            {
                case 1: userNumber -= 1;
                    break;
                case 2: userNumber /= 2;
                    break;
            }
            CheckNumber();
        }
    }
}
