using Lumi.Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Xml.Linq;
using System.Text.Json;


namespace Lumi.MWM.View
{
    /// <summary>
    /// Interaction logic for InputView.xaml
    /// </summary>
    public partial class InputView : UserControl
    {
        public InputView()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (Category.Text == "suspension")
            {
                string strFileContents =
               "\nName: " + Name.Text + "\nCatalogueID:  " + CatID.Text + "\nCategory:  " + Category.Text + "\nManufacturer: " + ManID.Text + "\nDescription: " + Desc.Text + "\n";

                string strFullFilename = (@"c:\suspension.txt");

                File.AppendAllText(strFullFilename, strFileContents);
                Name.Clear();
                CatID.Clear();
                Category.Clear();
                ManID.Clear();
                Desc.Clear();
                MessageBox.Show("Product added!");

            }
            else if (Category.Text == "ceiling")
            {
                string strFileContents =
               "\nName: " + Name.Text + "\nCatalogueID:  " + CatID.Text + "\nCategory:  " + Category.Text + "\nManufacturer: " + ManID.Text + "\nDescription: " + Desc.Text + "\n";

                string strFullFilename = (@"c:\ceiling.txt");

                File.AppendAllText(strFullFilename, strFileContents);
                Name.Clear();
                CatID.Clear();
                Category.Clear();
                ManID.Clear();
                Desc.Clear();
                MessageBox.Show("Product added!");

            }

            else if (Category.Text == "table")
            {
                string strFileContents =
               "\nName: " + Name.Text + "\nCatalogueID:  " + CatID.Text + "\nCategory:  " + Category.Text + "\nManufacturer: " + ManID.Text + "\nDescription: " + Desc.Text + "\n";

                string strFullFilename = (@"c:\table.txt");

                File.AppendAllText(strFullFilename, strFileContents);
                Name.Clear();
                CatID.Clear();
                Category.Clear();
                ManID.Clear();
                Desc.Clear();
                MessageBox.Show("Product added!");

            }
            else if (Category.Text == "children")
            {
                string strFileContents =
               "\nName: " + Name.Text + "\nCatalogueID:  " + CatID.Text + "\nCategory:  " + Category.Text + "\nManufacturer: " + ManID.Text + "\nDescription: " + Desc.Text + "\n";

                string strFullFilename = (@"c:\children.txt");

                File.AppendAllText(strFullFilename, strFileContents);
                Name.Clear();
                CatID.Clear();
                Category.Clear();
                ManID.Clear();
                Desc.Clear();
                MessageBox.Show("Product added!");

            }
            else if (Category.Text == "picture")
            {
                string strFileContents =
               "\nName: " + Name.Text + "\nCatalogueID:  " + CatID.Text + "\nCategory:  " + Category.Text + "\nManufacturer: " + ManID.Text + "\nDescription: " + Desc.Text + "\n";

                string strFullFilename = (@"c:\picture.txt");

                File.AppendAllText(strFullFilename, strFileContents);
                Name.Clear();
                CatID.Clear();
                Category.Clear();
                ManID.Clear();
                Desc.Clear();
                MessageBox.Show("Product added!");

            }
            else if (Category.Text == "outdoor")
            {
                string strFileContents =
               "\nName: " + Name.Text + "\nCatalogueID:  " + CatID.Text + "\nCategory:  " + Category.Text + "\nManufacturer: " + ManID.Text + "\nDescription: " + Desc.Text + "\n";

                string strFullFilename = (@"c:\outdoor.txt");

                File.AppendAllText(strFullFilename, strFileContents);
                Name.Clear();
                CatID.Clear();
                Category.Clear();
                ManID.Clear();
                Desc.Clear();
                MessageBox.Show("Product added!");

            }
            else if (Category.Text == "floor")
            {
                string strFileContents =
               "\nName: " + Name.Text + "\nCatalogueID:  " + CatID.Text + "\nCategory:  " + Category.Text + "\nManufacturer: " + ManID.Text + "\nDescription: " + Desc.Text + "\n";

                string strFullFilename = (@"c:\floor.txt");

                File.AppendAllText(strFullFilename, strFileContents);
                Name.Clear();
                CatID.Clear();
                Category.Clear();
                ManID.Clear();
                Desc.Clear();
                MessageBox.Show("Product added!");

            }
            else if (Category.Text == "wall")
            {
                string strFileContents =
               "\nName: " + Name.Text + "\nCatalogueID:  " + CatID.Text + "\nCategory:  " + Category.Text + "\nManufacturer: " + ManID.Text + "\nDescription: " + Desc.Text + "\n";

                string strFullFilename = (@"c:\wall.txt");

                File.AppendAllText(strFullFilename, strFileContents);
                Name.Clear();
                CatID.Clear();
                Category.Clear();
                ManID.Clear();
                Desc.Clear();
                MessageBox.Show("Product added!");
            }
            else
            {
                Name.Clear();
                CatID.Clear();
                Category.Clear();
                ManID.Clear();
                Desc.Clear();
                MessageBox.Show("Incorrect category!");
            }


        }
        


    }
}
