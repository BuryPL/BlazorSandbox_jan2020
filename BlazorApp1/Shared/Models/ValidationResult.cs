using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared.Models
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public string ValidationMessage { get; set; }
    }
}
