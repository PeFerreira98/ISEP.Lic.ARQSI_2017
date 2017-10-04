﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ARQSI_IT1.Models;

namespace ARQSI_IT1.Models
{
    public class ARQSI_IT1Context : DbContext
    {
        public ARQSI_IT1Context (DbContextOptions<ARQSI_IT1Context> options)
            : base(options)
        {
        }

        public DbSet<ARQSI_IT1.Models.Medicamento> Medicamento { get; set; }

        public DbSet<ARQSI_IT1.Models.Posologia> Posologia { get; set; }

        public DbSet<ARQSI_IT1.Models.Apresentacao> Apresentacao { get; set; }

        public DbSet<ARQSI_IT1.Models.Farmaco> Farmaco { get; set; }
    }
}
