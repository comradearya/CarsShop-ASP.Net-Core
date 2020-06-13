using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Interfaces
{
    public interface IAllCars
    {
        //for working with products

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car GetObjectCar(int carId);

    }
}
