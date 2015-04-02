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

            Id = System.Guid.NewGuid().ToString();
        }

        //[Required]
        public DateTime CreationDate { get; set; }

       // [Required]
        public string CreationUser { get; set; }

       // [Required]
        public DateTime TerminationDate { get; set; }

       // [Required]
        public string TerminationUser { get; set; }

    }
}
