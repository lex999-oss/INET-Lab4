using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INET_Lab4.Entities;
using Microsoft.EntityFrameworkCore;

namespace INET_Lab4.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
