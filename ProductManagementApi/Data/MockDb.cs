using ProductManagementApi.Models;

namespace ProductManagementApi.Data
{
    public class MockDb
    {

        //Geçici Casper kategori listesi 
        public static List<Category> Categories = new()
        {
            new Category { Id = 1, Name = "Laptop" },
            new Category { Id = 2, Name = "Telefon" },
            new Category { Id = 3, Name = "Tablet" },
            new Category { Id = 4, Name = "Aksesuar" }
        };

        //Geçici Casper ürün listesi
        public static List<Product> Products = new()
        {
            new Product { Id = 1,Name="Casper Nirvana Z100",CategoryId=1},
            new Product { Id = 2,Name="Casper Excalibur G870",CategoryId=1},
            new Product { Id = 3, Name = "Casper VIA X45", CategoryId = 2 },
            new Product { Id = 4, Name = "Casper VIA M45", CategoryId = 2 },
            new Product { Id = 5, Name = "Casper VIA L50", CategoryId = 3 },
            new Product { Id = 6, Name = "Nirvana Laptop Sırt Çantası", CategoryId =3}
        };
    }
}
