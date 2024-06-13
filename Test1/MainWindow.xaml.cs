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
using Test1.DB;

namespace Test1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBase dataBase = new DataBase();

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void ButtonAuth_Click(object sender, RoutedEventArgs e)
        {
            var auth = ClassHelper.EFClass.context.Clients.ToList().Where(i => i.Login == txbLogin.Text && i.Password == txbPassword.Text).FirstOrDefault();

            if (auth != null)
            {
                List listPage = new List();
                MessageBox.Show("Вы вошли под именем " + auth.Name + ".", "Поздравляем!", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();

                listPage.Show();
            }
            else
            {
                MessageBox.Show("Вы ввели неверные данные. Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void NewAccount_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            Close();

            registration.Show();
        }
    }
}
