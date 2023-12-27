using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrutiLightWPF.utils
{
    public class ValidatorResponse
    {
        public bool IsValid { get; set; }
        public string message { get; set; }
        public ValidatorResponse()
        {
            
        }

        public ValidatorResponse(bool isValid, string message)
        {
            IsValid = isValid;
            this.message = message;
        }
    }
}
