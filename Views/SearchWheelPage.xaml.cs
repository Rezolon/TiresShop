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

namespace TiresShopApplication.Views
{
    
    public partial class SearchWheelPage : Page
    {
        private List<InnerTiresWheelClass> innerAutoWheelList = new List<InnerTiresWheelClass>();
        List<InnerAutoModif> listInnerAutoModifs;
        List<DriveUnit> listInnerDriveUnit;
        List<AutoMark> listInnerAutoMark;

        public SearchWheelPage()
        {
            InitializeComponent();
            AutoMarkCombobox.ItemsSource = listInnerAutoMark = GetItemsSourceAutoMark();
           
            DriveUnitCombobox.ItemsSource = listInnerDriveUnit = GetItemsSourceDriveUnit();
            listInnerAutoModifs = GetItemsSourceInnerAutoModif();
            LoadItemsToMainWrapPanel();
        }
        private List<InnerAutoModif> GetItemsSourceInnerAuto()
        {
            int idMark;
            idMark = ((AutoMark)AutoMarkCombobox.SelectedItem).Id;
            using (TiresDbContext db = new())
            {
                return new List<InnerAutoModif>(db.AutoModifs.ToList().Join(db.AutoModels.Where(a => a.IdMark == idMark), x => x.IdModels, y => y.Id, (x, y) => new
                {
                    Id = x.Id,
                    AutoModifName = x.Name,
                    AutoModelName = y.Name,
                    y.IdMark,
                    Year = x.Year,
                    Diameter = x.Diameter,
                    NameModel = y.Name,
                    NameMark = x.Name,
                }).Join(db.AutoMarks, x => x.IdMark, y => y.Id, (x, y) => new InnerAutoModif(x.Id, y.Name, x.AutoModelName, x.AutoModifName!, x.Year ?? 0, x.Diameter!, x.NameModel, x.NameMark)).ToList());
            }
        }
        private List<InnerAutoModif> GetItemsSourceInnerAutoModif()
        {
           
            using (TiresDbContext db = new())
            {
                return new List<InnerAutoModif>(db.AutoModifs.Join(db.AutoModels, x => x.IdModels, y => y.Id, (x, y) => new
                {
                    Id = x.Id,
                    AutoModifName = x.Name,
                    AutoModelName = y.Name,
                    y.IdMark,
                    Year = x.Year,
                    Diameter = x.Diameter,
                    NameModel =y.Name,
                    NameMark = x.Name,
                }).Join(db.AutoMarks, x => x.IdMark, y => y.Id, (x, y) => new InnerAutoModif(x.Id, y.Name, x.AutoModelName, x.AutoModifName!, x.Year ?? 0, x.Diameter!, x.NameModel, x.NameMark)).ToList());
            }
        }
        private List<AutoMark> GetItemsSourceAutoMark()
        {
            using (TiresDbContext db = new())
            {
                return new List<AutoMark>(db.AutoMarks);
            }
        }
        private List<DriveUnit> GetItemsSourceDriveUnit()
        {
            using (TiresDbContext db = new())
            {
                return new List<DriveUnit>(db.DriveUnits);
            }
        }

        public void LoadItemsToMainWrapPanel()
        {
            MainWrapPanel.Children.Clear();
            
            using (TiresDbContext db = new())
            {
                innerAutoWheelList = new List<InnerTiresWheelClass>(db.AutoTires.Where(a => a.idType == 2 && a.Status == "Активен").ToList().Join(listInnerAutoModifs, x => x.IdModif, y => y.Id, (x, y) => new
                {
                    x.Id,
                    y.Model,
                    y.Year,
                    x.IdDriveUnit,
                    y.Diameter,
                    ////x.Oem,
                    ////x.Opt,
                    //x.Tunning,
                    x.Image,
                    x.Price,
                    x.Amount,
                    x.Season,
                    x.Load,
                    x.Color,
                    x.Type,
                }).Join(listInnerDriveUnit, x => x.IdDriveUnit, y => y.Id, (x, y) => new InnerTiresWheelClass(x.Id, x.Model, x.Year, y.Name, x.Diameter, (decimal)x.Price!, x.Season, x.Load, x.Image!, x.Amount,x.Type,x.Color)).Select(x => x));
            }

            foreach (var item in innerAutoWheelList)
            {
                MainWrapPanel.Children.Add(new CardWheelView(item, this));
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            MainWrapPanel.Children.Clear();
            string model = "";
            string driveUnit = "";
            string Search = "";
            try
            {
                model = $"{((InnerAutoModif)AutoModifCombobox.SelectedItem).Model ?? ""} {((InnerAutoModif)AutoModifCombobox.SelectedItem).Year.ToString() ?? ""}";
            }
            catch (Exception)
            {
                model = "";
            }
            try
            {
                Search = TextboxSearch.Text;
            }
            catch (Exception)
            {
                Search = "";
            }
            try
            {
                driveUnit = ((DriveUnit)DriveUnitCombobox.SelectedItem).Name ?? "";
            }
            catch (Exception)
            {
                driveUnit = "";
            }
            decimal.TryParse(PriceFromTextbox.Text, out decimal priceFrom);
            decimal.TryParse(PriceToTextbox.Text, out decimal priceTo);
            if (priceTo == 0)
            {
                priceTo = int.MaxValue;
            }
            List<InnerTiresWheelClass> innerAutoTires = innerAutoWheelList.Where(x => x.TireName.Contains(model) && x.DriveUnit.Contains(driveUnit) && x.TireName.Contains(Search) && x.Price >= priceFrom && x.Price <= priceTo).ToList();
            foreach (var item in innerAutoTires)
            {
                MainWrapPanel.Children.Add(new CardWheelView(item, this));
            }
        }

        private void ClearFilterFieldsButton_Click(object sender, RoutedEventArgs e)
        {
            AutoMarkCombobox.SelectedIndex = -1;
            
            DriveUnitCombobox.SelectedIndex = -1;
            PriceFromTextbox.Text = default(string);
            PriceToTextbox.Text = default(string);
            TextboxSearch.Text = default(string);

            LoadItemsToMainWrapPanel();
        }

        private void AutoMarkCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AutoMarkCombobox.SelectedIndex == -1)
            {
                AutoModifCombobox.ItemsSource = listInnerAutoModifs = GetItemsSourceInnerAutoModif();
                AutoModifCombobox.IsEnabled = false;

            }
            else
            {
                AutoModifCombobox.IsEnabled = true;
                AutoModifCombobox.ItemsSource = listInnerAutoModifs = GetItemsSourceInnerAuto();
            }
        }
    }
}
