using shop.Data.Models;
using shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.mocks
{
    //класс реализует интерфейс для работы с категориями
    public class MockCathegory : ICarsCathegory
    {
        public IEnumerable<Cathegory> AllCathegories
        {
            get
            {
                return new List<Cathegory>
                {
                     new Cathegory {CathegoryName = "Electrocars", desc="Modern type of transport" },
                     new Cathegory {CathegoryName = "Classic autos", desc = "Cars with internal combustion engines" }
                };
            }
        }
            
            
     }
}
