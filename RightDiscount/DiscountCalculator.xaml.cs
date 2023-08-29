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
    /// Interaction logic for DiscountCalculator.xaml
    /// </summary>
    public partial class DiscountCalculator : Page
    {
        double price2, volume2, discount5, result2;
        public DiscountCalculator()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            //Calculates and shows results from user input
            price2 = Convert.ToDouble(priceInput.Text);
            volume2 = Convert.ToDouble(volumeInput2.Text);
            discount5 = Convert.ToDouble(discountInput.Text);
            result2 = (100 - discount5) / 100* price2 * volume2;
            result2 = Math.Round(result2, 2);
            resultOutput.Text = "Reduced price is " + result2 + "€";
        }
    }
}
