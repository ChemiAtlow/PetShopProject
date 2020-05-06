using System;
using System.ComponentModel.DataAnnotations;

namespace PetShopProject.Attributes
{
    public class RequiredIfHasIdAttribute : ValidationAttribute
    {
        private const string DefaultErrorMessage = "לא בחרת תמונה!";
        private readonly string _idPropertName;
        public RequiredIfHasIdAttribute(string idPropertName)
        {
            _idPropertName = idPropertName;
        }
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            object instance = context.ObjectInstance;
            Type type = instance.GetType();

            int.TryParse(type.GetProperty(_idPropertName).GetValue(instance)?.ToString(), out int propertyValue);

            if (propertyValue == 0 && string.IsNullOrWhiteSpace(value?.ToString()))
            {
                return new ValidationResult(ErrorMessage ?? DefaultErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
