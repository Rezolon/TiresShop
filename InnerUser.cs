using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiresShopApplication
{
    internal class InnerUser
    {
        public string FIO { get; set; }

        public InnerUser(string name, string surname, string patronymic)
        {
            FIO = $"{name} {surname} {patronymic}";
        }
    }
}
