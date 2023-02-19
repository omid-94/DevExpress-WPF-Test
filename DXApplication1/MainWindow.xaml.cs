using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DXApplication1.Data.Services;
using DXApplication1.Data.Models;
using DXApplication1.Windows;

namespace DXApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBasicDataGrid_Click(object sender, RoutedEventArgs e)
        {
            var window = new BasicDataGrid();
            window.ShowDialog();
        }

        private void btnHamburgerMenu_Click(object sender, RoutedEventArgs e)
        {
            var window = new HamburgerMenu();
            window.ShowDialog();
        }
    }
}
