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
    public sealed partial class QuicksortPage : Page
    {
        public QuicksortPage()
        {
            this.InitializeComponent();
            btnSort.IsEnabled = false;
        }

        string[] arrQuick = new string[40];

        public static void Quicksort(IComparable[] array, int passedLeft, int passedRight)
        {
            int left = passedLeft, right = passedRight;
            IComparable pivot = array[(passedLeft + passedRight) / 2];

            while (left <= right)
            {
                // Go from left to pivot 
                
                while (array[left].CompareTo(pivot) < 0) // If the value is less than pivot, test next value
                {
                    left++;
                }
                // If it is larger than pivot, exit loop

                // Go from right to left
                while (array[right].CompareTo(pivot) > 0) // If the value is larger than pivot, test next value
                {
                    right--;
                }
                // If it is smaller than pivot, exit loop

                
                if (left <= right) // If left <= right (i.e. pivot was not reached above), swap values
                {
                    IComparable temp = array[left]; 
                    array[left] = array[right];
                    array[right] = temp; // Swap

                    left++;
                    right--;
                }
            }

            // Recursive calls
            if (passedLeft < right)  // Recursive calls
            {
                Quicksort(array, passedLeft, right);
            }

            if (left < passedRight)
            {
                Quicksort(array, left, passedRight);
            }
        }

            private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            int swap;
            swap = 0;
                
            Quicksort(arrQuick, 0, arrQuick.Length - 1); //Calls the method Quicksort to sort the array 

            for (int i = 0; i <= 39; i++)
            {
                edtAS.Text += arrQuick[i] + ", "; // adding all the numbers to an string to display
            }
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            btnSort.IsEnabled = true;
            string sLine = "";
            Random r = new Random();
            for (int i = 0; i <= 39; i++)  //populating the array with 40 random numbers
            {
                sLine = (r.Next(10, 100)).ToString();
                arrQuick[i] = sLine;
            }

            for (int i = 0; i <= 39; i++)
            {
                edtAUS.Text += arrQuick[i] + ", "; // adding all the numbers to an string to display
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            edtAUS.Text = "";
            edtAS.Text = "";
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Homepage));
        }
    }
}
