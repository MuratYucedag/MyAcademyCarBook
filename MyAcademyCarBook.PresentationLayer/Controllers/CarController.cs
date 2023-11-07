using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarDetailService _carDetailService;
        public CarController(ICarService carService, ICarDetailService carDetailService)
        {
            _carService = carService;
            _carDetailService = carDetailService;
        }
        public IActionResult Index()
        {
            var values = _carService.TGetListAll();
            return View(values);
        }
        public IActionResult Index2()
        {
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }
        public IActionResult CarList()
        {
            ViewBag.title1 = "Araç Listesi";
            ViewBag.title2 = "Sizin İçin Araç Listemiz";
            var values=_carService.TGetAllCarsWithBrands();
            return View(values);
        }
        public IActionResult CarDetail(int id)
        {
            ViewBag.title1 = "Araba Detayları";
            ViewBag.title2 = "Son Araç Detayları";
            var value=_carDetailService.TGetCarDetailByCarID(id);
            ViewBag.v = value.Description;
            return View();
        }
    }
}
