using Microsoft.AspNetCore.Mvc;
using MvcApp5_0.Models;
using MvcApp5_0.Services;
using MvcApp5_0.ViewModels;


namespace MvcApp5_0.Controllers
{
    [Route("Cars")]
    public class CarsController : Controller
    {
        private readonly CarsServices _carsServices;

        public CarsController(CarsServices carsServices)
        {
            _carsServices = carsServices;
        }


        [HttpGet]
        public ActionResult Index()
        {
            CarsViewModel viewModel = new() { Cars_ = _carsServices.cars_, Parts_ = _carsServices.parts_ };
            return View("Cars", viewModel);
        }


      /*[HttpPost]
        public ActionResult AddCar(int id, string carName, int partId, string partName, string partDefinition, int partPrice)
        {
            Parts carParts = new Parts(partId, partName, partDefinition, partPrice);
            _carsServices.parts_.Add(carParts);

            Cars car = new Cars(id, carName, carParts);
            _carsServices.cars_.Add(car);

            CarsViewModel viewModel = new(){ Cars_ = _carsServices.cars_, Parts_ = _carsServices.parts_ };

            return View("Cars", viewModel);
        }*/


        [HttpPost]
        public ActionResult AddCar(Cars cars)
        {
            // Проверка валидности модели
            if (!ModelState.IsValid)
            {
                CarsViewModel viewModel = new()
                {
                    Cars_ = _carsServices.cars_,
                    Parts_ = _carsServices.parts_
                };
                return View("Cars", viewModel);
            }

            // Обработка данных
            _carsServices.parts_.Add(cars.parts);
            _carsServices.cars_.Add(cars);

            CarsViewModel successViewModel = new()
            {
                Cars_ = _carsServices.cars_,
                Parts_ = _carsServices.parts_
            };

            return View("Cars", successViewModel);

        }
    }
}
