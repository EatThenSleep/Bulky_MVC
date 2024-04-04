using Bulky.Models;
using System.ComponentModel.DataAnnotations;


namespace BulkyWeb.Validation
{
    sealed public class UniqueNameAndDisplayCategoryAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
           Category category = (Category)validationContext.ObjectInstance;

            if(category.Name == category.DisplayOrder.ToString())
            {
                return new ValidationResult("The DisplayOrder cannot exactly match the name"); ;
            }
            return ValidationResult.Success;
        }
    }
}
