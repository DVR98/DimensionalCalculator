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
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionalCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InterestPage : Page
    {    
        public InterestPage()
        {
            this.InitializeComponent();
            btn0.IsEnabled = false;  
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            btnEqual.IsEnabled = false;
            btnStartAmount.IsEnabled = false;
            btnInterest.IsEnabled = false;
            btnYears.IsEnabled = false;
            redError.Text = "";

        }
        // Public variables needed for program
        string sLine;
        bool Simple = false;
        bool Compound = false;
        public bool NoValue = false;
        int Years;
        float BeginValue, Interest;

        private bool Valid = false;

        public void Validation() //Checks if user has entered a float/int value and not a string value
        {
            var iValid = int.TryParse(edtOutput.Text, out int Value);

            if (iValid == true) //Validation was successful and the user can move on
            {
                Valid = true;
                redError.Text = "";
                Value = 0;
            }
            else
            {
                iValid = float.TryParse(edtOutput.Text, out float Value1); //if not int, maby float?
                if (iValid == true)
                {
                    Valid = true;
                    redError.Text = "";
                    Value1 = 0;
                }
                else
                {
                    redError.Text = "Please enter number, not a word";
                    edtOutput.Text = "";
                }
            }
        }

        public string CallValue(int iNum)
        {
            sLine = sLine + iNum.ToString();  //Adds button values to string for further claculation

            return sLine;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            edtOutput.Text = edtOutput.Text + '2';
            CallValue(2);                                 //Adds 2
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            edtOutput.Text = edtOutput.Text + '1';
            CallValue(1);                                 //Adds 1
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            edtOutput.Text = edtOutput.Text + '3';
            CallValue(3);                                 //Adds 3
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            edtOutput.Text = edtOutput.Text + '4';
            CallValue(4);                                 //Adds 4
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            edtOutput.Text = edtOutput.Text + '5';
            CallValue(5);                                 //Adds 5
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            edtOutput.Text = edtOutput.Text + '6';
            CallValue(6);                                 //Adds 6
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            edtOutput.Text = edtOutput.Text + '7';
            CallValue(7);                                 //Adds 7
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            edtOutput.Text = edtOutput.Text + '8';
            CallValue(8);                            //Adds 8
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            edtOutput.Text = edtOutput.Text + '9';
            CallValue(9);                                 //Adds 9
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            edtOutput.Text = edtOutput.Text + '0';
            CallValue(0);                                 //Adds 9
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)  //Resets all the values to its default values
        {
            edtOutput.Text = "";
            btn0.IsEnabled = false;
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            btnEqual.IsEnabled = false;
            btnStartAmount.IsEnabled = false;
            btnInterest.IsEnabled = false;
            btnYears.IsEnabled = false;
            Simple = false;
            Compound = false;
            rbSimple.IsEnabled = true;
            rbCompound.IsEnabled = true;
            BeginValue = 0;
            Interest = 0;
            sLine = "";
            Years = 0;
            redError.Opacity = 0;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            Validation();

            if (Valid == true)
            {
                CInterest Construct = new CInterest(BeginValue, Interest, Years, Simple, Compound);
                edtOutput.Text = "R " + Construct.CalculateInterest().ToString();
            }

        }

        private void rbSimple_Checked(object sender, RoutedEventArgs e)
        {
            btnStartAmount.IsEnabled = true;  //Sets User's interest option
            Compound = false;
            Simple = true;
            btn0.IsEnabled = true;
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
        }

        private void btnStartAmount_Click(object sender, RoutedEventArgs e)
        {
            Validation(); //Calls validation method
            if (Valid == true) //If validation was successful then user can continue
            {
                    BeginValue = float.Parse(edtOutput.Text);
                    btnInterest.IsEnabled = true;
                    btnStartAmount.IsEnabled = false;
                    rbSimple.IsEnabled = false;
                    rbCompound.IsEnabled = false;
                Valid = false;
            }
            else
            {
                redError.Text = "Please enter a number, not a word/letter." ;
                edtOutput.Text = "";
            }

            edtOutput.Text = "";
        }

        public int Out;

        private void btnInterest_Click(object sender, RoutedEventArgs e)
        {
            Out = int.Parse(edtOutput.Text);
            Validation();
            if ((Valid == true) || (Out < 100))
            {
                Out = int.Parse(edtOutput.Text); //Validation(Checks if user has entered the right type of data)
                if (Out < 100)
                {
                    Interest = float.Parse(edtOutput.Text);
                    btnYears.IsEnabled = true;
                    btnInterest.IsEnabled = false;
                    Valid = false;
                }
                else
                {
                    redError.Text = "If you entered a value that was above 100, please enter a value that's below 100%";
                    edtOutput.Text = "";
                }
            }
            else
            {
                redError.Text = "Please enter a number, not a word/letter.";
                edtOutput.Text = "";
            }

            edtOutput.Text = "";
        }

        private void btnYears_Click(object sender, RoutedEventArgs e)
        {
            Validation();
            if (Valid == true)
            {
                    Years = int.Parse(edtOutput.Text);
                    btnYears.IsEnabled = false;
                    btnEqual.IsEnabled = true;
                    btn0.IsEnabled = false;
                    btn1.IsEnabled = false;
                    btn2.IsEnabled = false;
                    btn3.IsEnabled = false;
                    btn4.IsEnabled = false;
                    btn5.IsEnabled = false;
                    btn6.IsEnabled = false;
                    btn7.IsEnabled = false;
                    btn8.IsEnabled = false;
                    btn9.IsEnabled = false;
            }
            else
            {
                redError.Text = "Please enter a number, not a word/letter.";
                edtOutput.Text = "";
            }
            edtOutput.Text = "";

        }

        private void btnExchange_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Homepage));
        }

        private void rbCompound_Checked(object sender, RoutedEventArgs e)
        {
            btnStartAmount.IsEnabled = true;  //Sets User's interest option
            Compound = true;
            Simple = false;
            btn0.IsEnabled = true;
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
        }
    }

    

}
