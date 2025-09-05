using MvcApp5_0.Models;

namespace MvcApp5_0.Services
{
    public class CarsServices
    {

        public List<Cars> cars_ = null;
        public List<Parts> parts_ = null;


        public CarsServices()
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
    }
}
