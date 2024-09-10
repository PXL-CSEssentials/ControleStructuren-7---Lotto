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

namespace ControleStructuren_7___Lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            // Eerst resultaat textbox leegmaken
            resultTextBox.Text = string.Empty;

            const int NumberOfLottoNumbers = 6;
            const int MinLottoNumber = 1;
            const int MaxLottoNumber = 45;

            for (int i = 1; i <= NumberOfLottoNumbers; i++)
            {
                int lottoNumber = _random.Next(MinLottoNumber, MaxLottoNumber + 1);
                resultTextBox.Text += $"Getal {i}: {lottoNumber}\r\n";
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            //resultTextBox.Text = string.Empty;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
