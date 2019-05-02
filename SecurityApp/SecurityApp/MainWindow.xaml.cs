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
using SecurityApp.DataAcsess;
using SecurityApp.Services;

namespace SecurityApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void signInButtonClick(object sender, RoutedEventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            using(var context=new SecurityContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Login == login);
                if(user==null||!CryptoService.VerifyPassword(password, user.Password))
                {
                    MessageBox.Show("Введен неправильный логин или пароль");
                }
                else
                {
                    MessageBox.Show("Вход выполнен Успешно!");
                }
            }
        }
        private void  newRegisterWindowButtonClick(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }
    }
}
