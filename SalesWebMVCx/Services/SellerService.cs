using SalesWebMVCx.Data;
using SalesWebMVCx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVCx.Services
{
    public class SellerService 
    {
        private readonly SalesWebMVCxContext _context;
        
        public SellerService(SalesWebMVCxContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
