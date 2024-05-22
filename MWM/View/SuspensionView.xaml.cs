﻿using System;
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
using static System.Net.Mime.MediaTypeNames;

namespace Lumi.MWM.View
{
    /// <summary>
    /// Interaction logic for SuspensionView.xaml
    /// </summary>
    public partial class SuspensionView : UserControl
    {
        public SuspensionView()
        {
            InitializeComponent();
            txt.Text = System.IO.File.ReadAllText(@"c:\suspension.txt");
        }
    }
}
