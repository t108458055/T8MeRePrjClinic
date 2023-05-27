using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RePrjClinicAppoint.Models.Entities
{
    public class User : DentalAccountEntityAbstract
    {    
        [NotMapped]
        public UserTypes userTypes { get; set; }
        public string userRole
        {
            get { return userTypes.ToString(); }
            set
            {
                UserTypes result;
                if (!Enum.TryParse<UserTypes>(value, out result))
                    throw new ApplicationException($"Can't convert '{value}' to type [{typeof(UserTypes)}]");
                this.userTypes = result;
            }
        }
    }
}
