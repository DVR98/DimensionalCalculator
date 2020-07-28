using Models.CalculateAnswer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DimensionalCalculator
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Homepage : Page
    {
        //string sLine;
        //float iAnswer, iLine, iNum, iNum1, iNum2, i, iPos;
        //Boolean bValid = false;
        //Boolean bMinus = false;
        //Boolean bPlus = false;
        //Boolean bDivide = false;
        //Boolean bMultiply = false;
        //float rLine, rAnswer;

        //public Homepage()
        //{
        //    this.InitializeComponent();
        //}

        //private bool Valid = false;

        //public void Validation() //Checks if user entered the correct values
        //{
        //    var iValid = int.TryParse(edtOutput.Text, out int Value);

        //    if (iValid == true)
        //    {
        //        Valid = true;
        //        redError.Text = "";

        //    }
        //    else
        //    {
        //        redError.Text = "Please enter number and not a string";
        //        edtOutput.Text = "";
        //    }
        //}

        //public void CalculateAnswer()
        //{
        //    if (bMinus == true) //if user chose to minus
        //    {
        //        iAnswer = iLine - int.Parse(edtOutput.Text);
        //        edtOutput.Text = iAnswer.ToString();
        //    }

        //    if (bPlus == true) //if user chose to plus
        //    {
        //        iAnswer = iLine + int.Parse(edtOutput.Text);
        //        edtOutput.Text = iAnswer.ToString();
        //    }

        //    if (bMultiply == true) // if user chose to multiply
        //    {
        //        iAnswer = iLine * int.Parse(edtOutput.Text);
        //        edtOutput.Text = iAnswer.ToString();
        //    }

        //    if (bDivide == true) //if user chose to divide
        //    {
        //        if (float.Parse(edtOutput.Text) > 0) //If the user divides, he can't divide with 0
        //        {
        //            rAnswer = rLine / float.Parse(edtOutput.Text);
        //            edtOutput.Text = rAnswer.ToString();
        //        }
        //        else {redError.Opacity = 100; }
        //    }

        //    btn0.IsEnabled = false; //Disables buttons untill user press the clear button
        //    btn1.IsEnabled = false;
        //    btn2.IsEnabled = false;
        //    btn3.IsEnabled = false;
        //    btn4.IsEnabled = false;
        //    btn5.IsEnabled = false;
        //    btn6.IsEnabled = false;
        //    btn7.IsEnabled = false;
        //    btn8.IsEnabled = false;
        //    btn9.IsEnabled = false;
        //    btnEqual.IsEnabled = false;

        //}

        //public string CallValue(int iNum)
        //{
        //    sLine = sLine + iNum.ToString();  //Adds numbers to a string for further calculation

        //    return sLine;
        //}

        //private void btn2_Click(object sender, RoutedEventArgs e)
        //{

        //    edtOutput.Text = edtOutput.Text + '2';
        //    CallValue(2);                                 //Adds 2
        //}

        //private void btn1_Click(object sender, RoutedEventArgs e)
        //{
        //    edtOutput.Text = edtOutput.Text + '1';
        //    CallValue(1);                                 //Adds 1
        //}

        //private void btn3_Click(object sender, RoutedEventArgs e)
        //{
        //    edtOutput.Text = edtOutput.Text + '3';
        //    CallValue(3);                                 //Adds 3
        //}

        //private void btn4_Click(object sender, RoutedEventArgs e)
        //{
        //    edtOutput.Text = edtOutput.Text + '4';
        //    CallValue(4);                                 //Adds 4
        //}

        //private void btn5_Click(object sender, RoutedEventArgs e)
        //{
        //    edtOutput.Text = edtOutput.Text + '5';
        //    CallValue(5);                                 //Adds 5
        //}

        //private void btn6_Click(object sender, RoutedEventArgs e)
        //{
        //    edtOutput.Text = edtOutput.Text + '6';
        //    CallValue(6);                                 //Adds 6
        //}

        //private void btn7_Click(object sender, RoutedEventArgs e)
        //{
        //    edtOutput.Text = edtOutput.Text + '7';
        //    CallValue(7);                                 //Adds 7
        //}

        //private void btnDivide_Click(object sender, RoutedEventArgs e)
        //{
        //    Validation();

        //    if (Valid == true)
        //    {
        //        if (float.Parse(edtOutput.Text) > 0)
        //        {
        //            btnMinus.IsEnabled = false;
        //            btnPlus.IsEnabled = false;
        //            btnMultiply.IsEnabled = false;     //Disables calculation buttons untill user press =
        //            btnDivide.IsEnabled = false;
        //            edtOutput.Text = "";

        //            if ((bMinus == true) || (bPlus == true) || (bDivide == true) || (bMultiply == true))//if a calculation was already done, it takes the previous Answer for further calculation
        //            {
        //                rLine = iAnswer;
        //                sLine = iLine.ToString();
        //            }
        //            else
        //            {
        //                rLine = float.Parse(sLine);
        //                bDivide = true;
        //                edtOutput.Text = "";
        //                sLine = sLine + " / ";
        //            }
        //        }
        //        else { redError.Text = "Can't divide with 0, enter larger value"; }

        //    }
        //    else
        //    {
        //        redError.Text = "Please enter a number, not a word/letter.";
        //        edtOutput.Text = "";
        //    }


        //}

        //private void btn0_Click(object sender, RoutedEventArgs e)
        //{
        //    edtOutput.Text = edtOutput.Text + '0';
        //    CallValue(0);
        //}

        //private void btnMultiply_Click(object sender, RoutedEventArgs e)
        //{
        //    Validation();

        //    if (Valid == true)
        //    {
        //        btnMinus.IsEnabled = false;
        //        btnPlus.IsEnabled = false;
        //        btnMultiply.IsEnabled = false;     //Disables button untill user press =
        //        btnDivide.IsEnabled = false;
        //        btnEqual.IsEnabled = true;

        //        edtOutput.Text = "";

        //        if ((bMinus == true) || (bPlus == true) || (bDivide == true) || (bMultiply == true))//if a calculation was already done, it takes the previous Answer for further calculation
        //        {
        //            btnEqual.IsEnabled = true;
        //            iLine = iAnswer;
        //            sLine = iLine.ToString();
        //        }
        //        else
        //        {
        //            iLine = int.Parse(sLine);
        //            bMultiply = true;
        //            edtOutput.Text = "";
        //            sLine = sLine + " * ";
        //        }
        //    }
        //    else
        //    {
        //        redError.Text = "Please enter a number, not a word/letter.";
        //        edtOutput.Text = "";
        //    }

        //}

        //private void btnArray20_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(BubbleSort));  //navigates to the Bubblesort page
        //}

        //private void btnMassPage_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(MassPage));  //navigates to the Mass page
        //}

        //private void btnExchangePage_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(ExchangePage));  //navigates to the Exchange page
        //}

        //private void btnQuicksort_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(QuicksortPage)); //navigates to the quicksort page
        //}

        //private void btnInterest_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(InterestPage)); //navigates to the Interests page
        //}

        //private void btn8_Click(object sender, RoutedEventArgs e)
        //{
        //    edtOutput.Text = edtOutput.Text + '8';
        //    CallValue(8);                            //Adds 8
        //}

        //private void btnMinus_Click(object sender, RoutedEventArgs e)
        //{
        //    Validation();

        //    if (Valid == true)
        //    {
        //        btnMinus.IsEnabled = false;
        //        btnPlus.IsEnabled = false;
        //        btnMultiply.IsEnabled = false;     //Disables button untill user press =
        //        btnDivide.IsEnabled = false;
        //        btnEqual.IsEnabled = true;
        //        edtOutput.Text = "";

        //        if ((bMinus == true) || (bPlus == true) || (bDivide == true) || (bMultiply == true))//if a calculation was already done, it takes the previous Answer for further calculation
        //        {
        //            iLine = iAnswer;
        //            sLine = iLine.ToString();
        //            btnEqual.IsEnabled = true;
        //        }
        //        else
        //        {
        //            iLine = int.Parse(sLine);  //if calculatio hasnt been done before then:
        //            bMinus = true;
        //            edtOutput.Text = "";
        //            sLine = sLine + " - ";
        //        }
        //    }
        //    else
        //    {
        //        redError.Text = "Please enter a number, not a word/letter.";
        //        edtOutput.Text = "";
        //    }

        //}

        //private void btnPlus_Click(object sender, RoutedEventArgs e)
        //{
        //    Validation();

        //    if (Valid == true)
        //    {
        //        btnMinus.IsEnabled = false;
        //        btnPlus.IsEnabled = false;
        //        btnMultiply.IsEnabled = false;     //Disables button untill user press =
        //        btnDivide.IsEnabled = false;
        //        btnEqual.IsEnabled = true;
        //        edtOutput.Text = "";

        //        if ((bMinus == true) || (bPlus == true) || (bDivide == true) || (bMultiply == true))//if a calculation was already done, it takes the previous Answer for further calculation
        //        {
        //            iLine = iAnswer;
        //            sLine = iLine.ToString();
        //            btnEqual.IsEnabled = true;
        //        }
        //        else
        //        {
        //            iLine = int.Parse(sLine);
        //            bPlus = true;
        //            edtOutput.Text = "";
        //            sLine = sLine + " + ";
        //        }
        //    }
        //    else
        //    {
        //        redError.Text = "Please enter a number, not a word/letter.";
        //        edtOutput.Text = "";
        //    }
        //}

        //private void btnEqual_Click(object sender, RoutedEventArgs e)
        //{
        //    Validation();

        //    if (Valid == true)
        //    {
        //        CalculateAnswer();  //calls a void method. The method calculates the answer
        //    }

        //}

        //private void btn9_Click(object sender, RoutedEventArgs e)
        //{
        //    edtOutput.Text = edtOutput.Text + '9';
        //    CallValue(9);                                 //Adds 9
        //}

        //private void btnClear_Click(object sender, RoutedEventArgs e)  //Resets all values to their default values
        //{
        //    bMinus = false;
        //    bPlus = false;
        //    bValid = false;
        //    edtOutput.Text = "";
        //    sLine = "";
        //    iLine = 0;
        //    iAnswer = 0;
        //    rAnswer = 0;
        //    rLine = 0;
        //    bDivide = false;
        //    bMultiply = false;
        //    btnMinus.IsEnabled = true;
        //    btnPlus.IsEnabled = true;
        //    btnMultiply.IsEnabled = true;     //Enables buttons
        //    btnDivide.IsEnabled = true;
        //    btn0.IsEnabled = true;
        //    btn1.IsEnabled = true;
        //    btn2.IsEnabled = true;
        //    btn3.IsEnabled = true;
        //    btn4.IsEnabled = true;
        //    btn5.IsEnabled = true;
        //    btn6.IsEnabled = true;
        //    btn7.IsEnabled = true;
        //    btn8.IsEnabled = true;
        //    btn9.IsEnabled = true;

        //}
        public Homepage()
        {
            this.InitializeComponent();
        }

        public float Total = 0;
        public string sign = "";

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if((float.TryParse(textBox.Text, out float value) == true) | ((textBox.Text.Contains(",") == true))) 
            {
                Button button = (Button)sender;
                textBox.Text += button.Content;
            }
            else
            {
                textBox.Text = "";
                Button button = (Button)sender;
                textBox.Text += button.Content;
            }
        }

        // The addition button
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            float number;
            bool result = float.TryParse(textBox.Text, out number);
            if (result == true)
            {
                Total = number;
                sign = "+";
                textBox.Text = "";
            }
            else
            {
                textBox.Text = "Please enter a number or calculation sign by pressing the buttons.";
            }
        }

        //The minus button
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            float number;
            bool result = float.TryParse(textBox.Text, out number);
            if (result)
            {
                Total = number;
                sign = "-";
                textBox.Text = "";
            }
            else
            {
                textBox.Text = "Please enter a number or calculation sign by pressing the buttons.";
            }
        }

        // The multiply button
        private void mulitiply_Click(object sender, RoutedEventArgs e)
        {
            float number;
            bool result = float.TryParse(textBox.Text, out number);
            if (result)
            {
                Total = number;
                sign = "*";
                textBox.Text = "";
            }
            else
            {
                textBox.Text = "Please enter a number or calculation sign by pressing the buttons.";
            }
        }

        //The divide button
        private void divide_Click(object sender, RoutedEventArgs e)
        {
            float number;
            bool result = float.TryParse(textBox.Text, out number);
            if (result)
            {
                Total = number;
                sign = "/";
                textBox.Text = "";
            }
            else
            {
                textBox.Text = "Please enter a number or calculation sign by pressing the buttons.";
            }
        }

        // The calculate button
        private void equals_click(object sender, RoutedEventArgs e)
        {
            float number;
            bool result = float.TryParse(textBox.Text, out number);
            if (result)
            {
                CalculateAnswer a = new CalculateAnswer(Total, number, sign);

                Total = a.Answer();

                textBox.Text = Total.ToString();
            }
            else
            {
                textBox.Text = "Please enter a number or calculation sign by pressing the buttons.";
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            Total = 0;
        }
    }
}