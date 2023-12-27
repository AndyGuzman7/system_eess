using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EESSSYSTEM.Data.Models
{
    public class MemberModel
    {
        private string idDocument;
        private string idMember;

        public string IdMember
        {
            get { return idMember; }
            set { idMember = value; }
        }

        public string IdDocument
        {
            get { return idDocument; }
            set { idDocument = value; }
        }

        private string? name;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        private string? dateBirthDay;

        public string? DateBirthDay
        {
            get { return dateBirthDay; }
            set { dateBirthDay = value; }
        }

        private string? phone;

        public string? Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public MemberModel(string name, string dateBirthDay, string phone)
        {
            Name = name;
            DateBirthDay = dateBirthDay;
            Phone = phone;
        }
        public MemberModel()
        {
            
        }

        /// <summary>
        /// Json factory
        /// </summary>
        /// <param name="json"></param>
        public MemberModel(JObject json)
        {
            string idDocument = GetValue(json, "id");
            string idMember = GetValue(json, "properties", "ID", "unique_id", "number");
            string name = GetValue(json, "properties", "Name", "title", 0, "text", "content");
            string dateBirthDay = GetValue(json, "properties", "Fecha Nacimiento", "date", "start");
            string phone = GetValue(json, "properties", "Phone", "rich_text", 0, "text", "content");

            Name = name;
            DateBirthDay = dateBirthDay;
            Phone = phone;
            IdDocument = idDocument;
            IdMember = idMember;
        }

        /* JObject toJson()
         {
             return {
                 'id': id,
       'name': name,
       'lastName': lastName,
       'secondLastName': secondLastName,
       'email': email,
       'position': position,
       'uid': uid,
       'workStartDate': workStartDate,
     };
         }*/

        public MemberModel FromJson(JObject json)
        {
            string name = GetValue(json, "properties", "Name", "title", 0, "text", "content");
            string dateBirthDay = GetValue(json, "properties", "Fecha Nacimiento", "date", "start");
            string phone = GetValue(json, "properties", "Phone", "rich_text", 0, "text", "content");

            MemberModel member = new MemberModel(name, dateBirthDay, phone);
            return member;
        }


        private string GetValue(JObject json, params object[] keys)
        {
            JToken current = json;
            foreach (var key in keys)
            {
                switch (current)
                {
                    case JObject obj:
                        current = obj[key];
                        break;
                    case JArray array:
                        if (int.TryParse(key.ToString(), out int index) && index >= 0 && index < array.Count)
                        {
                            current = array[index];
                        }
                        else
                        {
                            return null; // Índice no válido en el array
                        }
                        break;
                    default:
                        return null; // Tipo de nodo no compatible
                }

                if (current == null)
                {
                    return null; // Valor nulo encontrado
                }
            }

            return current?.ToString();
        }



    }
}
