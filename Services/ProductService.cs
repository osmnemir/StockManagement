using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> GetProductsByFilter(DateTime startDate, DateTime endDate, string searchTerm)
        {
           
             _context.Products.Where(x => x.Tarih >= startDate && x.Tarih <= endDate &&
             (x.MalKodu.Contains(searchTerm) || x.MalAdi.Contains(searchTerm))).ToList();
            return new List<Product>();
        }
    }
}
