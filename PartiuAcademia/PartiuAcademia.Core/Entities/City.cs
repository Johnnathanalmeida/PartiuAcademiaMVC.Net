using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartiuAcademia.Core.Entities
{
    public class City : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public State State { get; set; }
        
    }
}
