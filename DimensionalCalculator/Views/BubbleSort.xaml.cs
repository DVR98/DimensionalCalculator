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
    public sealed partial class BubbleSort : Page
    {
        public BubbleSort()
        {
            this.InitializeComponent();
            btnSort.IsEnabled = false;
        }

        int[] Array20 = new int[20];  //Creates the array

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            Random rnd = new Random();  //Allows the user to populate random generated numbers

            edtAUS.Text = "Unsorted: ";

            for (i = 0; i < Array20.Length; i++) //Populates the array with random generated numbers
            {
                Array20[i] = rnd.Next(0,99);
                edtAUS.Text = edtAUS.Text + Array20[i].ToString() + ", ";
            }

            btnSort.IsEnabled = true; //After population, the user can sort the array
        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            int i = 0; //two counters for two loops
            int k = 0;
            int Temporary = 0; //Will contain a temporary value if switching is required

            for (i = 0; i < (Array20.Length - 1); i++) //bubblesort small to big
            {
                for (k = (i+1); k < Array20.Length; k++)
                {
                    if (Array20[i] > Array20[k]) //if the value is bigger than the next value in the list:
                    {
                        Temporary = Array20[i]; //Places the bigger value in temp
                        Array20[i] = Array20[k]; //Replaces the smaller value with bigger
                        Array20[k] = Temporary; //Places the smaller value with bigger
                    }
                }
            }

            i = 0;

            edtAS.Text = "Sorted: ";

            for (i = 0; i < Array20.Length; i++)
            {
                edtAS.Text = edtAS.Text + Array20[i].ToString() + ", "; //Displays the sorted array.
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e) //Resets variables and items to default values
        {
            edtAS.Text = "";
            edtAUS.Text = "";
            btnSort.IsEnabled = false; 

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)  //Navigates to home
        {
            Frame.Navigate(typeof(Homepage)); 
        }
    }
}
