using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartiuAcademia.Core.Entities
{
    public class GymUserModality : EntityBase
    {

        public Gym Gym { get; set; }

        public User User { get; set; }

        public Modality Modality { get; set; }

        public IList<TrainingRecord> TrainingRecord { get; set; }
        
    }
}
