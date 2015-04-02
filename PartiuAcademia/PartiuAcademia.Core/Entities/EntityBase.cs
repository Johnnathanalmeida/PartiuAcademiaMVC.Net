using System;
using System.ComponentModel.DataAnnotations;

namespace PartiuAcademia.Core.Entities
{
    public class EntityBase
    {
        [Key]
        public string Id { get; set; }

        public EntityBase()
        {
            Id = System.Guid.NewGuid().ToString("n");
        }

        public DateTime CreationDate { get; set; }

        public string CreationUser { get; set; }
                
        public DateTime TerminationDate { get; set; }

        public string TerminationUser { get; set; }

    }
}
