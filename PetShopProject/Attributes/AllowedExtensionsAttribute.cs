using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace PetShopProject.Attributes
{
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;
        private const string DefaultErrorMessage = "סוג קובץ זה אינו מורשה!";
        public AllowedExtensionsAttribute(params string[] extensions)
        {
            _extensions = extensions;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {
                string extension = Path.GetExtension(file.FileName);
                if (file != null && !_extensions.Contains(extension.ToLowerInvariant()))
                    return new ValidationResult(ErrorMessage ?? DefaultErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
