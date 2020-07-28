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
    public sealed partial class MassPage : Page
    {
        public MassPage()
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

            rgpInput.Items.Add(new KeyValuePair<String, int>("G", 0));
            rgpInput.Items.Add(new KeyValuePair<String, int>("KG", 1));  //Adds items to the combobox on the left(Input)
            rgpInput.Items.Add(new KeyValuePair<String, int>("Ton", 2));

            rgpOutput.Items.Add(new KeyValuePair<String, int>("G", 0));
            rgpOutput.Items.Add(new KeyValuePair<String, int>("KG", 1));  //Adds items to the combobox on the right(output)
            rgpOutput.Items.Add(new KeyValuePair<String, int>("Ton", 2));

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
                redError.Text = "Please enter number, not word";
                edtOutput.Text = "";
            }
        }

        public bool InGram = false;
       public bool Inkilogram = false;
       public bool InTon = false;
       public bool OutGram = false;
       public bool Outkilogram = false;
       public bool OutTon = false;
       public bool Option1 = false;
       public bool Option2 = false;

        public float input, output, Answer;
        string Input, Output;

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Homepage));
        }

        string sLine;

        public void EnableButtons()
        {
            if ((Option1 == true) && (Option2 == true))
            {
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
                btnConvert.IsEnabled = true;
                edtOutput.IsEnabled = true;

            }
            
        }

        public void MassConvert() //Calculates the answer
        {
            if (InGram == true) //If the user chose gram in the first combobox(Input), then:
            {
                if (OutGram == true) 
                {
                    input = float.Parse(edtOutput.Text);
                    Answer = input;
                    edtOutput.Text = Input + input.ToString() + " = " + "\n" + Output + Answer.ToString(); //converts gram to gram
                }

                else if (Outkilogram == true)
                {
                    input = float.Parse(edtOutput.Text);
                    Answer = input / 1000;
                    edtOutput.Text = Input + input.ToString() + " = " + "\n" + Output + Answer.ToString();  //converts gram to kilogram
                }

                else if (OutTon == true)
                {
                    input = float.Parse(edtOutput.Text);
                    Answer = input / 1000000;
                    edtOutput.Text = Input + input.ToString() + " = " + "\n" + Output + Answer.ToString();  //converts gram to Ton
                }
            }

           else if (Inkilogram == true)  //If the user chose kilogram in the first combobox(Input), then:
            {
                if (OutGram == true)
                {
                    input = float.Parse(edtOutput.Text);
                    Answer = input * 1000;
                    edtOutput.Text = Input + input.ToString() + " = " + "\n" + Output + Answer.ToString(); //converts kilogram to gram
                }

                else if (Outkilogram == true)
                {
                    input = float.Parse(edtOutput.Text);
                    Answer = input;
                    edtOutput.Text = Input + input.ToString() + " = " + "\n" + Output + Answer.ToString();  //converts kilogram to kilogram
                }

                else if (OutTon == true)
                {
                    input = float.Parse(edtOutput.Text);
                    Answer = input / 1000;
                    edtOutput.Text = Input + input.ToString() + " = " + "\n" + Output + Answer.ToString();  //converts kilogram to Ton
                }

             else  if (InTon == true)  //If the user chose Ton in the first combobox(Input), then:
                {
                    if (OutGram == true)
                    {
                        input = float.Parse(edtOutput.Text);
                        Answer = input * 1000000;
                        edtOutput.Text = Input + input.ToString() + " = " + "\n" + Output + Answer.ToString();  //converts Ton to Gram
                    }

                   else if (Outkilogram == true)
                    {
                        input = float.Parse(edtOutput.Text);
                        Answer = input * 1000;
                        edtOutput.Text = Input + input.ToString() + " = " + "\n" + Output + Answer.ToString();  //converts Ton to kilogram
                    }

                   else if (OutTon == true)
                    {
                        input = float.Parse(edtOutput.Text);
                        Answer = input;
                        edtOutput.Text = Input + input.ToString() + " = " + "\n" + Output + Answer.ToString();  //converts Ton to ton
                    }
                }
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

            bool InGram = false;  //resets variables to default values
            bool Inkilogram = false;
            bool InTon = false;
            bool OutGram = false;
            bool Outkilogram = false;
            bool OutTon = false;
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
            switch (i)  //Checks which option the user wants to convert
            {
                case 0:  //Gram
                        InGram = true;
                        Inkilogram = false;
                        InTon = false;
                        Input = "Gram: ";
                        
                        Option1 = true;
                        break;
                case 1:  //Kilogram
                        InGram = false;
                        Inkilogram = true;
                        InTon = false;
                        Input = "Kilogram: ";
                        
                        Option1 = true;
                        break;
                case 2:  //Ton
                        InGram = false;
                        Inkilogram = false;
                        InTon = true;
                        Input = "Ton: ";
          
                        Option1 = true;
                        break;
                    
            }
        }

        private void rgpOutput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int k = rgpOutput.SelectedIndex;
            switch (k)  //Checks which option the user wants to convert the first option into
            {
                case 0:  //Gram
                        OutGram = true;
                        Outkilogram = false;
                        OutTon = false;
                        Output = "Gram: ";
                        Option2 = true;
                        break;
                case 1:  //Kilogram
                        OutGram = false;
                        Outkilogram = true;
                        OutTon = false;
                        Output = "Kilogram: ";
                        Option2 = true;
                        break;
                case 2:  //Ton
                        OutGram = false;
                        Outkilogram = false;
                        OutTon = true;
                        Output = "Ton: ";
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
                MassConvert();
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
            CallValue(0);                                 //Adds 9
        }
    }
}
