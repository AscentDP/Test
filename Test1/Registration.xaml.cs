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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        MainWindow auth = new MainWindow();

        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonAuth_Click(object sender, RoutedEventArgs e)
        {

            if (txbLogin.Text == "" || txbPassword.Text == "" || txbName.Text == "" || txbSurname.Text == "" || txbPatronymic.Text == "")
            {
                MessageBox.Show("Вы заполнили не все поля =(", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            Client client = new Client();
            client.Login = txbLogin.Text;
            client.Password = txbPassword.Text;
            client.Name = txbName.Text;
            client.Surname = txbSurname.Text;
            client.Patronymic = txbPatronymic.Text;

            ClassHelper.EFClass.context.Clients.Add(client);

            ClassHelper.EFClass.context.SaveChanges();
            Close();
            auth.Show();

            MessageBox.Show($"{txbName.Text}, Вы успешно зарегистрировались!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            auth.Show();
        }
    }
}
