
using System.ComponentModel.DataAnnotations;

namespace PatientRegistration.Models
{
    public class PatientRegistrationModel
    {
        // PATIENT INFORMATION

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

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$",
            ErrorMessage = "Use xxx-xxx-xxxx format.")]
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

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$",
            ErrorMessage = "Use xxx-xxx-xxxx format.")]
        public string? PatientWorkPhone { get; set; }

        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string? PatientEmail { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$",
            ErrorMessage = "Use xxx-xxx-xxxx format.")]
        public string? PatientCellPhone { get; set; }

        public string? EmergencyContactName { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$",
            ErrorMessage = "Use xxx-xxx-xxxx format.")]
        public string? EmergencyPhone { get; set; }

        public string? ReferredBy { get; set; }


        // GUARANTOR INFORMATION

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

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$",
            ErrorMessage = "Use xxx-xxx-xxxx format.")]
        public string? GuarantorHomePhone { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$",
            ErrorMessage = "Use xxx-xx-xxxx format.")]
        public string? GuarantorSSN { get; set; }

        [Required]
        [RegularExpression(@"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d{4}$",
            ErrorMessage = "Use mm/dd/yyyy format.")]
        public string? GuarantorDOB { get; set; }

        public int? GuarantorAge { get; set; }

        [Required]
        public string? GuarantorSex { get; set; }

        [Required]
        public string? GuarantorEmployer { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$",
            ErrorMessage = "Use xxx-xxx-xxxx format.")]
        public string? GuarantorWorkPhone { get; set; }


        // PRIMARY INSURANCE

        public string? PrimaryPlanName { get; set; }

        [Required]
        public string? PrimaryInsuredName { get; set; }

        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$",
            ErrorMessage = "Use xxx-xx-xxxx format.")]
        public string? PrimarySSN { get; set; }

        [Required]
        [RegularExpression(@"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d{4}$",
            ErrorMessage = "Use mm/dd/yyyy format.")]
        public string? PrimaryDOB { get; set; }

        [Required]
        public string? PrimaryPolicyID { get; set; }

        [Required]
        public string? PrimaryGroup { get; set; }

        [RegularExpression(@"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d{4}$",
            ErrorMessage = "Use mm/dd/yyyy format.")]
        public string? PrimaryEffectiveDate { get; set; }

        public string? PrimaryClaimsAddressPhone { get; set; }


        // SECONDARY INSURANCE

        public string? SecondaryPlanName { get; set; }

        [Required]
        public string? SecondaryInsuredName { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$",
            ErrorMessage = "Use xxx-xx-xxxx format.")]
        public string? SecondarySSN { get; set; }

        [Required]
        [RegularExpression(@"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d{4}$",
            ErrorMessage = "Use mm/dd/yyyy format.")]
        public string? SecondaryDOB { get; set; }

        [Required]
        public string? SecondaryPolicyID { get; set; }

        [Required]
        public string? SecondaryGroup { get; set; }

        [Required]
        [RegularExpression(@"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d{4}$",
            ErrorMessage = "Use mm/dd/yyyy format.")]
        public string? SecondaryEffectiveDate { get; set; }

        public string? SecondaryClaimsAddressPhone { get; set; }
    }
}
