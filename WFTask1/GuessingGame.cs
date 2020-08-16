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
    public partial class GuessingGame : Form
    {
        int tryCount;
        int maxCount = 10;
        int answer;
        string info;
        Random r = new Random();

        public void GameStart()
        {
            tryCount = 0;
            answer = r.Next(1, 100);
            buttonSubmit.Enabled = true;
            labelGameStatus.Text = $"Введите число от 1 до 100";
        }
        public void GameOver()
        {
            buttonSubmit.Enabled = false;
        }
        public void CheckAnswer(string s)
        {
            int userAnswer;
            try
            {
                userAnswer = int.Parse(s);
            }
            catch (Exception)
            {
                userAnswer = 0;
            }
            tryCount++;
            if (tryCount < maxCount) {
                if (userAnswer <= 0 || userAnswer > 100)
                {
                    info = $"Введено неправильное значение!\n Попытка потрачена.Осталось {maxCount - tryCount}.";
                }
                else if (userAnswer > answer && userAnswer <= 100)
                {
                    info = $"Слишком большое число! Попыток: {maxCount - tryCount}";
                }
                else if (userAnswer < answer && userAnswer > 0)
                {
                    info = $"Слишком маленькое число! Попыток: {maxCount - tryCount}";
                }
                else if (userAnswer == answer)
                {
                    info = $"Вы угадали!\n Оставалось еще {maxCount - tryCount} попыток.";
                    GameOver();
                }
            }
            else 
            { 
                info = $"У вас закончились попытки!\n Вы проиграли!";
                GameOver();
            }
            labelGameStatus.Text = info;
        }

        public GuessingGame()
        {
            InitializeComponent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            CheckAnswer(textUserNumber.Text);
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            GameStart();
        }
    }
}
