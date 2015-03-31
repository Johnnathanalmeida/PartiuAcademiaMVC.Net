using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbGymUserModality")]
    public class GymUserModality : EntityBase
    {

        public virtual Gym Gym { get; set; }

       


        public virtual User User { get; set; }

      

        public virtual Modality Modality { get; set; }



        public  virtual  IList<TrainingRecord> TrainingRecord { get; set; }
        
    }
}
