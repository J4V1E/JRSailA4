using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JRClassLibrary;

namespace JRSail.Models
{
    public class JRMemberMetadata
    {
        [HiddenInput(DisplayValue = true)]
        public int MemberId { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string FullName { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Spouse First Name")]
        public string SpouseFirstName { get; set; }
        [Display(Name = "Spouse Last Name")]
        public string SpouseLastName { get; set; }
        [Display(Name = "Street Address")]
        public string Street { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Province Code")]
        public string ProvinceCode { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public int? YearJoined { get; set; }
        public string Comment { get; set; }
        public bool TaskExempt { get; set; }
        public bool UseCanadaPost { get; set; }
    }
    [ModelMetadataType(typeof(JRMemberMetadata))]
    public partial class Member : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FirstName == null || FirstName.Trim() == "")
                yield return new
                ValidationResult("First name cannot be empty or just blanks", new[] { nameof(FirstName) });
            else
                FirstName = FirstName.Trim();

            //FullName = FullName.Trim();
            LastName.Trim();

            FirstName = JRValidations.JRCapitalize(FirstName.Trim());
            //FullName = JRValidations.JRCapitalize(FullName.Trim());
            LastName = JRValidations.JRCapitalize(LastName.Trim());
            LastName = JRValidations.JRCapitalize(SpouseFirstName.Trim());
            LastName = JRValidations.JRCapitalize(SpouseLastName.Trim());
            LastName = JRValidations.JRCapitalize(Street.Trim());
            LastName = JRValidations.JRCapitalize(City.Trim());
            //yield return ValidationResult.Success;
        }
    }
}   
