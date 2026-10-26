
using Microsoft.AspNetCore.Mvc;
using PatientRegistration.Models;
using System.Globalization;

namespace PatientRegistration.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PatientRegistrationModel model)
        {
            CheckDOB(model.PatientDOB, "PatientDOB", false);
            CheckDOB(model.GuarantorDOB, "GuarantorDOB", false);
            CheckDOB(model.PrimaryDOB, "PrimaryDOB", true);
            CheckDOB(model.SecondaryDOB, "SecondaryDOB", false);

            CheckDate(model.PrimaryEffectiveDate, "PrimaryEffectiveDate");
            CheckDate(model.SecondaryEffectiveDate, "SecondaryEffectiveDate");

            if (ModelState.IsValid)
            {
                ViewBag.Message = "Successfully Registered!";
            }

            return View(model);
        }

        private void CheckDOB(string? value, string field, bool checkAge)
        {
            if (string.IsNullOrWhiteSpace(value))
                return;

            if (DateTime.TryParseExact(value, "MM/dd/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime dob))
            {
                if (dob.Date >= DateTime.Today)
                {
                    ModelState.AddModelError(field,
                        "Date of birth must be before today.");
                }
                else if (checkAge && dob.Date > DateTime.Today.AddYears(-21))
                {
                    ModelState.AddModelError(field,
                        "Primary insured must be at least 21 years old.");
                }
            }
            else
            {
                ModelState.AddModelError(field,
                    "Enter a valid date in mm/dd/yyyy format.");
            }
        }

        private void CheckDate(string? value, string field)
        {
            if (string.IsNullOrWhiteSpace(value))
                return;

            if (!DateTime.TryParseExact(value, "MM/dd/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out _))
            {
                ModelState.AddModelError(field,
                    "Enter a valid date in mm/dd/yyyy format.");
            }
        }
    }
}
