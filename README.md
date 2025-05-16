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

  ### Case #1 Görsel
  -Link:https://localhost:7109/swagger/index.html
  ![image](https://github.com/user-attachments/assets/d1f9b590-25fd-42ef-8840-b41b11b5d6d1)

  ### Case #2 Görsel
  -Link: https://localhost:7109//index.html
  ![image](https://github.com/user-attachments/assets/7d06afd6-7793-41ac-8508-a2022ff308cb)

