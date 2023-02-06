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

        private void ThemedWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var data = UserDataService.GetData();
            dataGridView.ItemsSource = data;
            dataView.BestFitArea = DevExpress.Xpf.Grid.BestFitArea.Rows;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (UserModel) dataGridView.SelectedItem;
            _ShowUser(selectedItem);
        }

        private void _ShowUser(UserModel user)
        {
            MessageBox.Show(String.Format("FirstName : {1},{0}LastName : {2},{0}Email : {3}",
                Environment.NewLine, user.FirstName , user.LastName , user.Email));
        }
    }
}
