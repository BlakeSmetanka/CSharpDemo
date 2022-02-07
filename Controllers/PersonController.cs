using Microsoft.AspNetCore.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index(PersonModel model)
        {
            return View(model);
        }

        // Specify HTTP method
        /*[HttpGet]
        public IActionResult Index(string name)
        {
            PersonModel person = new PersonModel(); // new Model.PersonModel();
            person.FirstName = name;
            return View(person);
        }*/
    }
}
