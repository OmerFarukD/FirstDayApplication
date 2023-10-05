// sizden ürünleri kaydeden ve silen ve listeleyen metodlar istiyor

using Kalitim;
// 1. Servis
//ProductService productService = new ProductService();
//productService.Add();
//productService.GetList();
//productService.Remove();

//ProductService2 productService2 = new ProductService2();
//productService2.Add();
//productService2.Remove();
//productService2.GetList();

// Polymorphism
IProductService productService =new ProductService();
productService.Add();
productService.Remove();
productService.GetList();
// Dependency Injection ve IoC(Inversion of Control) Container
Matematik matematik = new Matematik(44,25);
matematik.Topla();
matematik.Cikar();

// RentAcar şirketiniz var araa ekleme silme ve Listeleme işlemlerini yapınız.

