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

        public string Name { get; set; }

        public string LastName { get; set; }

        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        public string ConfirmPassword { get; set; }
                
        public string Telephone { get; set; }

        public string CellPhone { get; set; }

        public Address Address { get; set; }
        
        public Address AddressID { get; set; }
        
        public Role Role { get; set; }

        public Role RoleID { get; set; }

        public  virtual IList<GymUserModality> lGymUserModality { get; set; }
                
    }
}
