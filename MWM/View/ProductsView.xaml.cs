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
    /// Interaction logic for ProductsView.xaml
    /// </summary>
    public partial class ProductsView : UserControl
    {
        public ProductsView()
        {
            InitializeComponent();
        }

        private void Button_ClickSuspension(object sender, RoutedEventArgs e)
        {
            Content = new SuspensionView();
        }

        private void Button_ClickCeiling(object sender, RoutedEventArgs e)
        {
            Content = new CeilingView();
        }

        private void Button_ClickWall(object sender, RoutedEventArgs e)
        {
            Content = new WallView();
        }

        private void Button_ClickFloor(object sender, RoutedEventArgs e)
        {
            Content = new FloorView();
        }

        private void Button_ClickTable(object sender, RoutedEventArgs e)
        {
            Content = new TableView();
        }

        private void Button_ClickChildren(object sender, RoutedEventArgs e)
        {
            Content = new ChildrenView();
        }

        private void Button_ClickPicture(object sender, RoutedEventArgs e)
        {
            Content = new PictureView();
        }

        private void Button_ClickOutdoor(object sender, RoutedEventArgs e)
        {
            Content = new OutdoorView();
        }
    }
}
