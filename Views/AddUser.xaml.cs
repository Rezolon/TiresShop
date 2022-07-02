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
using TiresShopApplication.DbClasses;

namespace TiresShopApplication.Views
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (UserDbContext db = new())
            {
                var count = db.User.Count(x => x.login == AddLogin.Text);
            if (AddLogin.Text == "" && AddPassword.Text == "" && Type_user.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else if(AddLogin.Text == "")
            {
                MessageBox.Show("Введите логин!");
            }
            else if (AddPassword.Text == "")
            {
                MessageBox.Show("Введите пароль!");
            }
            else if (Type_user.Text == "")
            {
                MessageBox.Show("Выберите тип пользователя!");
            }
            else if (count == 1)
             {
                 MessageBox.Show("Пользователь с таким логином существует!");
             }
            else
            {
                 db.Add(new User()
                    {
                       login = AddLogin.Text,
                       name = AddName.Text,
                       surname = AddSurname.Text,
                       patronymic = Addpatronymic.Text,
                       password = AddPassword.Text,
                       type_user = Type_user.Text,
                    });
                  db.SaveChanges();
                  MessageBox.Show("Вы успешно добавили нового пользователя");
                }
            }
        }
    }
}
