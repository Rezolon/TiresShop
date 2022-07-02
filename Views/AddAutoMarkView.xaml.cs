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

namespace TiresShopApplication
{
    /// <summary>
    /// Логика взаимодействия для AddAutoMarkView.xaml
    /// </summary>
    public partial class AddAutoMarkView : UserControl
    {
        public AddAutoMarkView()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (TiresDbContext db = new())
            {
                var count = db.AutoMarks.Count(x => x.Name == NameTextbox.Text);
                if (NameTextbox.Text == "")
                {
                    MessageBox.Show("Введите марку автомобиля!");
                }
                else if(count == 1)
                {
                    MessageBox.Show("Такая марка уже существует!");
                }
                else if (string.IsNullOrWhiteSpace(NameTextbox.Text) == false)
                {
                 db.Add(new AutoMark()
                      {
                    Name = NameTextbox.Text
                     });
                    db.SaveChanges();     
             }
                AddDataWindow.AddDataWindowParent?.Close();
            }
        }
    }
}
