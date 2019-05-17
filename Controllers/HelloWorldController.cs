using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }
    }
}