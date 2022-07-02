using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiresShopApplication
{
    internal class ConnectionString
    {
#warning Change connection string here
        private static string _connectionString = "Server=DESKTOP-NEGFGM0\\SQLEXPRESS;Database=TiresDb;Trusted_Connection=True;Encrypt=false";

        public static string Get()
        {
            return _connectionString;
        }

    }
}
