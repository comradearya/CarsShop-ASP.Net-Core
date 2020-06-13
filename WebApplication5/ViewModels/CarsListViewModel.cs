using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.ViewModels
{
    public class CarsListViewModel
    {
        //функция которая будет получать все товары
        public IEnumerable<Car> allCars { get; set; }

        public string currCathegory { get; set; }

    }
}
