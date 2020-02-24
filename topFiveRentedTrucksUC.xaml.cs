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
    /// Interaction logic for topFiveRentedTrucksUC.xaml
    /// </summary>
    public partial class topFiveRentedTrucksUC : UserControl
    {
        System.Windows.Data.CollectionViewSource myCollectionViewSoure;

        public topFiveRentedTrucksUC()
        {
            InitializeComponent();
        }

        private void ShowTopFiveTrucksBtn_Click(object sender, RoutedEventArgs e)
        {
            DAO db = new DAO();
            List<TruckData> values = new List<TruckData>();
            values = db.topFiveRentedTrucks();

            myCollectionViewSoure = (System.Windows.Data.CollectionViewSource)this.Resources["truckDataDataGrid"];
            myCollectionViewSoure.Source = values;
        }

    }
}
