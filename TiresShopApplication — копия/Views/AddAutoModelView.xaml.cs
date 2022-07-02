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
    /// Логика взаимодействия для AddAutoModelView.xaml
    /// </summary>
    public partial class AddAutoModelView : UserControl
    {
        public AddAutoModelView()
        {
            InitializeComponent();
            using (TiresDbContext db = new())
            {
                AutoMarksCombobox.ItemsSource = db.AutoMarks.ToList();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (TiresDbContext db = new())
            {
                var count = db.AutoModels.Count(x => x.Name == NameTextbox.Text);
                if (NameTextbox.Text == "" && NameTextbox.Text == "")
                {
                MessageBox.Show("Заполните все поля!");
                }
                else if (count == 1)
                {
                    MessageBox.Show("Такая модель уже существует!");
                }
                else if (string.IsNullOrWhiteSpace(NameTextbox.Text) == false)
                {
                
                    db.Add(new AutoModel()
                    {
                        Name = NameTextbox.Text,
                        IdMark = ((AutoMark)AutoMarksCombobox.SelectedItem).Id
                    });
                    db.SaveChanges();
                    MessageBox.Show("Успешно добавили модель!");
                }
            }
            
        }
    }
}
