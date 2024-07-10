using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    new Product {ProductName="summer",CategoryId=4,Description="jogger",ProductId=1,UnitPrice=129,UnitsInStock=6},
                    new Product {ProductName="wheels",CategoryId=2,Description="toys",ProductId=2,UnitPrice=89,UnitsInStock=24},
                    new Product {ProductName="mater",CategoryId=4,Description="maternity",ProductId=3,UnitPrice=159,UnitsInStock=18},
                    new Product {ProductName="barbie",CategoryId=2,Description="toys",ProductId=4,UnitPrice=119,UnitsInStock=12},
                };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
           Product productToDelete=null;
            foreach (Product p in _products) 
            {

            }
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
