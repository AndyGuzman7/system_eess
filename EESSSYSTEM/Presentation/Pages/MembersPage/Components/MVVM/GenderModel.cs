using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESSSYSTEM.Presentation.Pages.MembersPage.Components.MVVM
{
    public class GenderModel
    {
        public string? Gender { get; set; }
        public int? Code { get; set; }
       
        public GenderModel(string? gender, int? code)
        {
            Gender = gender;
            Code = code;
        }
    }
}
