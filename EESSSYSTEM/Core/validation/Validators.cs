using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrutiLightWPF.utils
{
    public static class Validators
    {
        public static Func<string, string> ValidationEmail => (string value) =>
        {
            if (!InputValidators.IsRequired(value))
            {
                return "No se permite vacios";
            }

            if (!InputValidators.IsEmail(value))
            {
                return "Introduzca un email valido";
            }
            return null;
        };

        public static Func<string, string> ValidationNumber => (string value) =>
        {
            if (!InputValidators.IsRequired(value))
            {
                return "No se permite vacío";
            }

            if (!InputValidators.IsNumeric(value))
            {
                return "Introduzca un número válido";
            }
            return null;
        };

        public static Func<string, string> ValidationNumberDouble => (string value) =>
        {
            if (!InputValidators.IsRequired(value))
            {
                return "No se permite vacío";
            }

            if (!InputValidators.IsDouble(value))
            {
                return "Introduzca un número válido";
            }
            return null;
        };

        public static Func<string, string> ValidationPassword => (string value) =>
        {
            if (!InputValidators.IsRequired(value))
            {
                return "No se permite vacios";
            }
            return null;
        };

        public static Func<string, string> ValidationText => (string value) =>
        {
            if (!InputValidators.IsRequired(value))
            {
                return "No se permite vacios";
            }
            return null;
        };

        public static Func<string, string> ValidationPhone => (string value) =>
        {
            if (!InputValidators.IsRequired(value))
            {
                return "No se permite vacios";
            }
            return null;
        };

        public static Func<object, string> ValidationNull => (object value) =>
        {
            Console.WriteLine(value);
            if (value == null)
            {
                return "Este campo es necesario";
            }
            return null;
        };


        public static Func<string, string> ValidationSpecialCharacters => (string value) =>
        {
            if (!InputValidators.ContainsSpecialCharacters(value))
            {
                return "No es permitido Caracteres especiales";
            }
            return null;
        };
    }
}
