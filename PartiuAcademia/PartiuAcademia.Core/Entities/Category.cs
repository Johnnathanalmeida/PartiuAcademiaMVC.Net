﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Entities
{
    [Table("tbCategory")]
    public class Category : EntityBase
    {
        public string Name { get; set; }

    }
}
