using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TiresShopApplication.DbClasses;
using Word = Microsoft.Office.Interop.Word;

namespace TiresShopApplication.Views
{
    /// <summary>
    /// Логика взаимодействия для AdminPanelPage.xaml
    /// </summary>
    public partial class AdminPanelPage : Page
    {
        private string[] _tables = { "Марки", "Модели", "Модификации", "Шины", "Диски", "Привод", "Продажи",/*"Продажа Товара",*/ "Пользователи" };
        private string _selectedTable = "";
        private List<InnerWheel> InnerAutoTiresList1 = new List<InnerWheel>();
        List<AutoTire> listTire;
        List<Sale> listSale;
        List<User> innerUsers;
        public AdminPanelPage()
        {
            InitializeComponent();
            WorkTableCombobox.ItemsSource = _tables;
            //LoadItemsToMainWrapPanel();
        }

        private void WorkTableCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedTable = WorkTableCombobox.SelectedItem.ToString()!;
            LoadItemsToDataGrid();
        }
      

        private enum ButtonsWidth
        {
            ButtonDisabled = 0,
            ButtonAmountVisible = 220,
            ButtonUserVisible = 240,
            ButtonStatusVisible = 198
        }

        private void LoadItemsToDataGrid()
        {
            MainDataGridView.ItemsSource = new List<int>();
            using (TiresDbContext db = new())
            {
                if (_selectedTable == "Продажи")
                {
                    ExportSales.Visibility = Visibility.Visible;
                }
                else
                {
                    ExportSales.Visibility = Visibility.Hidden;
                }
                switch (_selectedTable)
                {
                    case "Марки":
                        MainDataGridView.ItemsSource = db.AutoMarks.Select(x => new { x.Id, x.Name }).ToList();
                        Buttom_Amount.Visibility = Visibility.Hidden; Buttom_Amount.Width = (int)ButtonsWidth.ButtonDisabled;
                        Buttom_User.Visibility = Visibility.Hidden; Buttom_User.Width = (int)ButtonsWidth.ButtonDisabled;
                        Buttom_Status.Visibility = Visibility.Hidden; Buttom_Status.Width = (int)ButtonsWidth.ButtonDisabled;
                        labelDateOT.Visibility = Visibility.Hidden;
                        DataOT.Visibility = Visibility.Hidden;
                        labelDateDo.Visibility = Visibility.Hidden;
                        DataDO.Visibility = Visibility.Hidden;
                        ClearFilterFieldsButton.Visibility = Visibility.Hidden;
                        SearchButton.Visibility = Visibility.Hidden;
                        Username.Visibility = Visibility.Hidden;
                        MainDataGridView.Columns[0].Header = "Код марки";
                        MainDataGridView.Columns[1].Header = "Название марки";
                       
                        break;
                    case "Модели":
                        MainDataGridView.ItemsSource = db.AutoModels.Include(x => x.IdMarkNavigation)
                                                                    .Select(x => new
                                                                    {
                                                                        x.Id,
                                                                        Mark = x.IdMarkNavigation!.Name,
                                                                        Name = x.Name
                                                                    }).ToList();
                        Buttom_Amount.Visibility = Visibility.Hidden; Buttom_Amount.Width = (int)ButtonsWidth.ButtonDisabled;
                        Buttom_User.Visibility = Visibility.Hidden; Buttom_User.Width = (int)ButtonsWidth.ButtonDisabled;
                        Buttom_Status.Visibility = Visibility.Hidden; Buttom_Status.Width = (int)ButtonsWidth.ButtonDisabled;
                        labelDateOT.Visibility = Visibility.Hidden;
                        DataOT.Visibility = Visibility.Hidden;
                        labelDateDo.Visibility = Visibility.Hidden;
                        DataDO.Visibility = Visibility.Hidden;
                        ClearFilterFieldsButton.Visibility = Visibility.Hidden;
                        SearchButton.Visibility = Visibility.Hidden;
                        Username.Visibility = Visibility.Hidden;
                        MainDataGridView.Columns[0].Header = "Код модели";
                        MainDataGridView.Columns[1].Header = "Марка";
                        MainDataGridView.Columns[2].Header = "Название Модели";
                        break;
                    case "Модификации":
                        MainDataGridView.ItemsSource = db.AutoModifs.Include(x => x.IdModelsNavigation)
                                                                    .ThenInclude(x => x!.IdMarkNavigation)
                                                                    .Select(x => new
                                                                    {
                                                                        Id = x.Id,
                                                                        Mark = x.IdModelsNavigation!.IdMarkNavigation!.Name,
                                                                        Model = x.IdModelsNavigation.Name,
                                                                        Modif = x.Name,
                                                                        Year = x.Year,
                                                                        Diameter = x.Diameter
                                                                    }).ToList();
                        Buttom_Amount.Visibility = Visibility.Hidden; Buttom_Amount.Width = (int)ButtonsWidth.ButtonDisabled;
                        Buttom_User.Visibility = Visibility.Hidden; Buttom_User.Width = (int)ButtonsWidth.ButtonDisabled;
                        Buttom_Status.Visibility = Visibility.Hidden; Buttom_Status.Width = (int)ButtonsWidth.ButtonDisabled;
                        labelDateOT.Visibility = Visibility.Hidden;
                        DataOT.Visibility = Visibility.Hidden;
                        labelDateDo.Visibility = Visibility.Hidden;
                        DataDO.Visibility = Visibility.Hidden;
                        ClearFilterFieldsButton.Visibility = Visibility.Hidden;
                        SearchButton.Visibility = Visibility.Hidden;
                        Username.Visibility = Visibility.Hidden;
                        MainDataGridView.Columns[0].Header = "Код модификации";
                        MainDataGridView.Columns[1].Header = "Марка";
                        MainDataGridView.Columns[2].Header = "Модель";
                        MainDataGridView.Columns[3].Header = "Название модификации";
                        MainDataGridView.Columns[4].Header = "Год выпуска";
                        MainDataGridView.Columns[5].Header = "Параметры колеса";
                        break;
                    case "Шины":
                        MainDataGridView.ItemsSource = db.AutoTires.Where(a => a.idType == 1).Include(x => x.IdModifNavigation)
                                                                   .ThenInclude(x => x!.IdModelsNavigation)
                                                                   .ThenInclude(x => x!.IdMarkNavigation)
                                                                   .Include(x => x.IdDriveUnitNavigation)
                                                                   .Select(x => new
                                                                   {
                                                                       Id = x.Id,
                                                                       Mark = x.IdModifNavigation!.IdModelsNavigation!.IdMarkNavigation!.Name,
                                                                       Model = x.IdModifNavigation.IdModelsNavigation.Name,
                                                                       Name = x.IdModifNavigation!.Name,
                                                                       Year = x.IdModifNavigation.Year,
                                                                       Diameter = x.IdModifNavigation.Diameter,
                                                                       DriveUnit = x.IdDriveUnitNavigation!.Name,
                                                                       Amount = x.Amount,
                                                                       Lods = x.Load,
                                                                       Season = x.Season,
                                                                       
                                                                       Price = x.Price,
                                                                       Status = x.Status,
                                                                   }).ToList();
                        Buttom_Amount.Visibility = Visibility.Visible; Buttom_Amount.Width = (int)ButtonsWidth.ButtonAmountVisible;
                        Buttom_User.Visibility = Visibility.Hidden; Buttom_User.Width = (int)ButtonsWidth.ButtonDisabled;
                        Buttom_Status.Visibility = Visibility.Visible; Buttom_Status.Width = (int)ButtonsWidth.ButtonStatusVisible;
                        labelDateOT.Visibility = Visibility.Hidden;
                        DataOT.Visibility = Visibility.Hidden;
                        labelDateDo.Visibility = Visibility.Hidden;
                        DataDO.Visibility = Visibility.Hidden;
                        ClearFilterFieldsButton.Visibility = Visibility.Hidden;
                        SearchButton.Visibility = Visibility.Hidden;
                        Username.Visibility = Visibility.Hidden;
                        MainDataGridView.Columns[0].Header = "Код шины";
                        MainDataGridView.Columns[1].Header = "Марка";
                        MainDataGridView.Columns[2].Header = "Модель";
                        MainDataGridView.Columns[3].Header = "Название";
                        MainDataGridView.Columns[4].Header = "Год выпуска";
                        MainDataGridView.Columns[5].Header = "Параметры колеса";
                        MainDataGridView.Columns[6].Header = "Привод";
                        MainDataGridView.Columns[7].Header = "Количество";
                        MainDataGridView.Columns[8].Header = "Мак. скорость";
                        MainDataGridView.Columns[9].Header = "Сезон";
                        
                        MainDataGridView.Columns[10].Header = "Цена";
                        MainDataGridView.Columns[11].Header = "Статус";

                        break;
                    case "Продажи":
                       
                        MainDataGridView.ItemsSource = db.SaleGood.Include(x => x.IdAutoTireNavigation)
                                                                  .Select(x => new InnerSaleGood(x.Id,
                                                                                                 x.IdAutoTire,
                                                                                                 x.IdAutoTireNavigation!.Id,
                                                                                                 x.DateOrder,
                                                                                                 x.Amount,
                                                                                                 x.Cost,
                                                                                                 x.FIO
                                                                                                )).ToList();
                                                                   
                        MainDataGridView.Columns[0].Header = "Код продажи";
                        MainDataGridView.Columns[1].Header = "Артикул товара";
                        MainDataGridView.Columns[2].Header = "Наименование товара";
                        MainDataGridView.Columns[3].Header = "Дата продажи";
                        MainDataGridView.Columns[4].Header = "Количество";
                        MainDataGridView.Columns[5].Header = "Цена продажи (руб.)";
                        MainDataGridView.Columns[6].Header = "Продавец-кассир";
                        Username.ItemsSource = innerUsers = GetItemsSourceInnerUser();
                        Buttom_User.Visibility = Visibility.Hidden; Buttom_User.Width = (int)ButtonsWidth.ButtonUserVisible;
                        Buttom_Amount.Visibility = Visibility.Hidden; Buttom_Amount.Width = (int)ButtonsWidth.ButtonAmountVisible;
                        Buttom_Status.Visibility = Visibility.Hidden; Buttom_Status.Width = (int)ButtonsWidth.ButtonDisabled;
                        Username.Visibility = Visibility.Visible;
                        labelDateOT.Visibility = Visibility.Visible;
                        DataOT.Visibility = Visibility.Visible;
                        labelDateDo.Visibility = Visibility.Visible;
                        DataDO.Visibility = Visibility.Visible;
                        ClearFilterFieldsButton.Visibility = Visibility.Visible;
                        SearchButton.Visibility = Visibility.Visible;



                        break;
                    case "Диски":
                        MainDataGridView.ItemsSource = db.AutoTires.Where(a => a.idType == 2).Include(x => x.IdModifNavigation)
                                                                    .ThenInclude(x => x!.IdModelsNavigation)
                                                                    .ThenInclude(x => x!.IdMarkNavigation)
                                                                    .Include(x => x.IdDriveUnitNavigation)
                                                                    .Select(x => new
                                                                    {
                                                                        Id = x.Id,
                                                                        Mark = x.IdModifNavigation!.IdModelsNavigation!.IdMarkNavigation!.Name,
                                                                        Model = x.IdModifNavigation.IdModelsNavigation.Name,
                                                                        Name = x.IdModifNavigation!.Name,
                                                                        Year = x.IdModifNavigation.Year,
                                                                        Diameter = x.IdModifNavigation.Diameter,
                                                                        DriveUnit = x.IdDriveUnitNavigation!.Name,
                                                                        Amount = x.Amount,
                                                                        Type = x.Type,
                                                                        Color = x.Color,
                                                                        
                                                                        Price = x.Price,
                                                                        Status = x.Status,
                                                                    }).ToList();
                        Buttom_Amount.Visibility = Visibility.Visible; Buttom_Amount.Width = (int)ButtonsWidth.ButtonAmountVisible;
                        Buttom_User.Visibility = Visibility.Hidden; Buttom_User.Width = (int)ButtonsWidth.ButtonDisabled;
                        Buttom_Status.Visibility = Visibility.Visible; Buttom_Status.Width = (int)ButtonsWidth.ButtonStatusVisible;
                        labelDateOT.Visibility = Visibility.Hidden;
                        DataOT.Visibility = Visibility.Hidden;
                        labelDateDo.Visibility = Visibility.Hidden;
                        DataDO.Visibility = Visibility.Hidden;
                        ClearFilterFieldsButton.Visibility = Visibility.Hidden;
                        SearchButton.Visibility = Visibility.Hidden;
                        Username.Visibility = Visibility.Hidden;
                        MainDataGridView.Columns[0].Header = "Код диска";
                        MainDataGridView.Columns[1].Header = "Марка";
                        MainDataGridView.Columns[2].Header = "Модель";
                        MainDataGridView.Columns[3].Header = "Название";
                        MainDataGridView.Columns[4].Header = "Год выпуска";
                        MainDataGridView.Columns[5].Header = "Параметры колеса";
                        MainDataGridView.Columns[6].Header = "Привод";
                        MainDataGridView.Columns[7].Header = "Количество";
                        MainDataGridView.Columns[8].Header = "Тип диска";
                        MainDataGridView.Columns[9].Header = "Цвет";
                       
                        MainDataGridView.Columns[10].Header = "Цена";
                        MainDataGridView.Columns[11].Header = "Статус";
                        break;
                    case "Привод":
                        MainDataGridView.ItemsSource = db.DriveUnits.Select(x => new { x.Id, x.Name }).ToList();
                        Buttom_Amount.Visibility = Visibility.Hidden; Buttom_Amount.Width = (int)ButtonsWidth.ButtonDisabled;
                        Buttom_User.Visibility = Visibility.Hidden; Buttom_User.Width = (int)ButtonsWidth.ButtonDisabled;
                        labelDateOT.Visibility = Visibility.Hidden;
                        DataOT.Visibility = Visibility.Hidden;
                        labelDateDo.Visibility = Visibility.Hidden;
                        DataDO.Visibility = Visibility.Hidden;
                        ClearFilterFieldsButton.Visibility = Visibility.Hidden;
                        SearchButton.Visibility = Visibility.Hidden;
                        Username.Visibility = Visibility.Hidden;
                        MainDataGridView.Columns[0].Header = "Код привода";
                        MainDataGridView.Columns[1].Header = "Название";
                        break;
               
                    case "Пользователи":
                        using (UserDbContext dbus = new())
                        {
                            MainDataGridView.ItemsSource = dbus.User.Select(x => new
                            {
                                x.login,
                                x.name,
                                x.surname,
                                x.patronymic,
                                x.password,
                                x.type_user,
                            }).ToList();
                            Buttom_Amount.Visibility = Visibility.Hidden; Buttom_Amount.Width = (int)ButtonsWidth.ButtonDisabled;
                            Buttom_Status.Visibility = Visibility.Hidden; Buttom_Status.Width = (int)ButtonsWidth.ButtonDisabled;
                            Buttom_User.Visibility = Visibility.Visible; Buttom_User.Width = (int)ButtonsWidth.ButtonUserVisible;
                            labelDateOT.Visibility = Visibility.Hidden;
                            DataOT.Visibility = Visibility.Hidden;
                            labelDateDo.Visibility = Visibility.Hidden;
                            DataDO.Visibility = Visibility.Hidden;
                            ClearFilterFieldsButton.Visibility = Visibility.Hidden;
                            SearchButton.Visibility = Visibility.Hidden;
                            Username.Visibility = Visibility.Hidden;
                            MainDataGridView.Columns[0].Header = "Логин";
                            MainDataGridView.Columns[1].Header = "Имя сотрудника";
                            MainDataGridView.Columns[2].Header = "Фамилия сотрудника";
                            MainDataGridView.Columns[3].Header = "Отчество сотрудника";
                            MainDataGridView.Columns[4].Header = "Пароль";
                            MainDataGridView.Columns[5].Header = "Тип пользователя";
                        }
                            break;
                    default:
                        Buttom_Amount.Visibility = Visibility.Hidden; Buttom_Amount.Width = (int)ButtonsWidth.ButtonDisabled;
                        break;
                }
            }
        }
  
         
            private void AddButton_Click(object sender, RoutedEventArgs e)
        
        
            {
            switch (_selectedTable)
            {
                case "Марки":
                    new AddDataWindow(new AddAutoMarkView()).ShowDialog();
                    break;
                case "Модели":
                    new AddDataWindow(new AddAutoModelView()).ShowDialog();
                    break;
                case "Модификации":
                    new AddDataWindow(new AddAutoModifView()).ShowDialog();
                    break;
                case "Шины":
                    new AddDataWindow(new AddAutoTireWheelView(AddAutoTireWheelView.Table.AutoTire)).ShowDialog(); 
                    break;
                case "Диски":
                    new AddDataWindow(new AddAutoTireWheelView(AddAutoTireWheelView.Table.AutoWheel)).ShowDialog();
                    break;
                case "Привод":
                    new AddDataWindow(new AddDriveUnitView()).ShowDialog();
                    break;
                default:
                    break;
            }
            LoadItemsToDataGrid();
            }
        private List<User> GetItemsSourceInnerUser()
        {
            using (UserDbContext db1 = new())
            {
                return new List<User>(db1.User); 
                

            }
        }

//private void DeleteButton_Click(object sender, RoutedEventArgs e)
//{
//    string id = IdForDeleteTextbox.Text;
//    if (string.IsNullOrWhiteSpace(id) == false)
//    {
//        try
//        {
//            using (TiresDbContext db = new())
//            {
//                switch (_selectedTable)
//                {
//                    case "Марки":
//                        db.Remove(db.AutoMarks.Where(x => x.Id.ToString() == id).First());
//                        break;
//                    case "Модели":
//                        db.Remove(db.AutoModels.Where(x => x.Id.ToString() == id).First());
//                        break;
//                    case "Модификации":
//                        db.Remove(db.AutoModifs.Where(x => x.Id.ToString() == id).First());
//                        break;
//                    case "Шины":
//                        db.Remove(db.AutoTires.Where(x => x.Id.ToString() == id).First());
//                        break;
//                    case "Диски":
//                        db.Remove(db.AutoTires.Where(x => x.Id.ToString() == id).First());
//                        break;
//                    case "Привод":
//                        db.Remove(db.DriveUnits.Where(x => x.Id.ToString() == id).First());
//                        break;
//                    default:
//                        break;
//                }
//                db.SaveChanges();
//            }
//        }
//        catch (Exception)
//        {
//            MessageBox.Show("База данных не содержит указанного id");
//        }
//        IdForDeleteTextbox.Text = default(string);
//        LoadItemsToDataGrid();  
//    }    
//}

private void Buttom_Amount_Click(object sender, RoutedEventArgs e)
        {
            new AddDataWindow(new UpdateAmount()).ShowDialog();
        }

        private void Buttom_User_Click(object sender, RoutedEventArgs e)
        {
            new AddDataWindow(new AddUser()).ShowDialog();
        }
        private void Buttom_Status_Click(object sender, RoutedEventArgs e)
        {
            new AddDataWindow(new UpdateStatus()).ShowDialog();
        }

        private void ExportSales_Click(object sender, RoutedEventArgs e)
        {
            var currentList = MainDataGridView.ItemsSource;
            Word.Table table = CreateWordReport(currentList);
        }
        private Word.Table CreateWordReport(IEnumerable collection)
        {
           
            int countColumns = 6;
            int countRows = collection.GetCountItems() + 1;
            object oEndOfDoc = "\\endofdoc";
            string[] nameHeaders = { "Артикул товара", "Дата продажи", "Стоимость", "Товар", "Количество", "Продавец-кассир" };
            decimal sum = 0;
            Word.Application application = new Word.Application() { Visible = false };
            Word.Document document = application.Documents.Add();
            Word.Range range = document.Bookmarks.get_Item(ref oEndOfDoc).Range;

            if (DataOT.SelectedDate == null && DataDO.SelectedDate == null)
            {
                range.Text = "Отчет по продажам";
                range.Font.Size = 14;
                range.Font.Bold = 1;
                range.Start = "Отчет по продажам".Count() + 1;
            }
            else
            {
               
                range.Text = $"Отчет по продажам за период с {DataOT.SelectedDate} по {DataDO.SelectedDate}";
                range.Font.Size = 14;
                range.Font.Bold = 1;
                range.Start = $"Отчет по продажам за период {DataOT} - {DataDO}".Count() + 1;
            }
          
            Word.Table table = document.Tables.Add(range, countRows, countColumns);
            table.Range.ParagraphFormat.SpaceAfter = 7;

            for (int i = 1; i < countColumns + 1; i++)
            {
                table.Cell(1, i).Range.Text = nameHeaders[i - 1];
            }
            int currentRow = 2;
            foreach (var item in collection)
            {
                if (item is InnerSaleGood good)
                {
                    table.Cell(currentRow, 1).Range.Text = good.IdAutoTire.ToString();
                    table.Cell(currentRow, 2).Range.Text = good.DataOrder.ToString();
                    table.Cell(currentRow, 3).Range.Text = good.Cost.ToString();
                    table.Cell(currentRow, 4).Range.Text = good.NameGoods;
                    table.Cell(currentRow, 5).Range.Text = good.Amount.ToString();
                    table.Cell(currentRow, 6).Range.Text = good.FIO.ToString();
                    sum += good.Cost;
                    currentRow++;
                }
            }
            table.Rows[1].Range.Font.Bold = 1;
           
            range.Start = $"Дата отчета: {DateTime.Now}".Count() + 1;
            range.Start = document.Tables[1].Range.End + 1;
            range.Text = $"\nИтого: {sum} руб." + $"\nДата отчета: {DateTime.Now}";
            application.Visible = true;
            try
            {
                table.Borders.Shadow = true;
            }
            catch (Exception)
            {
            }
            return table;
        }
        

       
        private void ClearFilterFieldsButton_Click(object sender, RoutedEventArgs e)
        {
            DataOT.Text = null;
            DataDO.Text = null;
            LoadItemsToDataGrid();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
          
            DateTime? selectedDate = DataOT.SelectedDate;
            DateTime? selectedDate1 = DataDO.SelectedDate;
            DateTime model2 = DataDO.DisplayDate;
            string model = "";
            try
            {
                model = $"{((User)Username.SelectedItem).surname ?? ""} {((User)Username.SelectedItem).name ?? ""} {((User)Username.SelectedItem).patronymic ?? ""}";
            }
            catch (Exception)
            {
                model = "";
            }
                if (model == "")
                {
                using (TiresDbContext db = new())
                {
                    MainDataGridView.ItemsSource = db.SaleGood.Where(x => x.DateOrder >= selectedDate && x.DateOrder <= selectedDate1)
                                                                                 .Select(x => new InnerSaleGood(x.Id,
                                                                                                     x.IdAutoTire,
                                                                                                     x.IdAutoTireNavigation!.Id,
                                                                                                     x.DateOrder,
                                                                                                     x.Amount,
                                                                                                     x.Cost,
                                                                                                     x.FIO
                                                                                                    )).ToList();


                    MainDataGridView.Columns[0].Header = "Код продажи";
                    MainDataGridView.Columns[1].Header = "Код товара";
                    MainDataGridView.Columns[2].Header = "Наименование товара";
                    MainDataGridView.Columns[3].Header = "Дата продажи";
                    MainDataGridView.Columns[4].Header = "Количество";
                    MainDataGridView.Columns[5].Header = "Цена продажи";
                    MainDataGridView.Columns[6].Header = "Продавец-кассир";
                    Buttom_User.Visibility = Visibility.Hidden; Buttom_User.Width = (int)ButtonsWidth.ButtonUserVisible;
                    Buttom_Amount.Visibility = Visibility.Hidden; Buttom_Amount.Width = (int)ButtonsWidth.ButtonAmountVisible;
                    Buttom_Status.Visibility = Visibility.Hidden; Buttom_Status.Width = (int)ButtonsWidth.ButtonDisabled;
                }
                }
                else if(model != "" && selectedDate1 != null && selectedDate != null)
                {
                using (TiresDbContext db = new())
                {
                    MainDataGridView.ItemsSource = db.SaleGood.Where(x => x.FIO.Contains(model) && x.DateOrder >= selectedDate && x.DateOrder <= selectedDate1)
                                                                                 .Select(x => new InnerSaleGood(x.Id,
                                                                                                     x.IdAutoTire,
                                                                                                     x.IdAutoTireNavigation!.Id,
                                                                                                     x.DateOrder,
                                                                                                     x.Amount,
                                                                                                     x.Cost,
                                                                                                     x.FIO
                                                                                                    )).ToList();


                    MainDataGridView.Columns[0].Header = "Код продажи";
                    MainDataGridView.Columns[1].Header = "Код товара";
                    MainDataGridView.Columns[2].Header = "Наименование товара";
                    MainDataGridView.Columns[3].Header = "Дата продажи";
                    MainDataGridView.Columns[4].Header = "Количество";
                    MainDataGridView.Columns[5].Header = "Цена продажи";
                    MainDataGridView.Columns[6].Header = "Продавец-кассир";
                    Buttom_User.Visibility = Visibility.Hidden; Buttom_User.Width = (int)ButtonsWidth.ButtonUserVisible;
                    Buttom_Amount.Visibility = Visibility.Hidden; Buttom_Amount.Width = (int)ButtonsWidth.ButtonAmountVisible;
                    Buttom_Status.Visibility = Visibility.Hidden; Buttom_Status.Width = (int)ButtonsWidth.ButtonDisabled;
                }
                }
                else
                {
                using (TiresDbContext db = new())
                {
                    MainDataGridView.ItemsSource = db.SaleGood.Where(x => x.FIO.Contains(model)/* && x.DateOrder >= selectedDate && x.DateOrder <= selectedDate1*/)
                                                                                 .Select(x => new InnerSaleGood(x.Id,
                                                                                                     x.IdAutoTire,
                                                                                                     x.IdAutoTireNavigation!.Id,
                                                                                                     x.DateOrder,
                                                                                                     x.Amount,
                                                                                                     x.Cost,
                                                                                                     x.FIO
                                                                                                    )).ToList();


                    MainDataGridView.Columns[0].Header = "Код продажи";
                    MainDataGridView.Columns[1].Header = "Код товара";
                    MainDataGridView.Columns[2].Header = "Наименование товара";
                    MainDataGridView.Columns[3].Header = "Дата продажи";
                    MainDataGridView.Columns[4].Header = "Количество";
                    MainDataGridView.Columns[5].Header = "Цена продажи";
                    MainDataGridView.Columns[6].Header = "Продавец-кассир";
                    Buttom_User.Visibility = Visibility.Hidden; Buttom_User.Width = (int)ButtonsWidth.ButtonUserVisible;
                    Buttom_Amount.Visibility = Visibility.Hidden; Buttom_Amount.Width = (int)ButtonsWidth.ButtonAmountVisible;
                    Buttom_Status.Visibility = Visibility.Hidden; Buttom_Status.Width = (int)ButtonsWidth.ButtonDisabled;
                }
            }
            }
           
             
        }



    }
    public static class Counter
    {
        public static int GetCountItems(this IEnumerable collection)
        {
            int counter = 0;
            foreach (var item in collection)
            {
                counter++;
            }
            return counter;
        }
   }



