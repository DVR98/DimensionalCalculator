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
    public sealed partial class ExchangePage : Page
    {
        public ExchangePage()
        {
            this.InitializeComponent();

            btn0.IsEnabled = false;     //Unables buttons untill user has selected conversion options
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            btnConvert.IsEnabled = false;

            rgpInput.Items.Add(new KeyValuePair<String, int>("Dollar", 0));
            rgpInput.Items.Add(new KeyValuePair<String, int>("Rand", 1));  //Adds options to the combobox on the left
            rgpInput.Items.Add(new KeyValuePair<String, int>("Pound", 2));
            rgpInput.Items.Add(new KeyValuePair<String, int>("Euro", 3));

            rgpOutput.Items.Add(new KeyValuePair<String, int>("Dollar", 0));
            rgpOutput.Items.Add(new KeyValuePair<String, int>("Rand", 1));  //Adds options to the combobox on the right
            rgpOutput.Items.Add(new KeyValuePair<String, int>("Pound", 2));
            rgpOutput.Items.Add(new KeyValuePair<String, int>("Euro", 3));
        }

        private bool Valid = false;

        public void Validation()
        {
            var iValid = int.TryParse(edtOutput.Text, out int Value);

            if (iValid == true)
            {
                Valid = true;
                redError.Text = "";
            }
            else
            {
                redError.Text = "Please enter integer value, not string(Numbers, not letters)";
                edtOutput.Text = "";
            }
        }

        public bool InDollar = false;  //Sets the variables to default value
        public bool InRand = false;
        public bool InPound = false;
        public bool InEuro = false;
        public bool OutDollar = false;
        public bool OutRand = false;
        public bool OutPound = false;
        public bool OutEuro = false;
        public bool Option1 = false;
        public bool Option2 = false;

        public double input, output;
        string Input;

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Homepage));  //Returns to home page
        }

        string sLine;

        public void EnableButtons()  //Checks if user has chosen two converting options that is needed
        {
            if ((Option1 == true) && (Option2 == true))
            {
                btn0.IsEnabled = true;  //Enables buttons for further calculation if the user has chosen two converting options
                btn1.IsEnabled = true;
                btn2.IsEnabled = true;
                btn3.IsEnabled = true;
                btn4.IsEnabled = true;
                btn5.IsEnabled = true;
                btn6.IsEnabled = true;
                btn7.IsEnabled = true;
                btn8.IsEnabled = true;
                btn9.IsEnabled = true;
                btnConvert.IsEnabled = true;
                edtOutput.IsEnabled = true;

            }

        }

        public string CallValue(int iNum)
        {
            sLine = sLine + iNum.ToString();

            return sLine;  //Adds typed in numbers to a string
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            btn0.IsEnabled = false;     //Unables buttons untill user has selected conversion options
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            btnConvert.IsEnabled = false;
            edtOutput.IsEnabled = false;
            btnStart.IsEnabled = true;
            edtOutput.Text = "";
            bool Option1 = false;
            bool Option2 = false;


        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {   

            EnableButtons();
            
        }

        private void rgpInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = rgpInput.SelectedIndex;
            switch (i)  //Checks which option the user wants to convert from:
            {
                case 0:  //Dollar
                    InDollar = true;
                    InEuro = false;
                    InRand = false;
                    InPound = false;

                    Option1 = true;
                    break;
                case 1:  //Rand
                    InDollar = false;
                    InEuro = false;
                    InRand = true;
                    InPound = false;

                    Option1 = true;
                    break;
                case 2:  //Pound
                    InDollar = false;
                    InEuro = false;
                    InRand = false;
                    InPound = true;

                    Option1 = true;
                    break;
                case 3:  //Euro
                    InDollar = false;
                    InEuro = true;
                    InRand = false;
                    InPound = false;

                    Option1 = true;
                    break;


            }
        }

        private void rgpOutput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int k = rgpOutput.SelectedIndex;
            switch (k)  //Checks which option the user wants to convert the first option into
            {
                case 0:  //Dollar
                    OutDollar = true;
                    OutEuro = false;
                    OutRand = false;
                    OutPound = false;
                    Option2 = true;
                    break;
                case 1:  //Rand
                    OutDollar = false;
                    OutEuro = false;
                    OutRand = true;
                    OutPound = false;

                    Option2 = true;
                    break;
                case 2:  //Pound
                    OutDollar = false;
                    OutEuro = false;
                    OutRand = false;
                    OutPound = true;

                    Option2 = true;
                    break;

                case 3:  //Euro
                    OutDollar = false;
                    OutEuro = true;
                    OutRand = false;
                    OutPound = false;

                    Option2 = true;
                    break;
            }
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            btn0.IsEnabled = false;     //Unables buttons untill user has selected conversion options
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            btnStart.IsEnabled = false;
            btnConvert.IsEnabled = false;

            Validation();

            if (Valid == true)
            {
                Input = edtOutput.Text;
                CExchange Convert = new CExchange(InDollar, InRand, InPound, InEuro, OutDollar, OutRand, OutPound, OutEuro, double.Parse(Input));
                edtOutput.Text = Convert.Convertion();
            }
            else
            {
                redError.Text = "Please enter a number, not a word/letter.";
                edtOutput.Text = "";
            }
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
            CallValue(0);                                 //Adds 0
        }
    }
}
    

