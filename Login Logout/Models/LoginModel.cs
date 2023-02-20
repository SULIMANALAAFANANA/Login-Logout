using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Logout.Models
{
    public class LoginModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter The Username !")]
        [Display(Name ="Enter UserId :")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please Enter The Password")]
        [Display(Name ="Enter Password :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
