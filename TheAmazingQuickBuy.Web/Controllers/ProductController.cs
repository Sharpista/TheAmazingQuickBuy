using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheAmazingQuickBuy.Domain.Entities;
using TheAmazingQuickBuy.Domain.Interfaces.Repositories;

namespace TheAmazingQuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_productRepository.GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            try
            {
                _productRepository.Add(product);
                return Created("api/produto", product);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

    }
}
