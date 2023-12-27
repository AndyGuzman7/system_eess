using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FrutiLightWPF.utils
{
    public static class InputValidators
    {

        public static bool IsRequired(string value)
        {
            return value != null && !string.IsNullOrEmpty(value);
        }

        public static bool IsMinLength(string value, int minLength)
        {
            return value != null && value.Length >= minLength;
        }

        public static bool IsMaxLength(string value, int maxLength)
        {
            return value != null && value.Length <= maxLength;
        }

        public static bool IsEmail(string value)
        {
            if (value == null || string.IsNullOrEmpty(value))
            {
                return false;
            }

            var emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$");
            return emailRegex.IsMatch(value);
        }

        public static bool IsNumeric(string value)
        {
            if (value == null || string.IsNullOrEmpty(value))
            {
                return false;
            }

            var numericRegex = new Regex(@"^[0-9]+$");
            return numericRegex.IsMatch(value);
        }

        public static bool IsAlphabetic(string value)
        {
            if (value == null || string.IsNullOrEmpty(value))
            {
                return false;
            }

            var alphabeticRegex = new Regex(@"^[a-zA-Z]+$");
            return alphabeticRegex.IsMatch(value);
        }

        public static bool IsDouble(string value)
        {
            if (value == null || string.IsNullOrEmpty(value))
            {
                return false;
            }

            return double.TryParse(value, out _);
        }

        public static bool IsAlphaNumeric(string value)
        {
            if (value == null || string.IsNullOrEmpty(value))
            {
                return false;
            }

            var alphaNumericRegex = new Regex(@"^[a-zA-Z0-9]+$");
            return alphaNumericRegex.IsMatch(value);
        }
        public static bool ContainsSpecialCharacters(string value)
        {
            if (value == null || string.IsNullOrEmpty(value))
            {
                return false;
            }

            var specialCharactersRegex = new Regex(@"[!@#$%^&*(),.?""':{}|<>]");
            return !specialCharactersRegex.IsMatch(value);
        }


    }
}
