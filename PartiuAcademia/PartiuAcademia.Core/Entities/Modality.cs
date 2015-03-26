
using System.ComponentModel.DataAnnotations.Schema;
namespace PartiuAcademia.Core.Entities
{
    [Table("tbModality")]
    public class Modality : EntityBase
    {
        public string Name { get; set; }
    }
}
