using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shop.Interfaces;
using shop.ViewModels;


namespace shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCathegory allCarsCathegory;

        public CarsController(IAllCars iAllCars, ICarsCathegory iCarsCat)
        {
            _allCars = iAllCars;
            allCarsCathegory = iCarsCat;
        }

        public ViewResult List () //вызов страницы список всех товаров
        {
            //ViewBag.Cathegory = "Some New ";
            //var cars = _allCars.Cars;

            //создаем объект на основе CarsViewModel и помещаем все данные для передачи 
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCathegory = "Автомобили";
            //передаем в шаблон и обрабатываем объект


            return View(obj);
        }




    }
}
