using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESSSYSTEM.Presentation.Pages.MembersPage.Components.MVVM
{
    public class BaptismModel
    {
        public string? Baptism { get; set; }
        public int? Code { get; set; }

        public BaptismModel(string? baptism, int? code)
        {
            Baptism = baptism;
            Code = code;
        }
    }
}
