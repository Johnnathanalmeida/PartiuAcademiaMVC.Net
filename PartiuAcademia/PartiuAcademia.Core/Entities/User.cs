using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbUser")]
    public class User : EntityBase
    {

        [Required(ErrorMessage = "Você não pode deixar este campo em branco.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Você não pode deixar este campo em branco.")]
        public string LastName { get; set; }

        [EmailAddress]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Você não pode deixar este campo em branco.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Você não pode deixar este campo em branco.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Você não pode deixar este campo em branco.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        public string ConfirmPassword { get; set; }

        public DateTime Birth { get; set; }

        public string Telephone { get; set; }

        public string CellPhone { get; set; }

        public virtual Address Address { get; set; }
        
        [ForeignKey("Address")]
        public virtual string  AddressID { get; set; }

        public virtual Role Role { get; set; }

        [ForeignKey("Role")]
        [Required]
        public virtual string RoleID { get; set; }

        public  virtual IQueryable<GymUserModality> lGymUserModality { get; set; }
                
    }
}
