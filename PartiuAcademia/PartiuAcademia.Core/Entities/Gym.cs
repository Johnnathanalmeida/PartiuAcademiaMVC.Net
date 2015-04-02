using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbGym")]
    public class Gym : EntityBase
    {
        //public virtual Address Address { get; set; }


      

        public virtual IList<Modality> Modality { get; set; }
        
    }
}
