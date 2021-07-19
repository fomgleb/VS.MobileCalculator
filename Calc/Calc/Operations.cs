using System;
using Xamarin.Forms;

namespace Calc
{
    public partial class MainPage
    {
        void PlusMinusTimesDivideDegree(Button button)
        {
            
            if (operation != ' ')
                Equals();
            if (thereResult == true)
            {
                thereResult = false;
                secondLabel.Text = "";
            }
            if (num2 == 0)
            {
                operation = Convert.ToChar(button.Text);
                num1 = Convert.ToDouble(mainLabel.Text);
                secondLabel.Text += mainLabel.Text;
                secondLabel.Text += button.Text;
                mainLabel.Text = "0";
            }
        }

        void Root()
        {
            result = Math.Sqrt(Convert.ToDouble(mainLabel.Text));
            secondLabel.Text = $"sqrt({mainLabel.Text}) =";
            mainLabel.Text = Convert.ToString(result);
            thereResult = true;
        }

        void Negate()
        {
            result = Convert.ToDouble(mainLabel.Text) * -1;
            mainLabel.Text = Convert.ToString(result);
            thereResult = true;
        }

        void OneDividedBy()
        {
            result = 1 / Convert.ToDouble(mainLabel.Text);
            secondLabel.Text = $"1/{mainLabel.Text}=";
            mainLabel.Text = Convert.ToString(result);
            thereResult = true;
        }

        void Percent()
        {
            if (operation == '+' || operation == '-')
            {
                result = num1 * (Convert.ToDouble(mainLabel.Text) / 100);
                mainLabel.Text = Convert.ToString(result);
            }
            else if (operation == '×' || operation == '÷')
            {
                result = Convert.ToDouble(mainLabel.Text) * 0.01;
                mainLabel.Text = Convert.ToString(result);
            }
        }

        void Numbers(Button button)
        {
            if (button.Text == ",")
            {
                if (!mainLabel.Text.Contains(","))
                    mainLabel.Text += button.Text;
            }
            else
            {
                if (mainLabel.Text == "0")
                    mainLabel.Text = "";
                mainLabel.Text += button.Text;
            }
        }

        public void Equals()
        {
            try
            {
                num2 = Convert.ToDouble(mainLabel.Text);

                switch (operation)
                {
                    case '+': result = num1 + num2; thereResult = true; break;
                    case '-': result = num1 - num2; thereResult = true; break;
                    case '×': result = num1 * num2; thereResult = true; break;
                    case '÷': result = num1 / num2; thereResult = true; break;
                    case '^': result = Math.Pow(num1, num2); thereResult = true; break;
                    default: break;
                }
                if (thereResult == true && operation != ' ')
                {
                    secondLabel.Text += mainLabel.Text + "=";
                    mainLabel.Text = Convert.ToString(result);

                    num1 = result;
                }
                else
                    num1 = 0;
                num2 = 0;
                operation = ' ';
            }
            catch (Exception)
            {
            }
        }

        void Erase()
        {
            var len = mainLabel.Text.Length;
            if (mainLabel.Text != "0")
                mainLabel.Text = mainLabel.Text.Remove(len - 1);
            if (mainLabel.Text == "")
                mainLabel.Text = "0";
        }

        void EraseAll()
        {
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = ' ';
            mainLabel.Text = "0";
            secondLabel.Text = "";
            thereResult = false;
        }
    }
}
