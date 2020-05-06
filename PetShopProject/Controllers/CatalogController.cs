using PetShopProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PetShopProject.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IRepository repository;

        public CatalogController(IRepository repository)
        {
            this.repository = repository;
        }
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