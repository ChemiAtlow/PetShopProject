using PetShopProject.Models;
using PetShopProject.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace PetShopProject.Attributes
{
    public class ValidCategoryAttribute : ValidationAttribute
    {
        private const string DefaultCategoryNotFoundMessage = "קטגוריה זו לא קיימת!";
        private const string DefaultErrorMessage = "יש להזין קטגוריה!";

        public string CategoryNotFoundMessage { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var configService = validationContext.GetService<IRepository>();
            if (value is int categoryId)
            {
                Task<Category> t = CheckCategory(categoryId, configService);
                t.Wait();
                if (validationContext.ObjectInstance is Animal animal)
                    animal.Category = t.Result;
                return t.Result != null ? ValidationResult.Success : new ValidationResult(CategoryNotFoundMessage ?? DefaultCategoryNotFoundMessage);
            }
            else
            {
                return new ValidationResult(ErrorMessage ?? DefaultErrorMessage);
            }
        }

        private async Task<Category> CheckCategory(int categoryId, IRepository repository)
        {
            return await repository.GetCategoryAsync(categoryId);
        }
    }
}
