using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class Cathegory
    {
        //поля для описания категорий

        public int id { set; get; }
        public string CathegoryName { set; get; }
        public string desc { set; get; }
        public List <Car> cars { set; get; } //

    }
}
