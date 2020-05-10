using PetShopProject.Models;
using System.Collections.Generic;

namespace PetShopProject.Models
{
    /// <summary>
    /// Category of animals in pet shop.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Id of the category.
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Name of the category.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Animals belonging to the current category.
        /// </summary>
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
