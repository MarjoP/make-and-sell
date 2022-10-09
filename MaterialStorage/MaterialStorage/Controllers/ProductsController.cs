using MaterialStorage.Data.Repo;
using MaterialStorage.DTOs;
using MaterialStorage.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MaterialStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IRawMaterialRepository _rawMaterialRepository;
        public ProductsController(IProductRepository productRepo, IRawMaterialRepository rawMaterialRepo)
        {
            _productRepository = productRepo;
            _rawMaterialRepository = rawMaterialRepo;
        }

        // GET: api/products
        [HttpGet]
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id)
        {
            return await _productRepository.GetProductAsync(id);
        }

        // POST api/products
        [HttpPost]
        public async Task<ActionResult> PostProduct([FromBody] Product product)
        {
            if(product == null) { throw new ArgumentNullException(nameof(product)); }
            await _productRepository.AddNewProductAsync(product);
            await _productRepository.SaveAsync();
            return Ok(product);
        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public async Task PutProduct(int id, [FromBody] Product product)
        {
            if(product == null) { return; }
            _productRepository.UpdateProduct(product);
            await _productRepository.SaveAsync();

        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
        }

        // GET: api/products/variants
        [HttpGet("variants")]
        public async Task<IEnumerable<Variant>> GetAllVariants()
        {
            return await _productRepository.GetAllVariantsAsync();
        }

        // GET api/products/variants/5
        [HttpGet("variants/{id}")]
        public async Task<Variant> GetVariant(int id)
        {
            return await _productRepository.GetVariantAsync(id);
        }

        //GET api/products/variantsstock
        [HttpGet("variants/stock/{id}")]
        public async Task<int> GetVariantStock(int id)
        {
            return await _productRepository.GetVariantStockAmountAsync(id);
        }

        // POST api/products/variants
        [HttpPost("variants")]
        public async Task<ActionResult> PostVariant([FromBody] Variant variant)
        {
            if (variant == null) { throw new ArgumentNullException(nameof(variant)); }
            await _productRepository.AddNewVariantAsync(variant);
            await _productRepository.SaveAsync();
            return Ok(variant);
        }

        // PUT api/products/variants/5
        [HttpPut("variants/{id}")]
        public async Task UpdateVariant(int id, [FromBody] Variant variant)
        {
            if (variant == null) { return; }
            _productRepository.UpdateVariant(variant);
            await _productRepository.SaveAsync();
        }

        // PUT api/products/variants/5
        [HttpPut("variants/stock/{id}")]
        public async Task UpdateVariantStock(int id, [FromBody] int qty)
        {
           await _productRepository.UpdateVariantStockAmountAsync(id, qty);
           await _productRepository.SaveAsync();
        }

        // POST api/products/variants/materials
        [HttpPost("variants/materials")]
        public async Task<ActionResult> PostVariantMaterials([FromBody] VariantBomDTO bom)
        {
            if (bom == null) { throw new ArgumentNullException(nameof(bom)); }
            await _productRepository.AddVariantMaterialsAsync(bom);
            await _productRepository.SaveAsync();
            return Ok();
        }

        //PUT api/products/variants/materials
        [HttpPut("variants/materials")]
        public async Task UpdateVariantMaterials([FromBody] VariantBomDTO bom)
        {
            _productRepository.UpdateVariantMaterials(bom);
            await _productRepository.SaveAsync();
            
        }

    }
}
