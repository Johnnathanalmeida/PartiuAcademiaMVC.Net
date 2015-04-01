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
        [Required]
        public string Name { get; set; }

        [Required]
        public virtual State State { get; set; }

        

      
    }
}
