
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

       
        public DateTime myFirstDate, mySecondDate;



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //helps format the phone and Social security numbers and salary
            double ss = double.Parse(textBoxSocialSecurity.Text);
            double phn = double.Parse(textBoxPhone.Text);
            //double totalSalary = double.Parse((string)labelTotalPaydue.Content);

            //Confi
            int DaysOut = Convert.ToInt32((calendarEnd.SelectedDate.Value - calendarStart.SelectedDate.Value).Days);
            
           


            //allows the user to input the requested items and will format as needed
            string result1 = string.Format("Driver - {0}", textBoxName.Text);
            string result2 = string.Format("Social Security #: {0:000-00-0000}", ss);
            string result3 = string.Format("Phone Number: {0:(000)000-0000}", phn);
            string result4 = string.Format("Total Miles:");
            string result5 = string.Format("Total # of Days out: {0} ", DaysOut);
            
         

            //adds the miles and salary together as needed
            if (!string.IsNullOrEmpty(textBoxStartMiles.Text) && !string.IsNullOrEmpty(textBoxEndMiles.Text))
            { 
            lableMilesResultNmbr.Content = (Convert.ToInt32(textBoxEndMiles.Text) - Convert.ToInt32(textBoxStartMiles.Text)).ToString();
            }
            if (!string.IsNullOrEmpty((string)lableMilesResultNmbr.Content))
            {
            }
            

                
            double salary = Convert.ToDouble((lableMilesResultNmbr.Content)) * .25;
            string result6 = string.Format("Total pay Due - {0:c}", salary);



            //Labels the driver ticket
            labelDriverResult.Content = result1;
            labelSocialSecurityResult.Content = result2;
            labelPhoneResult.Content = result3;
            labelMilesResult.Content = result4;
            labelTotalDaysout.Content = result5;
            labelTotalPaydue.Content = result6;
        }

    }

}