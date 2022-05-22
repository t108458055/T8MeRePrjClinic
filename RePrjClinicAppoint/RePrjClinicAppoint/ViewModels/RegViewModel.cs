using RePrjClinicAppoint.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RePrjClinicAppoint.ViewModels
{ // This is Presentation Layer
    public class RegViewModel
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Account{ get; set; }
        public string Password { get; set; }
        
    }
}
