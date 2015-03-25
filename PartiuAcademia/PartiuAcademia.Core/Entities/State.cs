using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartiuAcademia.Core.Entities
{
    public class State : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [MaxLength(2)]
        public string Sigla { get; set; }
    }
}
