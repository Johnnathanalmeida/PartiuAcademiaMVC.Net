using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core
{
    [Table("tbHorary")]
    public class Horary : Entities.EntityBase
    {
        public TimeSpan FirstHour { get; set; }

        public TimeSpan FinalHour { get; set; }

        public DayOfWeek DayOfWeek { get; set; }
        
    }
}
