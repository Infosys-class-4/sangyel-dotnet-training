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
            List<Employee> employees = new();

            Employee employee1 = new();
            employee1.Name = "Sitaram Panta";
            employee1.Phone = "9854123654";
            employee1.Address = "Bhaktapur";

            Employee employee2 = new();
            employee1.Name = "Sitaram Panta";
            employee1.Phone = "9854123654";
            employee1.Address = "Bhaktapur";

            employees.Add(employee1);
            employees.Add(employee2);  

            /*Dictionary<long, string> employeeContactInfo = new()
            {
                [9810265987] = "Bisnhu Rawal", //key has to be unique, value can be repeated
                [9810265986] = "Sangyel Tenzing",
                [9810265985] = "Sitaram Panta",
                [9810265984] = "Prahlad Shakya",
                [9810265983] = "Sakshyam Shrestha"
            };
            return View(employeeContactInfo);*/
            return View(employees);

        }
    }
}
