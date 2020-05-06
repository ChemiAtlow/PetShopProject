﻿using PetShopProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PetShopProject.ViewComponents
{
    public class CommentViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Comment comment)
        {
            return await Task.FromResult(View(comment));
        }
    }
}
