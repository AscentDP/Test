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
using System.Windows.Shapes;
using Test1.DB;

namespace Test1
{
    /// <summary>
    /// Логика взаимодействия для List.xaml
    /// </summary>
    public partial class List : Window
    {
        public List()
        {
            InitializeComponent();
            GetServiceList();
        }

        public void GetServiceList()
        {
            List<Client> clientList = new List<Client>();
            clientList = ClassHelper.EFClass.context.Clients.ToList();

            lvService.ItemsSource = clientList;
        }

        public void BtnEditProduct_Click(object sender, RoutedEventArgs e)
        {
        }

        public void BtnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
        }

        private void lvService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
