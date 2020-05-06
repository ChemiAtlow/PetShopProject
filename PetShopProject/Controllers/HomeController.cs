using Microsoft.AspNetCore.Mvc;
using PetShopProject.Repositories;

namespace PetShopProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.GetTwoMostCommentedAnimals());
        }
    }
}
