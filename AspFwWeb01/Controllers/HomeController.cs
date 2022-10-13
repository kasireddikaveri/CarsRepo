using AspFwWeb01.Models;
using DataLayer.Repository.Implementations;
using DataLayer.Repository.Interfaces;
using DataLayerProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspFwWeb01.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetCarsRepository getCarsRepository;
        private readonly IGetCarByIdRepository getCarByIdRepository;

        public HomeController(IGetCarsRepository getCarsRepository, IGetCarByIdRepository getCarByIdRepository)
        {
            this.getCarsRepository = getCarsRepository;
            this.getCarByIdRepository = getCarByIdRepository;
        }

        public ActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Cars = getCarsRepository.GetCars();

            return View(homeViewModel);
        }

        public ActionResult ItemDetails(int id)
        {           
            CarDetailsViewModel carDetailsViewModel = new CarDetailsViewModel();
            carDetailsViewModel.Car = getCarByIdRepository.GetCar(id);
            return View("CarDetails", carDetailsViewModel);
        }

        //Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}