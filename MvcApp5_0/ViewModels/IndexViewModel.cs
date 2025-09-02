using MvcApp5_0.Models;
using static MvcApp5_0.Models.Models;

namespace MvcApp5_0.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Person1> People { get; set; } = new List<Person1>();
        public IEnumerable<CompanyModel> Companies { get; set; } = new List<CompanyModel>();
    }
}
