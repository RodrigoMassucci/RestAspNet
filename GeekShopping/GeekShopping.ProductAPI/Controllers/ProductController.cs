using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            if (id > 0)
            {
                var product = await _repository.FindById(id);
                return product.Id <= 0 ? NotFound() : Ok(product);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create(ProductVO vo)
        {
            if (!string.IsNullOrWhiteSpace(vo.Name) && vo.Price > 0)
            {
                var product = await _repository.Create(vo);
                return Ok(product);
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update(ProductVO vo)
        {
            MessageError error;

            if (vo.Id > 0 && !string.IsNullOrWhiteSpace(vo.Name) && vo.Price > 0)
            {
                var product = await _repository.Update(vo);

                if (product == null)
                    return BadRequest();

                return Ok(product);
            }
            else
            {
                error = new MessageError();
                error.Message = "Verifique o preenchimento dos Obrigatórios";

                return BadRequest(error);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            if (id > 0)
            {
                var status = await _repository.Delete(id);
                return status ? Ok() : BadRequest();
            }

            return BadRequest();
        }
    }
}
