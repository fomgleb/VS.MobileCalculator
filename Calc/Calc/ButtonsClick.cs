using System;
using Xamarin.Forms;

namespace Calc
{
    public partial class MainPage
    {
        private void operationsButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "=": Equals(); break;
                case "√": Root(); break;
                case "%": Percent(); break;
                case "1/x": OneDividedBy(); break;
                case "+/-": Negate(); break;
                case "C": EraseAll(); break;
                case "⌫": Erase(); break;
                case "CE": mainLabel.Text = "0"; break;
                default: PlusMinusTimesDivideDegree(button); break;
            }
        }
        void numberButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Numbers(button);
        }
    }
}
