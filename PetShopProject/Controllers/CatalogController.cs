using PetShopProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PetShopProject.Controllers
{
    /// <summary>
    /// Controller for catalog page.
    /// </summary>
    public class CatalogController : Controller
    {
        private readonly IRepository repository;

        public CatalogController(IRepository repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// Catalog page. get animals in requested category, by page.
        /// </summary>
        /// <param name="id">Category id, of animals.</param>
        /// <param name="page">Page to show.</param>
        public IActionResult Index(int id = 0, int page = 1)
        {
            try
            {
                var (pagination, animals) = repository.GetAnimals(id, page);
                ViewBag.CurrentCategoryId = id;
                ViewBag.Categories = repository.GetCategories();
                ViewBag.Pagination = pagination;
                return View(animals);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return View("Error", e);
            }
        }
    }
}