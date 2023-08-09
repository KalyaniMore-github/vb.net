using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller  //here Controller is base class(performing inheritance)
                                                 //this class is called as controller class
    {
        public IActionResult Index()//this method is called as action(we called action)(technically it is a method)
        {
            return View();
        }
       
        public IActionResult Students()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
