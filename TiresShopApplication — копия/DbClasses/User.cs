using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiresShopApplication.DbClasses
{
    public class User
    {
        [Key]
        public int id_user { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? patronymic { get; set; }
        public string? login { get; set; }
        public string? password { get; set; }
        public string? type_user { get; set; }
    }
}
