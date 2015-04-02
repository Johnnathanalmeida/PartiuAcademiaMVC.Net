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

        public string Email { get; set; }

        public string Password { get; set; }
        
        public string Telephone { get; set; }

        public string CellPhone { get; set; }

        public virtual Address Address { get; set; }
        
        public virtual string  AddressID { get; set; }

        public virtual Role Role { get; set; }

        [ForeignKey("Role")]
        [Required]
        public virtual string RoleID { get; set; }

        public  virtual IList<GymUserModality> lGymUserModality { get; set; }
                
    }
}
