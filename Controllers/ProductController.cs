using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INET_Lab4.Entities;
using INET_Lab4.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace INET_Lab4.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get() => _repository.GetAll().ToList();

        [HttpGet("{id}")]

        public ActionResult<Product> Get(int id) => _repository.GetById(id);
        
        [HttpGet("{getvalidprods}")]
        public ActionResult<List<Product>> GetValidProuducts() => _repository.GetAllValidProducts().ToList();

        [HttpGet("{getsumofallprods}")]

        public ActionResult<int> GetSumProuducts() => _repository.GetSumAll();

        [HttpGet("{getsumvalidprods}")]
        public ActionResult<int> GetSumValidProuducts() => _repository.GetSumAllValidProducts();

    }
}

