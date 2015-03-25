using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartiuAcademia.Core.Entities
{
    public class District : EntityBase
    {
        [Required]
        public string Name { get; set; }

        public City City { get; set; }
        
    }
}
