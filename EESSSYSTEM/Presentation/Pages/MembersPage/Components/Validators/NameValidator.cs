using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EESSSYSTEM.Presentation.Pages.MembersPage.Components.Validators
{
    public class NameValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string name = value as string;

            if (string.IsNullOrWhiteSpace(name))
            {
                return new ValidationResult(false, "El nombre es obligatorio.");
            }

            return ValidationResult.ValidResult;
        }
    }

}
