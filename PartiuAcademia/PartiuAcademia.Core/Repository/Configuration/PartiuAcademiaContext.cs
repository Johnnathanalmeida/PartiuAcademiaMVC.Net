using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Repository.Configuration
{
    public class PartiuAcademiaContext : DbContext
    {
        public PartiuAcademiaContext() : base("PartiuAcademiaConnectionString") { }
    }
}
