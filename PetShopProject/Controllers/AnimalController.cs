using System;
using System.Threading.Tasks;
using PetShopProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PetShopProject.Controllers
{
    /// <summary>
    /// Controller for animal details - show animal's details, and add a comment for animal.
    /// </summary>
    public class AnimalController : Controller
    {
        private readonly IRepository repository;

        public AnimalController(IRepository repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// Animal details page. show the data of requested animal and relevant comments.
        /// </summary>
        /// <param name="id">Id of animal to show.</param>
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

        /// <summary>
        /// Action for adding a comment, to an animal.
        /// </summary>
        /// <param name="commentText">Text of comment.</param>
        /// <param name="animalId">Id of animal to append comments to.</param>
        [HttpPost]
        public async Task<IActionResult> AddComment(string commentText, int AnimalId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await repository.AddCommentAsync(commentText.Trim(), AnimalId);
                    return RedirectToAction("Index", new { id = AnimalId });
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