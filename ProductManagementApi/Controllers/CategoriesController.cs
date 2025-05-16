using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementApi.Data;
using ProductManagementApi.Models;

namespace ProductManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        // GET: /api/categories
        // Kategorileri listele
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(MockDb.Categories); // Tüm kategorileri döndür
        }

        // GET: /api/categories/1
        // ID'ye göre kategori getir
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = MockDb.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound(); // Kategori bulunamadı

            return Ok(category); // Kategoriyi döndür
        }

        // POST: /api/categories
        // Yeni kategori oluştur
        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            if (string.IsNullOrWhiteSpace(category.Name))
                return BadRequest("Kategori adı boş olamaz."); // Kategori adı boş olamaz

            category.Id = MockDb.Categories.Max(c => c.Id) + 1;
            MockDb.Categories.Add(category); // Kategoriyi ekle
            return CreatedAtAction(nameof(GetById), new { id = category.Id }, category); // Yeni kategoriyi döndür
        }
    }
}
