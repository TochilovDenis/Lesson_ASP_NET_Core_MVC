using Microsoft.AspNetCore.Mvc;
using MvcApp5_0.Models;
using MvcApp5_0.ViewModels;


namespace MvcApp5_0.Controllers
{
    [Route("Cars")]
    public class CarsController : Controller
    {
        List<Cars> cars_ = null;
        List<Parts> parts_ = null;


        public CarsController()
        {
            Parts wheel = new Parts(1, "wheel", "Колесо автомобиля", 2000);
            Parts suspension = new Parts(2, "suspension", "Подвеска", 5000);

            parts_ = new List<Parts> { wheel, suspension };

            cars_ = new List<Cars>
            {
                new Cars(1, "Lada", wheel),
                new Cars(2, "BMW", suspension)
            };
        }


        [HttpGet]
        public ActionResult Index()
        {
            CarsViewModel viewModel = new() { Cars_ = cars_, Parts_ = parts_ };
            return View("Cars", viewModel);
        }


        [HttpPost]
        public ActionResult AddCar(int id, string carName, int partId, string partName, string partDefinition, int partPrice)
        {
            Parts carParts = new Parts(partId, partName, partDefinition, partPrice);
            parts_.Add(carParts);

            Cars car = new Cars(id, carName, carParts);
            cars_.Add(car);

            CarsViewModel viewModel = new(){ Cars_ = cars_, Parts_ = parts_ };

            return View("Cars", viewModel);

        }
    }
}
