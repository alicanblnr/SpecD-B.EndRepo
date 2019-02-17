using Dominos.Dal.Abstract;
using Dominos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.Dal.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        private DominosContext _context = new DominosContext();
        public void Add(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int productId)
        {
            _context.Product.Remove(_context.Product.FirstOrDefault(x => x.Id == productId));
            _context.SaveChanges();
        }

        public Product Get(int productId)
        {
            return _context.Product.Where(x => x.Id == productId).FirstOrDefault();
        }

        public List<Product> GetAll()
        {
            return _context.Product.ToList();
        }

        public void Update(Product product)
        {
            var productToUpdate = _context.Product.FirstOrDefault(x => x.Id == product.Id);
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.Desc = product.Desc;
            productToUpdate.DiscountPrice = product.DiscountPrice;
            productToUpdate.ProductTypeId = product.ProductTypeId;
            _context.SaveChanges();
        }
    }
}
