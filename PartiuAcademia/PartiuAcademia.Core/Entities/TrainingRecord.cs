using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PartiuAcademia.Core.Entities.Enum;

namespace PartiuAcademia.Core.Entities
{
    public class TrainingRecord : EntityBase
    {

        public IList<Exercise> lExercise { get; set; }
        
    }
}
