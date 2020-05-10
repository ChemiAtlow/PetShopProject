using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace PetShopProject.Attributes
{
    /// <summary>
    /// A validation attribute, to check if file uploaded has an allowed extension.
    /// </summary>
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;
        private const string DefaultErrorMessage = "סוג קובץ זה אינו מורשה!";
        /// <summary>
        /// Create new instance of the AllowedExtensionsAttribute.
        /// </summary>
        /// <param name="extensions">Extensions "white list" for the file.</param>
        public AllowedExtensionsAttribute(params string[] extensions)
        {
            _extensions = extensions;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //Check if value is actually a file, and if so check it's extension.
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
