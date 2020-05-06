using PetShopProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PetShopProject.ViewComponents
{
    public class PaginationViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PaginationData pagination)
        {
            return await Task.FromResult(View(pagination));
        }
    }
}
