using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Entities
{
    public class Team : EntityBase
    {
        public IList<User> lUser { get; set; }

        public User Teacher { get; set; }

        public Modality Modality { get; set; }

        public Modality ModalityID { get; set; }

        public Horary Horary { get; set; }
        
    }
}
