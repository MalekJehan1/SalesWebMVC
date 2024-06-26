﻿using SalesWebMVCx.Data;
using SalesWebMVCx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SalesWebMVCx.Services
{
    public class SalesRecordSerivce
    {
        private readonly SalesWebMVCxContext _context;

        public SalesRecordSerivce(SalesWebMVCxContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }

            if(maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Departament)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
