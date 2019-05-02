using SecurityApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using SecurityApp.DataAcsess;
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
using Models;

namespace SecurityApp
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        private void registerButtonClick(object sender, RoutedEventArgs e)
        {
            User user = new User();
            string login = loginBox.Text;
            string password = passwordBox.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            else
            {
                using (var context = new SecurityContext())
                {
                    List<User> users = context.Users.Where(u => u.Login == login).ToList();
                    if (users.Count<1)
                    {
                        user.Login = login;
                        user.Password = CryptoService.HashPassword(password);
                        context.Users.Add(user);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Логин уже существует");
                    }
                }
            }
        }

        private void newEnterWindowButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow enterWindow = new MainWindow();
            enterWindow.Show();
            this.Close();
        }
    }
}
