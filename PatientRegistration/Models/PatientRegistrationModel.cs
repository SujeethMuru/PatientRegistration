
using System.ComponentModel.DataAnnotations;

namespace PatientRegistration.Models
{
    public class PatientRegistrationModel
    {
        // Patient Information
        [Required]
        public string? PatientLastName { get; set; }

        [Required]
        public string? PatientFirstName { get; set; }

        public string? PatientMiddleInitial { get; set; }

        [Required]
        public string? PatientAddress { get; set; }

        public string? PatientCity { get; set; }
        public string? PatientState { get; set; }
        public string? PatientZip { get; set; }


        public string? PatientHomePhone { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$",
            ErrorMessage = "Use xxx-xx-xxxx format.")]
        public string? PatientSSN { get; set; }

        [Required]
        [RegularExpression(@"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d{4}$",
            ErrorMessage = "Use mm/dd/yyyy format.")]
        public string? PatientDOB { get; set; }

        public int? PatientAge { get; set; }

        [Required]
        public string? PatientSex { get; set; }

        public string? PatientMaritalStatus { get; set; }
        public string? PatientDriversLicense { get; set; }

        [Required]
        public string? PatientEmployer { get; set; }

        public string? PatientWorkPhone { get; set; }

        [EmailAddress]
        public string? PatientEmail { get; set; }

        public string? PatientCellPhone { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyPhone { get; set; }
        public string? ReferredBy { get; set; }


        // Guarantor Information
        [Required]
        public string? GuarantorRelationship { get; set; }

        [Required]
        public string? GuarantorLastName { get; set; }

        [Required]
        public string? GuarantorFirstName { get; set; }

        public string? GuarantorMiddleInitial { get; set; }

        [Required]
        public string? GuarantorAddress { get; set; }

        public string? GuarantorCity { get; set; }
        public string? GuarantorState { get; set; }
        public string? GuarantorZip { get; set; }

        public string? GuarantorHomePhone { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$",
            ErrorMessage = "Use xxx-xx-xxxx format.")]
        public string? GuarantorSSN { get; set; }

        [Required]
        public string? GuarantorDOB { get; set; }

        public int? GuarantorAge { get; set; }

        [Required]
        public string? GuarantorSex { get; set; }

        [Required]
        public string? GuarantorEmployer { get; set; }

        public string? GuarantorWorkPhone { get; set; }


        // Primary Insurance
        public string? PrimaryPlanName { get; set; }

        [Required]
        public string? PrimaryInsuredName { get; set; }

        public string? PrimarySSN { get; set; }

        [Required]
        public string? PrimaryDOB { get; set; }

        [Required]
        public string? PrimaryPolicyID { get; set; }

        [Required]
        public string? PrimaryGroup { get; set; }

        public string? PrimaryEffectiveDate { get; set; }
        public string? PrimaryClaimsAddressPhone { get; set; }


        // Secondary Insurance
        public string? SecondaryPlanName { get; set; }

        [Required]
        public string? SecondaryInsuredName { get; set; }

        [Required]
        public string? SecondarySSN { get; set; }

        [Required]
        public string? SecondaryDOB { get; set; }

        [Required]
        public string? SecondaryPolicyID { get; set; }

        [Required]
        public string? SecondaryGroup { get; set; }

        [Required]
        public string? SecondaryEffectiveDate { get; set; }

        public string? SecondaryClaimsAddressPhone { get; set; }

    }
}
