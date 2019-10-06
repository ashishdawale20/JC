using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobbersCafe.UI.Models
{

    [Table("JC_Enquiry")]
    public class vmEnquiry
    {
        [Required(ErrorMessage = "please enter username")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public List<System.Web.Mvc.SelectListItem> Gender { get; set; }
        [Required]
        public string EmailAddress { get; set; }

        public vmEnquiry()
        {
            Gender = new List<System.Web.Mvc.SelectListItem>() 
            { 
               new SelectListItem { Value ="0", Text = "--Select Gender--"},
               new SelectListItem { Value = "1", Text = "Male" }, 
               new SelectListItem { Value = "2", Text = "Female" } 
            };
        }
    }
}