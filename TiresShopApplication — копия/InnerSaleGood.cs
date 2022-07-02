
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TiresShopApplication
{
    internal class InnerSaleGood
    {
        public int IdSale { get; set; }
        public int IdAutoTire { get; set; }
        public string NameGoods { get; set; }
        public string DataOrder { get; set; }
        public int Amount { get; set; }
        public decimal Cost { get; set; }
        //public int IdGoods { get; set; }
        public string FIO { get; set; }
       
        private int IdGood { get; set; }
      


        public InnerSaleGood(int idSale, int idGood, int idAutoTire, DateTime dataOrder, int amount, decimal cost, string fio)
        {
            IdSale = idSale;
            IdGood = idGood;
            IdAutoTire = idAutoTire;
            NameGoods = GetNameAutoTire(idGood);
            DataOrder = dataOrder.ToString("d/MM/yyyy");
            Cost = cost;
            Amount = amount;
            FIO = fio;
            
        }
        private string GetNameAutoTire(int idGood)
        {
            using (TiresDbContext db = new())
            {
                string name = db.AutoTires.Where(x => x.Id == idGood)
                    .Include(x => x.IdModifNavigation)
                    .ThenInclude(x => x!.IdModelsNavigation)
                    .ThenInclude(x => x!.IdMarkNavigation)
                    .Select(x => $"{x.IdModifNavigation!.IdModelsNavigation!.IdMarkNavigation!.Name} " +
                                 $"{x.IdModifNavigation.IdModelsNavigation.Name} " +
                                 $"{x.IdModifNavigation.Name} " +
                                 $"{x.IdModifNavigation!.Year}").First();
                return name;
            }
        }
    }
}
