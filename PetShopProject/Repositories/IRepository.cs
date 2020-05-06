using PetShopProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetShopProject.Repositories
{
    public interface IRepository
    {
        /// <summary>
        /// Get the two most commented animals. Used for the Home page.
        /// </summary>
        /// <returns>An IEnumerable with the two most commented animals.</returns>
        public IEnumerable<Animal> GetTwoMostCommentedAnimals();
        /// <summary>
        /// Get An IEnumrable of animals, and pagination data based on current page.
        /// </summary>
        /// <param name="category">Category of animals to search for. 0 is to show all.</param>
        /// <param name="page">page of website currently looking at.</param>
        /// <returns>An IEnumerable with the animals to show on current page, and data regarding pagination.</returns>
        public (PaginationData paginationData, IEnumerable<Animal> animals) GetAnimals(int category = 0, int page = 1);
        /// <summary>
        /// Get the full details of an animal.
        /// </summary>
        /// <param name="animalId">The id of requested animal.</param>
        /// <returns>An animal object, of requested animal.</returns>
        public Task<Animal> GetAnimalDetailsAsync(int animalId);
        /// <summary>
        /// Add or edit an animal to the pet shop.
        /// if the animal has an existing id, it will be edited.
        /// </summary>
        /// <param name="animal">Animal to be added.</param>
        /// <returns>A task, to allow async abilities</returns>
        public Task AddOrEditAnimalAsync(Animal animal);
        /// <summary>
        /// Delete an animal from the pet shop, and get the name of it's picture to be deleted.
        /// </summary>
        /// <param name="animalId">Id of animal to be deleted.</param>
        /// <returns>The name of the picture of the animal</returns>
        public Task<string> DeleteAnimalAsync(int animalId);
        /// <summary>
        /// Get all the Categories available.
        /// </summary>
        /// <returns>An IEnumerable of all available Categories.</returns>
        public IEnumerable<Category> GetCategories();
        /// <summary>
        /// Get a category with requested ID.
        /// </summary>
        /// <param name="categoryId">Id of requested category.</param>
        /// <returns>A category with given id.</returns>
        Task<Category> GetCategoryAsync(int categoryId);
        /// <summary>
        /// Add a new comment to system.
        /// </summary>
        /// <param name="comment">The comment to add.</param>
        /// <param name="animalId">The ID of animal comment was targeted to.</param>
        /// <returns>A task, to allow async abilities</returns>
        public Task AddCommentAsync(string comment, int animalId);
    }
}
