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
    /// Interaction logic for salesBetweenSelectedDatesUC.xaml
    /// </summary>
    public partial class salesBetweenSelectedDatesUC : UserControl
    {
        public salesBetweenSelectedDatesUC()
        {
            InitializeComponent();
        }

        private void ShowSalesBtn_Click(object sender, RoutedEventArgs e)
        {
            DateTime startDate = startDatePicker.SelectedDate.Value;
            DateTime endDate = endDatePicker.SelectedDate.Value;

            DAO db = new DAO();
            int sales = db.salesBetweenSelectedDates(startDate,endDate);

            startDateTextBox.Text = startDatePicker.SelectedDate.ToString();
            endDateTextBox.Text = endDatePicker.SelectedDate.ToString();
            saleAmountTextBox.Text = sales.ToString();
        }
    }
}
