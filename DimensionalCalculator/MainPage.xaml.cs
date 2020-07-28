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
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            mainpage_Frame.Navigate(typeof(Homepage));
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            mainpage_Frame.Navigate(typeof(Homepage));
        }

        private void hamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            menuSplitView.IsPaneOpen = !menuSplitView.IsPaneOpen;
        }

        private void Exchange_Click(object sender, RoutedEventArgs e)
        {
            mainpage_Frame.Navigate(typeof(ExchangePage));
        }

        private void Interest_Click(object sender, RoutedEventArgs e)
        {
            mainpage_Frame.Navigate(typeof(InterestPage));
        }

        private void Mass_Click(object sender, RoutedEventArgs e)
        {
            mainpage_Frame.Navigate(typeof(MassPage));
        }

        private void BubbleSort_Click(object sender, RoutedEventArgs e)
        {
            mainpage_Frame.Navigate(typeof(BubbleSort));
        }

        private void QuickSort_Click(object sender, RoutedEventArgs e)
        {
            mainpage_Frame.Navigate(typeof(QuicksortPage));
        }
    }
}
