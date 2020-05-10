using PetShopProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PetShopProject.ViewComponents
{
    /// <summary>
    /// View components for pagination.
    /// </summary>
    public class PaginationViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PaginationData pagination)
        {
            return await Task.FromResult(View(pagination));
        }
    }
}
