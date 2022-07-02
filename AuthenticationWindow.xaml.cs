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
using MaterialDesignThemes.Wpf;

namespace TiresShopApplication
{
    /// <summary>
    /// Логика взаимодействия для AuthenticationWindow.xaml
    /// </summary>
    public partial class AuthenticationWindow : Window
    {
        
      
        public static string? _Password { get; set; }
        public static string? Name { get; set; }
        public static string? _User { get; set; }
        


        private bool _access = false;
        public enum User
        {
            Admin,
            Manager
        }
        public enum FIO
        {
            Name,
            surname,
            patronymic
        }
        private User _currentUser;

        public AuthenticationWindow(String _User)
        {
           
        }
        public AuthenticationWindow()
        {
            InitializeComponent();
        }



        private void CloseAppButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AuthenticateButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextbox.Text;
            string password = PasswordTextbox.Password.ToString();
            string TypeUserAdmin = "admin";
            string TypeUserManager = "manager";
            UserDbContext db = new UserDbContext();
            if(db.User.Any(u => u.login == login && u.password == password && u.type_user == TypeUserAdmin))
            {
                _access = true;
                _currentUser = User.Admin;
                _User = login;
                _Password = password;
               
            }
            else if(db.User.Any(u => u.login == login && u.password == password && u.type_user == TypeUserManager))
            {
                _access = true;
                _currentUser = User.Manager;
                _User = login;

            }
            else
            {
                LoginTextbox.Text = default(string);
                PasswordTextbox.Password = default(string);
                MessageBox.Show("Неверный логин или пароль!");

                return;
            }
            Close();
       
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (_access == true)
            {
                base.Close();
            }
            else
            {
                Application.Current.Shutdown();
            }

        }
        public new User ShowDialog()
        {
            base.ShowDialog();
            return _currentUser;
        }
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletreHelper = new PaletteHelper();
        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletreHelper.GetTheme();

            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletreHelper.SetTheme(theme);
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            base.Close();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

       
    }
}
