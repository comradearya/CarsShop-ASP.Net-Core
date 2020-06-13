using shop.Data.Models;
using shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        //с помощью этого сможем указывать к какой категории принадлежит наше авто
        //переменная которая ссылается на другой класс
        private readonly ICarsCathegory _cathegoryCars = new MockCathegory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                     new  Car
                     {
                         name="Tesla",
                         shortDesc="",
                         longDesc="",
                         img = "",
                         price=45000,
                         isFavourite=true,
                         available=true,
                         Cathegory= _cathegoryCars.AllCathegories.First()
                     },


                new Car
                {
                    name = "BMW",
                    shortDesc = "",
                    longDesc = "",
                    img = "",
                    price = 39000,
                    isFavourite = true,
                    available = true,
                    Cathegory = _cathegoryCars.AllCathegories.First()
                },

                 new Car
                {
                    name = "Nissan Leaf",
                    shortDesc = "",
                    longDesc = "",
                    img = "",
                    price = 45000,
                    isFavourite = true,
                    available = true,
                    Cathegory = _cathegoryCars.AllCathegories.First()
                },

            };

        }
            
        }
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
