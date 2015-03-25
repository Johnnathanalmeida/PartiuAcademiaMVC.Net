using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core
{
    public class Horary : Entities.EntityBase
    {
        public TimeSpan FirstHour { get; set; }

        public TimeSpan FinalHour { get; set; }

        public DayOfWeek DayOfWeek { get; set; }
        
    }
}
