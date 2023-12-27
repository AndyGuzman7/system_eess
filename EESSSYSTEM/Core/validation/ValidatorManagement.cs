using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FrutiLightWPF.utils
{
    public static class ValidatorManagement
    {
        public static void ValidateTextBox(bool isIntervention, TextBox textBox, params Func<string, string>[] validationFunctions)
        {
            foreach (var validationFunction in validationFunctions)
            {
                string errorMessage = validationFunction(textBox.Text);

                if (errorMessage != null)
                {
                    if (isIntervention)
                    {
                        /*winMensaje winMensaje = new winMensaje();
                        winMensaje.Mensaje(errorMessage);
                        winMensaje.ShowDialog();
                        textBox.SelectAll();
                        textBox.Focus();*/
                    }

                    textBox.Tag = new ValidatorResponse(true, errorMessage);
                    return;

                }
                textBox.Tag = new ValidatorResponse(false, "");
            }
        }


        public static void ValidatePasswordBox(bool isIntervention, PasswordBox textBox, params Func<string, string>[] validationFunctions)
        {
            foreach (var validationFunction in validationFunctions)
            {
                string errorMessage = validationFunction(textBox.Password);

                if (errorMessage != null)
                {
                    if(isIntervention)
                    {
                      /*  winMensaje winMensaje = new winMensaje();
                        winMensaje.Mensaje(errorMessage);
                        winMensaje.ShowDialog();
                        textBox.SelectAll();
                        textBox.Focus();*/
                    }
                    
                    textBox.Tag = new ValidatorResponse(true, errorMessage);
                    return;

                }
                textBox.Tag = new ValidatorResponse(false, "");
            }
        }

    }
}
