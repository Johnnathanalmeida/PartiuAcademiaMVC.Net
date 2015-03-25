using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartiuAcademia.Core.Entities
{
    public class Gym : EntityBase
    {
        public Address Address { get; set; }

        public IList<Modality> Modality { get; set; }
        
    }
}
