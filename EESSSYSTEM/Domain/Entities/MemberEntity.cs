using EESSSYSTEM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESSSYSTEM.Domain.Entities
{
    public class MemberEntity
    {
        private string? name;
        private DateTime? dateBirthDay;
        private string? phone;
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime? DateBirthDay
        {
            get { return dateBirthDay; }
            set { dateBirthDay = value; }
        }

        public string? Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        /// <summary>
        /// Model convert to Entity
        /// </summary>
        /// <param name="memberModel"></param>
        public MemberEntity(MemberModel memberModel)
        {
            Name = memberModel.Name;
            dateBirthDay = DateTime.Parse(memberModel.DateBirthDay ?? DateTime.Now.ToString());
            phone = memberModel.Phone;
        }
    }
}
