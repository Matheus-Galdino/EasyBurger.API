using EasyBurger.API.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EasyBurger.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepository _repository;

        public ProductsController(ProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _repository.GetAll();
            return Ok(products);
        }
    }
}
