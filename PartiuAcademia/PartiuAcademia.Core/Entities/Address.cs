using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbAdress")]
    public class Address : EntityBase
    {

        public string CEP { get; set; }

        public string Patio { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Number { get; set; }

        public string Complement { get; set; }


        //public virtual IQueryable<City> IQcties { get; set; }

        //public virtual District District { get; set; }



    }
}
