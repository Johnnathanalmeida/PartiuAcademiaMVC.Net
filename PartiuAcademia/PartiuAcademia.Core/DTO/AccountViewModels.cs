using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PartiuAcademia.Core.DTO
{

    [Serializable]
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string Name { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }
    }

}
