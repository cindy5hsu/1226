using _1226.Models.DTOs;
using _1226.Models.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1226.Models.ViewModels
{
    public class LoginVM
    {

        [Display(Name = "賬號")]
        [Required]
        public string Account { get; set;}

        [Display(Name = "密碼")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set;}
    }

  
}