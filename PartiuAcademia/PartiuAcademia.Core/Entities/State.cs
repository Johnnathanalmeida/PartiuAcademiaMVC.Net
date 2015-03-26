using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbState")]
    public class State : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [MaxLength(2)]
        public string Sigla { get; set; }
    }
}
