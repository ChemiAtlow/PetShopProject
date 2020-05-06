using System;
using System.Threading.Tasks;
using PetShopProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PetShopProject.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IRepository repository;

        public AnimalController(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IActionResult> Index(int id)
        {
            try
            {
                return View(await repository.GetAnimalDetailsAsync(id));
            }
            catch (Exception e)
            {
                return View("Error", e);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(string commentText, int animalId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await repository.AddCommentAsync(commentText.Trim(), animalId);
                    return RedirectToAction("Index", new { id = animalId });
                }
                throw new ArgumentException("The fields are invalid!");
            }
            catch (Exception e)
            {
                return View("Error", e);
            }
        }
    }
}