
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared.Models
{
    public class TheForm
    {
        public string SimpleInput { get; set; }
        [Required(ErrorMessage = "You got to pick something")]
        [Range(typeof(bool), "true", "true",
            ErrorMessage = "This form disallows unapproved ships.")]
        public bool Checkbox { get; set; }

        public string DropdownCountryName { get; set; }
        public int NumberInput { get; set; }
        public DateTime DatePicker { get; set; } = DateTime.Now;
    }
}
