using PetShopProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PetShopProject.ViewComponents
{
    public class PetInfoViewComponent : ViewComponent
    {
        public enum PetInfoType { HomePage, Catalog, Admin };
        public async Task<IViewComponentResult> InvokeAsync(Animal animal, PetInfoType infoType)
        {
            ViewBag.InfoType = infoType;
            return await Task.FromResult(View(animal));
        }

    }
}
