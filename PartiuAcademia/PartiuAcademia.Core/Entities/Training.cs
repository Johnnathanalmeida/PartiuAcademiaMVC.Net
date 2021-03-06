﻿using PartiuAcademia.Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbTraining")]
    public class Training : EntityBase
    {
        public virtual User Teacher { get; set; }

        public  Enumerator Objetivo { get; set; }
        
        public string Observation { get; set; }

        public int Duration { get; set; }

        public bool Status { get; set; }

        public virtual IQueryable<TrainingRecord> lTrainingRecord { get; set; }

    }
}
