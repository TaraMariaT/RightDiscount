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
    /// Interaction logic for CustomerAndPriceList.xaml
    /// </summary>
    public partial class CustomerAndPriceList : Page
    {
        readonly double furniturePrice1 = 45.75;
        readonly double furniturePrice2 = 75.99;
        readonly double furniturePrice3 = 50;
        readonly double furniturePrice4 = 61.20;
        readonly double discount1 = 5;
        readonly double discount2 = 10;
        readonly double discount3 = 25;
        readonly double discount4 = 50;
        double result1, volume1;

        public CustomerAndPriceList()
        {
            InitializeComponent();
        }
        //Showing info about product prices or contracts with customers when radio button is clicked
        private void RdButton1_Click(object sender, EventArgs e)
        {
           ShowPrice1.Text = "" + furniturePrice1 + "€";
        }
        private void RdButton2_Click(object sender, EventArgs e)
        {
            ShowPrice1.Text = "" + furniturePrice2 + "€";
        }
        private void RdButton3_Click(object sender, EventArgs e)
        {
            ShowPrice1.Text = "" + furniturePrice3 + "€";
        }
        private void RdButton4_Click(object sender, EventArgs e)
        {
            ShowPrice1.Text = "" + furniturePrice4 + "€";
        }
        private void RdButton5_Click(object sender, EventArgs e)
        {
            ShowContract.Text = "Sopimus: Asiakas saa 10% alennuksen, kun he ostavat yli 10 kappaletta " + "\n" + "tuotteita ja 25% allennuksen, kun he ostavat vähintään 20 kappaletta.";
        }
        private void RdButton6_Click(object sender, EventArgs e)
        {
            ShowContract.Text = "Sopimus: Asiakas saa 50% alennuksen, kun he ostavat ainakin 50 kappaletta " + "\n" + "tuotteita.";
        }
        private void RdButton7_Click(object sender, EventArgs e)
        {
            ShowContract.Text = "Sopimus: Asiakas saa 5% alennuksen, kun he ostavat ainakin 15 kappaletta " + "\n" + "tuotteita.";
        }
        //all radio buttons done
        private void Button3_Click(object sender, EventArgs e)
        {
            //if customer 1 is selected
            if (RdButton1.IsChecked == true && RdButton5.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 <= 10)
                {
                    result1 = volume1 * furniturePrice1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 > 10 && volume1 < 20)
                {
                    result1 = (100 - discount2) / 100 * furniturePrice1 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 20)
                {
                    result1 = (100 - discount3) / 100 * furniturePrice1 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            else if (RdButton2.IsChecked == true && RdButton5.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 <= 10)
                {
                    result1 = volume1 * furniturePrice2;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 > 10 && volume1 < 20)
                {
                    result1 = (100 - discount2) / 100 * furniturePrice2 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 20)
                {
                    result1 = (100 - discount3) / 100 * furniturePrice2 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            else if (RdButton3.IsChecked == true && RdButton5.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 <= 10)
                {
                    result1 = volume1 * furniturePrice3;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 > 10 && volume1 < 20)
                {
                    result1 = (100 - discount2) / 100 * furniturePrice3 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 20)
                {
                    result1 = (100 - discount3) / 100 * furniturePrice3 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            else if (RdButton4.IsChecked == true && RdButton5.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 <= 10)
                {
                    result1 = volume1 * furniturePrice4;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 > 10 && volume1 < 20)
                {
                    result1 = (100 - discount2) / 100 * furniturePrice4 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 20)
                {
                    result1 = (100 - discount3) / 100 * furniturePrice4 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            //if customer 2 is selected
            else if (RdButton1.IsChecked == true && RdButton6.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 < 50)
                {
                    result1 = volume1 * furniturePrice1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 50)
                {
                    result1 = (100 - discount4) / 100 * furniturePrice1 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            else if (RdButton2.IsChecked == true && RdButton6.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 < 50)
                {
                    result1 = volume1 * furniturePrice2;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 50)
                {
                    result1 = (100 - discount4) / 100 * furniturePrice2 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            else if (RdButton3.IsChecked == true && RdButton6.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 < 50)
                {
                    result1 = volume1 * furniturePrice3;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 50)
                {
                    result1 = (100 - discount4) / 100 * furniturePrice3 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            else if (RdButton4.IsChecked == true && RdButton6.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 < 50)
                {
                    result1 = volume1 * furniturePrice4;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 50)
                {
                    result1 = (100 - discount4) / 100 * furniturePrice4 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            //if customer 3 is selected
            else if (RdButton1.IsChecked == true && RdButton7.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 < 15)
                {
                    result1 = volume1 * furniturePrice1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 15)
                {
                    result1 = (100 - discount1) / 100 * furniturePrice1 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            else if (RdButton2.IsChecked == true && RdButton7.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 < 15)
                {
                    result1 = volume1 * furniturePrice2;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 15)
                {
                    result1 = (100 - discount1) / 100 * furniturePrice2 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            else if (RdButton3.IsChecked == true && RdButton7.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 < 15)
                {
                    result1 = volume1 * furniturePrice3;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 15)
                {
                    result1 = (100 - discount1) / 100 * furniturePrice3 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            else if (RdButton4.IsChecked == true && RdButton7.IsChecked == true)
            {
                volume1 = Convert.ToDouble(volumeInput1.Text);
                if (volume1 < 15)
                {
                    result1 = volume1 * furniturePrice4;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
                else if (volume1 >= 15)
                {
                    result1 = (100 - discount1) / 100 * furniturePrice4 * volume1;
                    result1 = Math.Round(result1, 2);
                    ShowPrice2.Text = "" + result1 + "€";
                }
            }
            //If user hasn't chosen option from both radio button selection, they get an error message
            else
            {
                MessageBox.Show("Error: Choose item, customer and enter item count.");
                return;
            }
        }
    }
}
