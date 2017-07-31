using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if (customer.BirthDate == null)
            {
                return new ValidationResult("BirthDate is Required!");
            }

            // we need BirthDate Property as a datetype format for this type of validation

            //var age = DateTime.Today.Year - customer.BirthDate.Year;

            //return (age >= 18)
            //    ? ValidationResult.Success
            //    : new ValidationResult("Customer Should be at least 18 years old for Membership");
            return ValidationResult.Success;
        }
    }
}