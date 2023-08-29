using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RightDiscount
{
    /// <summary>
    /// Interaction logic for RightDiscountHome.xaml
    /// </summary>
    public partial class RightDiscountHome : Page
    {
        public RightDiscountHome()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // View Customers and Prices Page
            CustomerAndPriceList customerAndPrice = new CustomerAndPriceList();
            this.NavigationService.Navigate(customerAndPrice);

        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // View Calculator Page
            DiscountCalculator calculator = new DiscountCalculator();
            this.NavigationService.Navigate(calculator);

        }

        private void Button1_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
