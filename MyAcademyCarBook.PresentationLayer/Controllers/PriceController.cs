using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class PriceController : Controller
    {
        private readonly IPriceService _priceService;
        private readonly ICarService _carService;
        public PriceController(IPriceService priceService, ICarService carService)
        {
            _priceService = priceService;
            _carService = carService;
        }
        public IActionResult Index()
        {
            var values = _priceService.TGetPricesWithCars();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePrice()
        {
            List<SelectListItem> values = (from x in _carService.TGetAllCarsWithBrands()
                                           select new SelectListItem
                                           {
                                               Text = x.Brand.BrandName + " " + x.Model,
                                               Value = x.CarID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult CreatePrice(Price price)
        {
            _priceService.TInsert(price);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePrice(int id)
        {
            var value = _priceService.TGetByID(id);
            _priceService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePrice(int id)
        {
            List<SelectListItem> values = (from x in _carService.TGetAllCarsWithBrands()
                                           select new SelectListItem
                                           {
                                               Text = x.Brand.BrandName + " " + x.Model,
                                               Value = x.CarID.ToString()
                                           }).ToList();
            ViewBag.v = values;
         
            var value = _priceService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePrice(Price price)
        {
            _priceService.TUpdate(price);
            return RedirectToAction("Index");
        }
    }
}
/*
1-Abdullah
2-Adem 
3-Akif
4-Bora
5-Burak
6-Ecenur
7-Enes
8-Erhan
9-Furkan İnce
10-Furkan Özdemir
11-Hızır
12-İpek
13-Fatih
14-Mert
15-Oğuzhan
16-Okan
17-Ömer
18-Özlem
19-Saadet
20-Taha
21-Ufuk
22-Yusuf
23-Zehra
24-Berkan
25-Kerem
26-Onur
27-Talat
28-Saim
29-Tuğra
30-Emine
31-Mahmut
32-Hakan
33-Ece
34-Hakan Ayvaz
 */