using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace PetShopProject.Attributes
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        public string DefaultErrorMessage => $"משקל קובץ מקסימלי: { _maxFileSize} בייט.";
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is IFormFile file && file.Length > _maxFileSize)
                return new ValidationResult(ErrorMessage ?? DefaultErrorMessage);
            return ValidationResult.Success;
        }

    }
}
