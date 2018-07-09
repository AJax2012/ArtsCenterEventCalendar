using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtsCenterEventCalendar.Models
{
    public class AfterNow : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var performance = (Performance) validationContext.ObjectInstance;
            
            return performance.EventDateTime > DateTime.Now 
                ? ValidationResult.Success 
                : new ValidationResult("Event date/time must be after current time.");
        }
    }
}