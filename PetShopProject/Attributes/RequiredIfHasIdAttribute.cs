using System;
using System.ComponentModel.DataAnnotations;

namespace PetShopProject.Attributes
{
    /// <summary>
    /// A validation attribute, to determine if element is required, only if object has an ID.
    /// </summary>
    public class RequiredIfHasIdAttribute : ValidationAttribute
    {
        private const string DefaultErrorMessage = "לא בחרת תמונה!";
        private readonly string _idPropertyName;
        /// <summary>
        /// Create new instance of RequiredIfHasIdAttribute
        /// </summary>
        /// <param name="idPropertyName">Name of ID Property.</param>
        public RequiredIfHasIdAttribute(string idPropertyName)
        {
            _idPropertyName = idPropertyName;
        }
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            object instance = context.ObjectInstance;
            Type type = instance.GetType();

            int.TryParse(type.GetProperty(_idPropertyName).GetValue(instance)?.ToString(), out int propertyValue);

            if (propertyValue == 0 && string.IsNullOrWhiteSpace(value?.ToString()))
            {
                return new ValidationResult(ErrorMessage ?? DefaultErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
