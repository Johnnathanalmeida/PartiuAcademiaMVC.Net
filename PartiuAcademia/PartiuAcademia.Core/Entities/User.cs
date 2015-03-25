using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartiuAcademia.Core.Entities
{
    public class User : EntityBase
    {

        public string Name { get; set; }

        public string Telephone { get; set; }

        public string CellPhone { get; set; }

        public Address Address { get; set; }
        
        public Address AddressID { get; set; }
        
        public Role? Role { get; set; }

        public Role? RoleID { get; set; }

        public IList<GymUserModality> lGymUserModality { get; set; }
                              
    }
}
