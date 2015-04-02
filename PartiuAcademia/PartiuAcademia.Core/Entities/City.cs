using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartiuAcademia.Core.Entities
{

    [Table("tbCity")]
    public class City : EntityBase
    {
        //[Required]
        //public string Name { get; set; }

        //public virtual ICollection<Gym> Gyms { get; set; } 

        //public virtual ICollection<User> Users { get; set; } 
             
      
        ////public virtual State State { get; set; }


       //[Required]
       //[ForeignKey("State")]
       //public virtual string state_id { get; set; }
             

        

      
    }
}
