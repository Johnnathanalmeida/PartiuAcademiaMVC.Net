
using System.ComponentModel.DataAnnotations.Schema;
namespace PartiuAcademia.Core.Entities
{
    [Table("tbRole")]
    public class Role : EntityBase
    {
        public string Name { get; set; }
        
    }
}
