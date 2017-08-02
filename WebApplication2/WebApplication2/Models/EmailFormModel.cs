using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebApplication2.Models;

namespace MVCEmail.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name = "Your Name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Your Email"), EmailAddress]
        public string FromEmail { get; set; }


       
        [Required, Display(Name = "Your Phone Number")]
        
        public string FromPhoneNumber { get; set; }
        
        [Display(Name = "Message")]
        public string Message { get; set; }
        
    }
}
