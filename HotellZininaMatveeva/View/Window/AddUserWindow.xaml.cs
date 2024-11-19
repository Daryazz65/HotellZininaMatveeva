using HotellZininaMatveeva.AppData;
using HotellZininaMatveeva.Model;
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

namespace HotellZininaMatveeva.View.Window
{
    /// <summary>
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            AddUser();
        }

        public void AddUser()
        {
            try
            {
                User newUser = new User()
                {
                    FullName = FullnameTb.Text,
                    Login = LoginTb.Text,
                    Password = PasswordPb.Password,
                    RegistrationDate = DateTime.Now.Date,
                    IsActivated = false,
                    IsBlocked = false,
                    RoleId = 2
                };

                App.context.User.Add(newUser);
                App.context.SaveChanges();

                FeedBack.Information("Пользователь успешно добавлен!");

                DialogResult = true;
            }
            catch (Exception ex)
            {
                FeedBack.Error($"Ошибка при добавлении пользователя. {ex.Message}");
            }
        }
                      
    }
}
