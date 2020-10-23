using INET_Lab4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INET_Lab4.Data
{
    public interface IProductRepository
    {
        void Create(Product product);
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        int GetSumAll();
        IEnumerable<Product> GetAllValidProducts();
        int GetSumAllValidProducts();
        void Remove(Product product);
        void Update(Product product);
    }
}
