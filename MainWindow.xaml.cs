using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Register
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string price;
        public MainWindow()
        {
            InitializeComponent();
        }

        
        // Button Controls

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn1.Content;
            priceCount.Text = price;

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn2.Content;
            priceCount.Text = price;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn3.Content;
            priceCount.Text = price;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn4.Content;
            priceCount.Text = price;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn5.Content;
            priceCount.Text = price;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn6.Content;
            priceCount.Text = price;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn7.Content;
            priceCount.Text = price;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn8.Content;
            priceCount.Text = price;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn9.Content;
            priceCount.Text = price;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn0.Content;
            priceCount.Text = price;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            price = price + btn0.Content;
            priceCount.Text = price;
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            price = price.Substring(0, 0);
            priceCount.Text = price;
        }
            // btnDot to be removed in favour of auto function in future
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            price = price + btnDot.Content;
            priceCount.Text = price;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            price = price.Substring(0, price.Length - 1);
            priceCount.Text = price;
        }
    }
}
