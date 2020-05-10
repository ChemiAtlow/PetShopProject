using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PetShopProject.Data;
using PetShopProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopProject.Repositories
{
    public class Repository : IRepository
    {
        /// <summary>
        /// Amount of animals aloud on page
        /// </summary>
        public readonly int AnimalsPerPage;
        private readonly PetShopContext petShop;

        public Repository(IConfiguration configuration, PetShopContext petShop)
        {
            AnimalsPerPage = configuration.GetValue("AnimalsPerPage", 6);
            this.petShop = petShop;
        }

        public async Task AddOrEditAnimalAsync(Animal animal)
        {
            //Check if animal has got an Id, and if so update it.
            if (animal.AnimalId != 0)
            {
                //Check if animal exists loacally, and if it is detach it, so can update it.
                Animal local = petShop.Set<Animal>().Local.FirstOrDefault(entry => entry.AnimalId.Equals(animal.AnimalId));
                if (local != null)
                {
                    // detach
                    petShop.Entry(local).State = EntityState.Detached;
                }
                // set Modified flag in your entry
                petShop.Entry(animal).State = EntityState.Modified;
            }
            else
            {
                await petShop.Animals.AddAsync(animal); ;
            }
            await petShop.SaveChangesAsync();
        }

        public async Task<string> DeleteAnimalAsync(int animalId)
        {
            Animal animal = await petShop.Animals.Include(animal => animal.Comments).FirstOrDefaultAsync(animal => animal.AnimalId == animalId);
            if (animal == null) throw new ArgumentException("No animal with the given id could have been found.", nameof(animalId));
            string pictureName = animal.PictureName;
            petShop.Comments.RemoveRange(animal.Comments);
            petShop.Animals.Remove(animal);
            await petShop.SaveChangesAsync();
            return pictureName;
        }

        public async Task<Animal> GetAnimalDetailsAsync(int animalId)
        {
            Animal animal = await petShop.Animals
                .Include(animal => animal.Comments)
                .Include(animal => animal.Category)
                .FirstOrDefaultAsync(animal => animal.AnimalId == animalId);
            if (animal == null) throw new ArgumentException("No animal with the given ID could have been found!", nameof(animalId));
            return animal;
        }

        public (PaginationData paginationData, IEnumerable<Animal> animals) GetAnimals(int category = 0, int page = 1)
        {
            //Disallow a page smaller than 1.
            if (page < 1) throw new ArgumentOutOfRangeException(nameof(page), "The page cant be smaller than 1");
            //Make sure requested category exists
            if (category != 0 && petShop.Categories.FirstOrDefault(cat => cat.CategoryId == category) == null)
                throw new ArgumentOutOfRangeException(nameof(category), "No such category exists!");
            //Select relevant animals, and if needed filter by category.
            IEnumerable<Animal> animals = petShop.Animals
                .Include(animal => animal.Category)
                .OrderByDescending(animal => animal.Comments.Count);
            if (category != 0) animals = animals.Where(animal => animal.Category.CategoryId == category);
            //Check last page, and make sure we didn't pass it.
            int lastPage = (animals.Count() - 1) / AnimalsPerPage + 1;
            if (page > lastPage) throw new ArgumentOutOfRangeException(nameof(page), "There is no data for the page requsted.");
            //Return pagination data, and relevant animals.
            PaginationData pagination = new PaginationData(page, lastPage);
            return (pagination, animals.Skip((page - 1) * AnimalsPerPage).Take(AnimalsPerPage));
        }

        public IEnumerable<Animal> GetTwoMostCommentedAnimals()
        {
            return petShop.Animals.Include(animal => animal.Comments).OrderByDescending(animal => animal.Comments.Count).Take(2);
        }

        public IEnumerable<Category> GetCategories()
        {
            return petShop.Categories.OrderBy(ctg => ctg.Name);
        }

        public async Task<Category> GetCategoryAsync(int categoryId)
        {
            if (categoryId <= 0) throw new ArgumentOutOfRangeException(nameof(categoryId), "Id must be a positive number.");
            return await petShop.Categories.FirstOrDefaultAsync(cat => cat.CategoryId == categoryId);
        }

        public async Task AddCommentAsync(string comment, int animalId)
        {
            Animal a = await petShop.Animals.FirstOrDefaultAsync(animal => animal.AnimalId == animalId);
            if (a == null) throw new ArgumentException("No animal has the given ID", nameof(animalId));
            a.Comments.Add(new Comment { CommentText = comment });
            await petShop.SaveChangesAsync();
        }
    }
}
