using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVCx.Models;

namespace SalesWebMVCx.Data
{
    public class SalesWebMVCxContext : DbContext
    {
        public SalesWebMVCxContext (DbContextOptions<SalesWebMVCxContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
