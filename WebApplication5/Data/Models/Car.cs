using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class Car
    {
        //описание самого товара и его принадлежность к категории
        public int id { get; set; }
        public string name {get; set; }

        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }

        public bool isFavourite{ get; set; }
        public bool available { get; set; }
        public int CathegoryId { get; set; }

        public virtual Cathegory Cathegory { get; set; } //объект со всеми значениями выше


    }
}
