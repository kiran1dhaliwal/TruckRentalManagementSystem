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
    /// Interaction logic for leastFiveRentedTrucks.xaml
    /// </summary>
    public partial class leastFiveRentedTrucks : UserControl
    {
        public leastFiveRentedTrucks()
        {
            InitializeComponent();
        }

        private void ShowLeastRentedTrucksBtn_Click(object sender, RoutedEventArgs e)
        {
            DAO db = new DAO();
            
            System.Windows.Data.CollectionViewSource myCollectionViewSoure = (System.Windows.Data.CollectionViewSource)this.Resources["truckDataDataGrid"];
            myCollectionViewSoure.Source = db.leastFiveRentedTrucks(); 
        }
    }
}
