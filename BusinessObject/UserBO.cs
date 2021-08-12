using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public class UserBO
    {
        public int UserId { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User name is required.")]
        public string UserName { get; set; }
        [Display(Name = "User Address")]
        [Required(ErrorMessage = "User address is required.")]
        public string UserAddress { get; set; }
        [Display(Name = "User Email")]
        [Required(ErrorMessage = "Please enter valid email address")]
        [EmailAddress(ErrorMessage = "Please enter valid email address.")]
        public string UserEmail { get; set; }
        [Display(Name = "User Phone")]
        [Required(ErrorMessage = "User phone is required.")]

        public string UserPhone { get; set; }
    }
}
