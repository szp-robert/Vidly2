using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class Min18YearsIfMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId==MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.Birthday==null)
                return new ValidationResult("Birthday is required");

            var age = DateTime.Now.Year - customer.Birthday.Value.Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer must be at least 18 years old to go on a membership");

        }
    }
}