using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApiApp.Data;
using WebApiApp.Interfaces;

namespace WebApiApp.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {

        //Ok(200), Created(201) , NoContent(204) , BadRequest(400) ,NotFound(404)

        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var result= await _productRepository.GetAllAsync();
            return Ok(result);
        }
        [Authorize(Roles ="Admin")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data= await _productRepository.GetByIdAsync(id);

            if (data == null) return NotFound();
            return Ok(data);

        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var addedProduct = _productRepository.CreateAsync(product);
            return Created(string.Empty, addedProduct);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            var checkProduct = await _productRepository.GetByIdAsync(product.Id);
            if (checkProduct == null) return NotFound();
            await _productRepository.UpdateAsync(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var checkProduct = await _productRepository.GetByIdAsync(id);
            if (checkProduct == null) return NotFound();
            await _productRepository.RemoveAsync(id);
            return NoContent();
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload([FromForm]IFormFile formFile)
        {
            var newName = Guid.NewGuid() + "." + Path.GetExtension(formFile.Name);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", newName);
            var stream = new FileStream(path,FileMode.Create);
            await formFile.CopyToAsync(stream);
            return Created(String.Empty,formFile);
        }
    }
}
