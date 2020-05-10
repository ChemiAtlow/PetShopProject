using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace PetShopProject.Attributes
{
    /// <summary>
    /// A validation attribute, to check if file is with in file size limit.
    /// </summary>
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        public string DefaultErrorMessage => $"משקל קובץ מקסימלי: { _maxFileSize} בייט.";
        private readonly int _maxFileSize;
        /// <summary>
        /// Create new instance of MaxFileSizeAttribute, and determine maximal file size.
        /// </summary>
        /// <param name="maxFileSize">Maximal size of file, in Bytes.</param>
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
