using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Brand> _brand;

        public HomeController()
        {
            _brand = new List<Brand>
            {
                new Brand { Id =1, Name="Bmw"},
                new Brand { Id =2, Name="Kia"},
                new Brand { Id =3, Name="Mercedes"},
                new Brand { Id =4, Name="Hyundai"},
                new Brand { Id =5, Name="Lexus"},
                new Brand { Id =6, Name="Tayota"},

            };
        }
        public IActionResult Index()
        {
            return View(_brand);
        }
    }
}
