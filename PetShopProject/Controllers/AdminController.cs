﻿using System;
using System.IO;
using System.Threading.Tasks;
using PetShopProject.Models;
using PetShopProject.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetShopProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRepository repository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AdminController(IRepository repository, IWebHostEnvironment webHostEnvironment)
        {
            this.repository = repository;
            this.webHostEnvironment = webHostEnvironment;
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            try
            {
                string pictureName = await repository.DeleteAnimalAsync(id);
                DeleteOldImage(pictureName);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("Error", e);
            }
        }
        [HttpGet]
        public async Task<IActionResult> EditAnimal(int id = 0)
        {
            ViewBag.Categories = repository.GetCategories();
            Animal animal = new Animal();
            if (id != 0)
            {
                animal = await repository.GetAnimalDetailsAsync(id);
                animal.FormCategoryId = animal.Category.CategoryId;
            }

            return View(animal);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAnimal(Animal animal)
        {
            if (ModelState.IsValid)
            {
                if (animal.FormFile != null)
                {
                    if (animal.PictureName != null)
                    {
                        DeleteOldImage(animal.PictureName);
                    }
                    string imageName = await UploadImage(animal.FormFile);
                    animal.PictureName = imageName;
                }
                await repository.AddOrEditAnimalAsync(animal);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = repository.GetCategories();
            return View(animal);
        }

        /// <summary>
        /// Upload an image for a new or edited animal.
        /// </summary>
        /// <param name="formFile">File to be uploaded.</param>
        /// <returns>Name of file to be saved in DB.</returns>
        private async Task<string> UploadImage(IFormFile formFile)
        {
            string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + formFile.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await formFile.CopyToAsync(fileStream);
            return uniqueFileName;
        }
        /// <summary>
        /// Delete the old picture of animal when deleted or updated it's picture.
        /// </summary>
        /// <param name="oldPictureName">Name of the olf picture's file.</param>
        private void DeleteOldImage(string oldPictureName)
        {
            string fullPath = Path.Combine(webHostEnvironment.WebRootPath, "images", oldPictureName);
            if (System.IO.File.Exists(fullPath))
                System.IO.File.Delete(fullPath);
        }
    }
}