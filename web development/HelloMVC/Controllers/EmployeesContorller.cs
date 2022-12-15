using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            string[] employeeNames = { "Bishnu Rawal", "Sangyel Tenzing", "Sakshyam Shrestha", "Sitaram Panta" };

            return View(employeeNames);
        }
        public IActionResult Contact()
        {
            Dictionary<string, int> employeeContactInfo = new();
            employeeContactInfo.Add("Bishu Rawal", 981026598); //key has to be unique, value can be repeated
            employeeContactInfo.Add("Sangyel Tenzing", 985102469);
            employeeContactInfo.Add("Sakshyam Shrestha", 898146978);
            employeeContactInfo.Add("Sitaram Panta", 810245879);

            return View(employeeContactInfo);


        }
    }
}
