using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Interfaces
{
    public interface ICarsCathegory
    {
        //возвращает все категории из модели категорий
        IEnumerable<Cathegory> AllCathegories { get; }

    }
}
