using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbTeam")]
    public class Team : EntityBase
    {
        public  virtual IList<User> lUser { get; set; }

        public virtual User Teacher { get; set; }

        public virtual Modality Modality { get; set; }


        
        public virtual Horary Horary { get; set; }

     


        
    }
}
