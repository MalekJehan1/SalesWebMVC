using SalesWebMVCx.Data;
using SalesWebMVCx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVCx.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMVCxContext _context;

        public DepartamentService(SalesWebMVCxContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
