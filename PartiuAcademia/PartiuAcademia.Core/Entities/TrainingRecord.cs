using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PartiuAcademia.Core.Entities.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbTrainingRecord")]
    public class TrainingRecord : EntityBase
    {

        public  virtual IQueryable<Exercise> lExercise { get; set; }
        
    }
}
