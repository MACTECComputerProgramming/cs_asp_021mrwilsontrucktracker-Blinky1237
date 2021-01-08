
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

namespace _21_challenge
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double ss = double.Parse(textBoxSocialSecurity.Text);
            double phn = double.Parse(textBoxPhone.Text);

            string result1 = string.Format("Driver - {0}", textBoxName.Text);
            string result2 = string.Format("Social Security #: {0:000-00-0000}", ss);
            string result3 = string.Format("Phone Number: {0:(000)000-0000}", phn);
            string result4 = string.Format("Total Miles:");

            //double a = double.Parse(textBoxStartMiles.Text);
            //double b = double.Parse(textBoxEndMiles.Text);
            //double.


            
            if (!string.IsNullOrEmpty(textBoxStartMiles.Text) && !string.IsNullOrEmpty(textBoxEndMiles.Text))
            lableMilesResultNmbr.Content= (Convert.ToInt32(textBoxStartMiles.Text) + Convert.ToInt32(textBoxEndMiles.Text)).ToString();
            
            
            

            //Labels the driver ticket
            labelDriverResult_Copy.Content = result1;
            labelSocialSecurityResult.Content = result2;
            labelPhoneResult.Content = result3;
            labelMilesResult.Content = result4;
       

        }

    }

}