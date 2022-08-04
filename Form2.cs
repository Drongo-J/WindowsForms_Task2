using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace WindowsForms_Task2
{
    public partial class Form2 : Form
    {
        private bool darkMode = true;
        private double number1;
        private double number2;
        private double result;
        private string currentOp;
        private bool zeroDivisionError = false;
        private bool getNumber2 = false;
        private bool operationClicked = false;
        private bool equalsClicked = false;
        private bool percentClicked = false;

        public Form2()
        {
            InitializeComponent();

            ScreenTB.Text = "0";

            number1Btn.Click += number0Btn_Click;
            number2Btn.Click += number0Btn_Click;
            number3Btn.Click += number0Btn_Click;
            number4Btn.Click += number0Btn_Click;
            number5Btn.Click += number0Btn_Click;
            number6Btn.Click += number0Btn_Click;
            number7Btn.Click += number0Btn_Click;
            number8Btn.Click += number0Btn_Click;
            number9Btn.Click += number0Btn_Click;

            subtractBtn.Click += plusBtn_Click;
            multiplyBtn.Click += plusBtn_Click;
            divideBtn.Click += plusBtn_Click;
        }

        private void number0Btn_Click(object sender, EventArgs e)
        {
            if (ScreenTB.Text.Contains(".")) // There can be a maximum of 11 numbers
            {
                ScreenTB.MaxLength = 11;
            }
            else
            {
                ScreenTB.MaxLength = 12;
            }

            if (ScreenTB.Text.Length < ScreenTB.MaxLength || ScreenTB.Text == "Cannot divide by zero")
            {
                var button = sender as Guna2CircleButton;
                if (operationClicked || ScreenTB.Text == "0" || ScreenTB.Text == "Cannot divide by zero")
                {
                    ScreenTB.Text = String.Empty;
                    operationClicked = false;
                }
                if (zeroDivisionError)
                {
                    ScreenTB.Font = new Font(ScreenTB.Font.FontFamily.Name, ScreenTB.Font.Size + 13f);
                    zeroDivisionError = false;
                    equalsClicked = false;
                }
                ScreenTB.Text += button.Text.Trim();
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            var button = sender as Guna2CircleButton;
            currentOp = button.Text.Trim();

            double.TryParse(ScreenTB.Text.Trim(), out number1);
            if (equalsClicked)
            {
                HistoryTB.Text = result.ToString() + $" {currentOp} ";
                equalsClicked = false;
            }
            else
            {
                if (HistoryTB.Text.Contains("=") || operationClicked)
                {
                    HistoryTB.Text = String.Empty;
                }
                HistoryTB.Text += number1.ToString() + " ";
                HistoryTB.Text += currentOp + " ";
            }
            operationClicked = true;
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                number1 = result;
                HistoryTB.Text = $"{number1} {currentOp}";
                getNumber2 = false;
            }
            else
            {
                getNumber2 = true;
            }

            if (currentOp != String.Empty)
            {
                equalsClicked = true;
                if (!percentClicked && getNumber2)
                {
                    double.TryParse(ScreenTB.Text.Trim(), out number2);
                }
            }

            if (currentOp == "+")
            {
                result = number1 + number2;
            }
            else if (currentOp == "–")
            {
                result = number1 - number2;
            }
            else if (currentOp == "×")
            {
                result = number1 * number2;
            }
            else if (currentOp == "÷")
            {
                if (number2 == 0)
                {
                    ScreenTB.Font = new Font(ScreenTB.Font.FontFamily.Name, ScreenTB.Font.Size - 13f);
                    ScreenTB.Text = "Cannot divide by zero";
                    HistoryTB.Text = String.Empty;
                    zeroDivisionError = true;
                }
                else
                {

                    result = number1 / number2;
                    zeroDivisionError = false;
                }
            }

            if (result.ToString().Length >= 12)
            {
                int digits = 12 - (((int)result).ToString().Length + 1);
                result = Math.Round(result, digits);
            }

            if (!zeroDivisionError)
            {
                ScreenTB.Text = result.ToString();
                if (percentClicked)
                {
                    HistoryTB.Text += " = " + result;
                    percentClicked = false;
                }
                else
                {
                    HistoryTB.Text += number2 + " = " + result;
                }
            }
        }

        private void ACbtn_Click(object sender, EventArgs e)
        {
            ScreenTB.Text = "0";
            HistoryTB.Text = String.Empty;
            number1 = 0;
            number2 = 0;
            result = 0;
            currentOp = String.Empty;
            equalsClicked = false;
            operationClicked = false;
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            if (ScreenTB.Text.Length == 1)
            {
                ScreenTB.Text = "0";
            }
            if (ScreenTB.Text != "0")
            {
                ScreenTB.Text = ScreenTB.Text.Remove(ScreenTB.Text.Length - 1);
            }
            equalsClicked = false;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (!ScreenTB.Text.Contains("."))
            {
                ScreenTB.Text += ".";
            }
        }

        private void changeSymbolBtn_Click(object sender, EventArgs e)
        {
            if (!operationClicked) // number1
            {
                double.TryParse(ScreenTB.Text, out number1);
                if (number1 > 0)
                {
                    number1 -= number1 * 2;
                }
                else if (number1 < 0)
                {
                    number1 += Math.Abs(number1) * 2;
                }
                ScreenTB.Text = number1.ToString();
                equalsClicked = false;
            }
            else
            {
                double.TryParse(ScreenTB.Text, out number2);
                if (number2 > 0)
                {
                    number2 -= number2 * 2;
                }
                else if (number2 < 0)
                {
                    number2 += Math.Abs(number2) * 2;
                }

                ScreenTB.Text = number2.ToString();
            }
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            percentClicked = true;
            if (HistoryTB.Text != String.Empty && !equalsClicked)
            {
                if (HistoryTB.Text.Contains(currentOp))
                {
                    double.TryParse(ScreenTB.Text, out number2);
                    number2 /= 100;
                    HistoryTB.Text += number2.ToString();
                }
                else
                {
                    ACbtn_Click(sender, e);
                }
            }
        }

        private void changeModeTS_CheckedChanged(object sender, EventArgs e)
        {
            // For Each ???

            if (darkMode) // change to light mode
            {
                changeToLbl.ForeColor = Color.Black;

                BackgroundPnl.BackColor = Color.White;
                ScreenTB.BackColor = Color.White;
                ScreenTB.ForeColor = Color.FromArgb(45, 43, 55);
                HistoryTB.BackColor = Color.White;

                number0Btn.ForeColor = Color.Black;
                number1Btn.ForeColor = Color.Black;
                number2Btn.ForeColor = Color.Black;
                number3Btn.ForeColor = Color.Black;
                number4Btn.ForeColor = Color.Black;
                number5Btn.ForeColor = Color.Black;
                number6Btn.ForeColor = Color.Black;
                number7Btn.ForeColor = Color.Black;
                number8Btn.ForeColor = Color.Black;
                number9Btn.ForeColor = Color.Black;
                backspaceBtn.ForeColor = Color.Black;
                percentBtn.ForeColor = Color.Black;
                changeSymbolBtn.ForeColor = Color.Black;
                dotBtn.ForeColor = Color.Black;

                plusBtn.FillColor = Color.White;
                subtractBtn.FillColor = Color.White;
                multiplyBtn.FillColor = Color.White;
                divideBtn.FillColor = Color.White;

                plusBtn.ForeColor = Color.Black;
                subtractBtn.ForeColor = Color.Black;
                multiplyBtn.ForeColor = Color.Black;
                divideBtn.ForeColor = Color.Black;


                darkMode = false;
            }
            else
            {
                changeToLbl.ForeColor = Color.White;

                BackgroundPnl.BackColor = Color.FromArgb(45, 43, 55);
                ScreenTB.BackColor = Color.FromArgb(45, 43, 55);
                ScreenTB.ForeColor = Color.White;
                HistoryTB.BackColor = Color.FromArgb(45, 43, 55);

                number0Btn.ForeColor = Color.White;
                number1Btn.ForeColor = Color.White;
                number2Btn.ForeColor = Color.White;
                number3Btn.ForeColor = Color.White;
                number4Btn.ForeColor = Color.White;
                number5Btn.ForeColor = Color.White;
                number6Btn.ForeColor = Color.White;
                number7Btn.ForeColor = Color.White;
                number8Btn.ForeColor = Color.White;
                number9Btn.ForeColor = Color.White;
                backspaceBtn.ForeColor = Color.White;
                percentBtn.ForeColor = Color.White;
                changeSymbolBtn.ForeColor = Color.White;
                dotBtn.ForeColor = Color.White;

                plusBtn.FillColor = Color.FromArgb(159, 159, 159);
                subtractBtn.FillColor = Color.FromArgb(159, 159, 159);
                multiplyBtn.FillColor = Color.FromArgb(159, 159, 159);
                divideBtn.FillColor = Color.FromArgb(159, 159, 159);

                plusBtn.ForeColor = Color.White;
                subtractBtn.ForeColor = Color.White;
                multiplyBtn.ForeColor = Color.White;
                divideBtn.ForeColor = Color.White;

                darkMode = true;
            }
        }
    }
}
