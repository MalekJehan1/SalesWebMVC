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

        public DbSet<SalesWebMVCx.Models.Departament> Departament { get; set; }
    }
}
