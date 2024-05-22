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
    /// Interaction logic for ManufacturersView.xaml
    /// </summary>
    public partial class ManufacturersView : UserControl
    {
        public ManufacturersView()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string password = "Lumi123";
            string userInput = MyTextBox.Text.ToString();
            if (userInput==password)
            {
                Content = new InputView();
            }
            else
            {
                MyTextBox.Clear();
                MessageBox.Show("Wrong password!");

            }

        }
    }
}
