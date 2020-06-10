using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.BLL.ViewModels {

    public class UserModel {

        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public System.DateTime Birthdate { get; set; }

        [Required]
        public bool Gender { get; set; }

    }

}