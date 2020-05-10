using Microsoft.AspNetCore.Mvc;
using PetShopProject.Repositories;

namespace PetShopProject.Controllers
{
    /// <summary>
    /// Controller for Home page with two most commented animals.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Home page.
        /// </summary>
        public IActionResult Index()
        {
            return View(repository.GetTwoMostCommentedAnimals());
        }
    }
}
