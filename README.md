# Ürün Yönetimi API

Bu proje, ASP.NET Core Web API kullanılarak geliştirilmiş basit bir ürün yönetimi sistemidir.

## Özellikler

- Ürünleri listeleme, filtreleme, ekleme, güncelleme ve silme
- Kategorileri listeleme ve ekleme
- Swagger UI ile API dökümantasyonu

## Teknolojiler

- ASP.NET Core 7.0
- C#
- Swagger/OpenAPI

## Kurulum

1. Projeyi klonlayın
2. Visual Studio ile açın
3. Projeyi çalıştırın

## API Endpoints

### Ürünler
- GET /api/products - Tüm ürünleri listeler
- GET /api/products?filter=laptop - Ürünleri filtreler
- GET /api/products/{id} - ID'ye göre ürün getirir
- POST /api/products - Yeni ürün ekler
- PUT /api/products/{id} - Ürün günceller
- DELETE /api/products/{id} - Ürün siler

### Kategoriler
- GET /api/categories - Tüm kategorileri listeler
- GET /api/categories/{id} - ID'ye göre kategori getirir
- POST /api/categories - Yeni kategori ekler 