using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "this is index action";
        }
        public string Salary()
        {
            return "This Salary is 50k";
        }
        public string CompanyName()
        {
            return " The company name is JET2 TRAVEL AND TECHNOLOGIES";
        }
    }
}
