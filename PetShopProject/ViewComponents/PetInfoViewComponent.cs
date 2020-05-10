using PetShopProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PetShopProject.ViewComponents
{
    /// <summary>
    /// View component for showing Pet's information.
    /// </summary>
    public class PetInfoViewComponent : ViewComponent
    {
        /// <summary>
        /// Type of info to show, by location of Pet info.
        /// </summary>
        public enum PetInfoType { HomePage, Catalog, Admin };
        public async Task<IViewComponentResult> InvokeAsync(Animal animal, PetInfoType infoType)
        {
            ViewBag.InfoType = infoType;
            return await Task.FromResult(View(animal));
        }

    }
}
