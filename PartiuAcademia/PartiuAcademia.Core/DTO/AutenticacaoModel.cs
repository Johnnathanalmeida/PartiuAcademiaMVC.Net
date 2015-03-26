using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PartiuAcademia.Core.DTO
{
    [Serializable]
    public class AutenticacaoModel
    {
        [Required(ErrorMessage = "Login é obrigatório")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [HiddenInput(DisplayValue = false)]
        public string Name { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }
    }
}
