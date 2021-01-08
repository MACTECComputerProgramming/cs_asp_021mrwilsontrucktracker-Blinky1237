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

namespace Cs_asp_019_Debug
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //textBoxHeight.Text = "100";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            double answer;

            try
            {
                a = int.Parse(textBoxHeight.Text);
                b = ((int)double.Parse(textBoxWidth.Text) / 2);
                c = int.Parse(textBoxWidth.Text);
                answer = a * b * c / 3;
                labelResult.Content = answer.ToString();
            }
            catch (Exception)
            {

                labelResult.Content = "Error 404Answer is unknown";
            }
           


        }
    }
}
