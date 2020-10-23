using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INET_Lab4.Entities;

namespace INET_Lab4.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Product product)
        {
            this.context.Add(product);
            this.context.SaveChanges();
        }

        public void Update(Product product)
        {
            this.context.Update(product);
            this.context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return this.context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return this.context.Products.Find(id);
        }

       public int GetSumAll()
        {
            int sum = 0;
            IEnumerable < Product > prodList = GetAll();
            foreach (Product product in prodList)
            {
                sum += product.Price;
            }
            return sum;
        }

       public IEnumerable<Product> GetAllValidProducts()
        {
            IEnumerable<Product> prodList = GetAll();
            IEnumerable<Product> validProds = null;
            DateTime localDate = DateTime.Now;
            foreach (Product product in prodList)
            {
                if(product.ValidTo > localDate)
                {
                    validProds.Append<Product>(product);
                }
            }
            return validProds;
        }

       public int GetSumAllValidProducts()
        {
            IEnumerable<Product> prodList = GetAllValidProducts();
            int sum = 0;
            foreach(Product product in prodList)
            {
                sum += product.Price;
            }
            return sum;
        }

        public void Remove(Product product)
        {
            this.context.Remove(product);
            this.context.SaveChanges();
        }

    }
}
