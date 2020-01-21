using System;
using System.Collections.Generic;
using System.Text;
using BlazorApp1.Shared.Models;

namespace LogicAndShit.Validation
{
    public interface IValidations
    {
        ValidationResult ValidateTheForm(TheForm submittedForm);
    }

    public class Validations : IValidations
    {
        public ValidationResult ValidateTheForm(TheForm submittedForm)
        {
            var result = new ValidationResult();
            if (submittedForm == null)
            {
                result.IsValid = false;
                result.ValidationMessage = "Ups, the model is null";
                return result;
            }

            if (string.IsNullOrWhiteSpace(submittedForm.SimpleInput))
            {
                result.IsValid = false;
                result.ValidationMessage = "You naughty boi, put something into the field!";
                return result;
            }

            result.IsValid = true;
            result.ValidationMessage = $"Grrrrrrrate success! You put in {submittedForm.SimpleInput}";
            return result;
        }
    }
}
