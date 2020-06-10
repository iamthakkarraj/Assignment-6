using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.BLL.ViewModels {

    public class LoginModel {

        public int AdminId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]                
        public string Password { get; set; }
        
    }

}