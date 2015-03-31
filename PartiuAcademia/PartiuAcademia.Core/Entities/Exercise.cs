using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbExercise")]
    public class Exercise : EntityBase
    {
        public string Name { get; set; }

        public int Series { get; set; }

        public int Repety { get; set; }

        public int Carga { get; set; }

        public virtual Category Category { get; set; }


                
    }
}
