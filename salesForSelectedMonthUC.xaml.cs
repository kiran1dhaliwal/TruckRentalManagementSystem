using RentalManagement.Models.DB;
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

namespace RentalManagement
{
    /// <summary>
    /// Interaction logic for salesForSelectedMonthUC.xaml
    /// </summary>
    public partial class salesForSelectedMonthUC : UserControl
    {
        public salesForSelectedMonthUC()
        {
            InitializeComponent();
        }

        private void ViewSalesBtn_Click(object sender, RoutedEventArgs e)
        {
            int month = 00;
             
            if (monthComboBox.SelectedValue.Equals("January"))
            {
                month = 01;
            }
            else if(monthComboBox.SelectedValue.Equals("February"))
            {
                month = 02;
            }
            else if(monthComboBox.SelectedValue.Equals("March"))
            {
                month = 03;
            }
            else if (monthComboBox.SelectedValue.Equals("April"))
            {
                month = 04;
            }
            else if (monthComboBox.SelectedValue.Equals("May"))
            {
                month = 05;
            }
            else if (monthComboBox.SelectedValue.Equals("June"))
            {
                month = 06;
            }
            else if (monthComboBox.SelectedValue.Equals("July"))
            {
                month = 07;
            }
            else if (monthComboBox.SelectedValue.Equals("August"))
            {
                month = 08;
            }
            else if (monthComboBox.SelectedValue.Equals("September"))
            {
                month = 09;
            }
            else if (monthComboBox.SelectedValue.Equals("October"))
            {
                month = 10;
            }
            else if (monthComboBox.SelectedValue.Equals("November"))
            {
                month = 11;
            }
            else 
            {
                month = 12;
            }

            int year = int.Parse(yearComboBox.SelectedValue.ToString());
                       
            DAO db = new DAO();

            int sale = db.monthlysales(month, year);

            monthTextBox.Text = monthComboBox.SelectedValue.ToString();
            yearTextBox.Text = yearComboBox.SelectedValue.ToString();
            saleAmountTextBox.Text = sale.ToString();
            
        }
    }
}
