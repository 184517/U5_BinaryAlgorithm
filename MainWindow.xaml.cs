/*Jordan Ross
May 27, 2019
Binary with algorithm
*/
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

namespace U5_BinaryAlgorithm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            double inputValue = 0;
            double.TryParse(input, out inputValue);
            string output = "";

            for (int i = 4; i >= 0; i--)
            {
                double temp = Math.Pow(2, i);
                if (inputValue >= temp)
                {
                    inputValue -= temp;
                    output = output + "1";

                }
                else
                {
                    output = output + "0";
                }
                 
            }
            MessageBox.Show(output);
        }
    }
}
