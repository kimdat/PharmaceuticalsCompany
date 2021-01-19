using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalsCompany.Models.Career
{ 
    public class CareerModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string PassWord { get; set; }
        [Compare("PassWord")]
        public string ConfirmPassWord { get; set; }
    }
}
