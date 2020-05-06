using PetShopProject.Models;
using System.Collections.Generic;

namespace PetShopProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual List<Animal> Animals { get; set; }
    }
}
