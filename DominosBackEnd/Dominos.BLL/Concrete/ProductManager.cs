﻿
using Dominos.Dal.Abstract;
using Dominos.Dal.Concrete.EntityFramework;
using Dominos.Entities;
using Dominos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominos.BLL.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(productId);
        }

        public Product Get(int productId)
        {
            return _productDal.Get(productId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();

        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
