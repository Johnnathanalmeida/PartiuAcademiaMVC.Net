using System.ComponentModel.DataAnnotations.Schema;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbAdress")]
    public class Address : EntityBase
    {

        public string Patio { get; set; }

        public string Number { get; set; }

        public string CEP { get; set; }

        public string Complement { get; set; }
        
        public virtual District District { get; set; }

       
        
    }
}
