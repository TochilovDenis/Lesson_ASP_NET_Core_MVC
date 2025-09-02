using MvcApp5_0.Models;

namespace MvcApp5_0.ViewModels
{
    public class CarsViewModel
    {
        public IEnumerable<Cars> Cars_ { get; set; } = new List<Cars>();
        public IEnumerable<Parts> Parts_ { get; set; } = new List<Parts>();
    }
}
