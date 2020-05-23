using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Random ran = new Random();                           // set random numbers to labels from 0 to 100
            firstNumberLabel.Text = ran.Next(0, 100).ToString();
            SecondNumberLabel.Text = ran.Next(0, 100).ToString();
            thirdNumberLabel.Text = ran.Next(0, 100).ToString();
            fourthNumberLabel.Text = ran.Next(0, 100).ToString();
            fivethNumberLabel.Text = ran.Next(0, 100).ToString();
            sixthNumberLabel.Text = ran.Next(0, 100).ToString();
            seventhNumberLabel.Text = ran.Next(0, 100).ToString();
            eightthNumberLabel.Text = ran.Next(0, 100).ToString();

            timeTimer.Start();
            secondsTextbox.BackColor = Color.LightGreen;


        }

      

        int seconds = 80;

        private void timeTimer_Tick(object sender, EventArgs e)
        {

            seconds--;
         
            if (seconds < 60)
            {
                secondsTextbox.BackColor = Color.Orange;
            }

            if (seconds < 30)
            {
                secondsTextbox.BackColor = Color.Red;
            }

            if (seconds == 0)
            {
                timeTimer.Stop();
                MessageBox.Show("Time is up! You didn't finish the quiz.");
            }
            secondsTextbox.Text = seconds.ToString();
        }


        private void finishButton_Click(object sender, EventArgs e)
        {
            timeTimer.Stop();

            int number1, number2, number3, number4, number5, number6, number7, number8;
            number1 = int.Parse(firstNumberLabel.Text);
            number2 = int.Parse(SecondNumberLabel.Text);
            number3 = int.Parse(thirdNumberLabel.Text);
            number4 = int.Parse(fourthNumberLabel.Text);
            number5 = int.Parse(fivethNumberLabel.Text);
            number6 = int.Parse(sixthNumberLabel.Text);
            number7 = int.Parse(seventhNumberLabel.Text);
            number8 = int.Parse(eightthNumberLabel.Text);

            double additionAnswer, substracionAnswer, multiplicationAnswer, divisionAnswer;
            additionAnswer = number1 + number2;
            substracionAnswer = number3 - number4;
            multiplicationAnswer = number5 * number6;
            divisionAnswer = number7 / number8;

            if (additionAnswer != double.Parse(additionTextbox.Text))
            {
                MessageBox.Show("Correct answer in question 1: " + additionAnswer);
            }

            if (substracionAnswer != double.Parse(substractionTextbox.Text))
            {
                MessageBox.Show("Correct answer in question 2: " + substracionAnswer);
            }

            if (multiplicationAnswer != double.Parse(multiplicationTextbox.Text))
            {
                MessageBox.Show("Correct answer in question 3: " + multiplicationAnswer);
            }

            if (divisionAnswer != double.Parse(divisionTextbox.Text))
            {
                MessageBox.Show("Correct answer in question 4: " + divisionAnswer);
            }

           int  quizTime = 80 - seconds;
            MessageBox.Show("Your total time was: " +quizTime + "seconds");

            additionTextbox.Text = "";
            substractionTextbox.Text = "";
            multiplicationTextbox.Text = "";
            divisionTextbox.Text = "";



        }
    }
}
