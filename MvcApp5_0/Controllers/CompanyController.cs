using Microsoft.AspNetCore.Mvc;
using MvcApp5_0.Models;
using MvcApp5_0.ViewModels;
using static MvcApp5_0.Models.Models;

namespace MvcApp5_0.Controllers
{
    [Route("Company")]
    public class CompanyController : Controller
    {
        List<Person1> people;
        List<Company> companies;
        public CompanyController()
        {
            Company microsoft = new Company(1, "Microsoft", "USA");
            Company google = new Company(2, "Google", "USA");
            Company jetbrains = new Company(3, "JetBrains", "Czech Republic");
            companies = new List<Company> { microsoft, google, jetbrains };

            people = new List<Person1>
            {
                new Person1(1, "Tom", 37, microsoft),
                new Person1(2, "Bob", 41, microsoft),
                new Person1(3, "Sam", 28, google),
                new Person1(4, "Bill", 32, google),
                new Person1(5, "Kate", 33, jetbrains),
                new Person1(6, "Alex", 25, jetbrains),
            };
        }


        public IActionResult Index(int? companyId)
        {
            // формируем список компаний для передачи в представление
            List<CompanyModel> compModels = companies.Select(c => new CompanyModel(c.Id, c.Name)).ToList();
            // добавляем на первое место
            compModels.Insert(0, new CompanyModel(0, "Все"));

            IndexViewModel viewModel = new() { Companies = compModels, People = people };

            // если передан id компании, фильтруем список
            if (companyId != null && companyId > 0)
                viewModel.People = people.Where(p => p.Work.Id == companyId);

            return View("Company", viewModel);
        }
    }
}
