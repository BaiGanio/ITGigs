using System;
using System.Web.UI;
using SumatorDemo.Properties;

namespace SumatorDemo
{
    public partial class Sumator : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void ButtonCalculateSum_OnClick(object sender, EventArgs e)
        {
            try
            {
                decimal firstNum = decimal.Parse(TextBoxFirstNum.Text);
                decimal secondNum = decimal.Parse(TextBoxSecondNumber.Text);
                decimal sum = firstNum + secondNum;
                //TextBoxSum.Text = sum.ToString();
                TextBoxSum.Text = Settings.Default.nickName;
            }
            catch (Exception)
            {

                this.TextBoxSum.Text = "Invalid!";
            }
        }
    }
}