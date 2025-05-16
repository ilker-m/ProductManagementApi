using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementApi.Data;
using ProductManagementApi.Models;

namespace ProductManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: /api/products?filter=laptop
        // Ürünleri listele
        [HttpGet]
        public IActionResult Get([FromQuery] string? filter)
        {
            var products = MockDb.Products
                .Select(p => new Product
                {
                    Id = p.Id,
                    Name = p.Name,
                    CategoryId = p.CategoryId,
                    Category = MockDb.Categories.FirstOrDefault(c => c.Id == p.CategoryId)
                }).ToList();

            var result = string.IsNullOrWhiteSpace(filter)
                ? products
                : products.Where(p =>
                    p.Name.Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                    p.Category!.Name.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();

            return Ok(result); // Filtreli veya tüm ürünleri döndür
        }

        // GET: /api/products/2
        // ID'ye göre ürün getir
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = MockDb.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound(); // Ürün bulunamadı
            return Ok(product); // Ürünü döndür
        }

        // POST: /api/products
        // Yeni ürün oluştur
        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            if (!MockDb.Categories.Any(c => c.Id == product.CategoryId))
                return BadRequest("Geçersiz kategori ID'si."); // Kategori hatalı

            product.Id = MockDb.Products.Max(p => p.Id) + 1;
            MockDb.Products.Add(product); // Ürünü ekle
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product); // Yeni ürünü döndür
        }

        // PUT: /api/products/3
        // Ürünü güncelle
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product updatedProduct)
        {
            var existingProduct = MockDb.Products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
                return NotFound(); // Ürün bulunamadı

            if (!MockDb.Categories.Any(c => c.Id == updatedProduct.CategoryId))
                return BadRequest("Geçersiz kategori ID'si."); // Kategori hatalı

            existingProduct.Name = updatedProduct.Name;
            existingProduct.CategoryId = updatedProduct.CategoryId;

            return Ok(existingProduct); // Güncellenmiş ürünü döndür
        }

        // DELETE: /api/products/4
        // Ürünü sil
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = MockDb.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound(); // Ürün bulunamadı

            MockDb.Products.Remove(product); // Ürünü sil
            return NoContent(); // Silindi, içerik yok
        }
    }
}
