using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
                _products = new List<Product> 
                {
                    new Product {ProductName="summer",CategoryId=4,ProductId=1,UnitPrice=129,UnitsInStock=6},
                    new Product {ProductName="wheels",CategoryId=2,ProductId=2,UnitPrice=89,UnitsInStock=24},
                    new Product {ProductName="mater",CategoryId=4,ProductId=3,UnitPrice=159,UnitsInStock=18},
                    new Product {ProductName="barbie",CategoryId=2,ProductId=4,UnitPrice=119,UnitsInStock=12},
                };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
           //Product productToDelete=null;
            //foreach (Product p in _products) 
            //{
            //    if(product.ProductId==p.ProductId)
            //    {
            //        productToDelete=p;
            //    }
            //}
            //_products.Remove(productToDelete);
            Product productToDelete = _products.SingleOrDefault(p=> p.ProductId== product.ProductId);
            _products.Remove(productToDelete);

            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate=_products.SingleOrDefault(p=>p.ProductId== product.ProductId);
            productToUpdate.ProductName= product.ProductName;
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.UnitPrice= product.UnitPrice;
            productToUpdate.UnitsInStock= product.UnitsInStock;
        }
    }
}
