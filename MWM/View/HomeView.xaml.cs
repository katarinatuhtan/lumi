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

namespace Lumi.MWM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }
        private void Button_Click_Products(object sender, RoutedEventArgs e)
        {
            Content = new ProductsView();
        }

        private void Button_Click_About(object sender, RoutedEventArgs e)
        {
            Content = new AboutView();
        }

        private void Button_Click_Manufacturers(object sender, RoutedEventArgs e)
        {
            Content = new ManufacturersView();
        }
    }
}
