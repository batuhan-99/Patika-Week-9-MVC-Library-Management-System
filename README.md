# Patika-Week-9-MVC-Library-Management-System
![image](https://github.com/user-attachments/assets/bdb973da-5d7c-4753-be04-cf0e9e7c3b96)

Kütüphane Yönetim Sistemi (Library Management System)
Proje Özeti
Kütüphane Yönetim Sistemi, kitaplar, yazarlar ve üyeler üzerinde yönetim işlemleri gerçekleştiren bir ASP.NET Core MVC uygulamasıdır. Proje kapsamında kitap ekleme, düzenleme, silme, yazar ekleme, düzenleme ve üye kayıt/giriş işlemleri gerçekleştirilmektedir. Ayrıca projede temel MVC yapısı kullanılarak verilerin yönetilmesi ve sunulması sağlanmıştır.

Kullanılan Teknolojiler
.NET 7.0: Projenin temel framework'ü.
ASP.NET Core MVC: MVC mimarisi ile model, view ve controller katmanları oluşturulmuştur.
Entity Framework Core (Opsiyonel): Veritabanı işlemleri için kullanılabilir. Bu projede kullanılmamış, yerine statik test verileri kullanılmıştır.
Projenin Özellikleri
Kitap Yönetimi: Kitap ekleme, düzenleme, silme ve detay görüntüleme işlemleri.
Yazar Yönetimi: Yazar ekleme, düzenleme, silme ve detay görüntüleme işlemleri.
Üye Yönetimi: Kullanıcı kayıt olma ve giriş işlemleri.
Ana Sayfa & Hakkında: Genel bilgilendirici sayfalar.
Footer: Sayfanın alt kısmında sabit bir telif hakkı bilgisi yer alır.
Proje Yapısı
Controllers/: Kitap, yazar ve kullanıcı işlemleri için controller'lar burada bulunur.

BookController.cs: Kitap işlemlerini yöneten controller.
AuthorController.cs: Yazar işlemlerini yöneten controller.
AuthController.cs: Üye kayıt ve giriş işlemlerini yöneten controller.
Models/: Veri modelleri ve ViewModel'ler burada yer alır.

Book.cs: Kitap modeli.
Author.cs: Yazar modeli.
User.cs: Üye modeli.
SignUpViewModel.cs: Kayıt formu için ViewModel.
LoginViewModel.cs: Giriş formu için ViewModel.
Views/: Proje içinde kullanılan Razor View dosyaları.

Book/: Kitap işlemleriyle ilgili sayfalar.
Author/: Yazar işlemleriyle ilgili sayfalar.
Auth/: Üye giriş ve kayıt sayfaları.
Shared/: Layout ve partial view dosyaları.
wwwroot/: CSS, JS, resimler ve diğer statik dosyalar.
Proje Dokümantasyonu - Kütüphane Yönetim Sistemi
Proje Adı:
Kütüphane Yönetim Sistemi

Proje Tanımı:
Kütüphane Yönetim Sistemi (Library Management System), kitap, yazar ve üyelerin yönetimini sağlayan bir ASP.NET Core MVC projesidir. Sistem, kitap ekleme, düzenleme, silme işlemleri, yazar yönetimi ve üyelik işlemleri gibi temel kütüphane yönetim işlevlerini gerçekleştirir. Ayrıca kullanıcılar için giriş ve kayıt sayfaları sunulmaktadır.

Projenin Yapılandırılması
1. Proje Mimarisi:
Proje Model-View-Controller (MVC) mimarisi kullanılarak yapılandırılmıştır. Aşağıdaki klasörler projenin temel yapı taşlarını oluşturur:

Models: Veritabanı nesneleri ve ViewModel’ler bu klasörde yer alır.
Views: Her bir Controller için kullanıcı arayüzü burada yer alır.
Controllers: İş kurallarını ve verilerin taşınmasını yöneten kodlar burada yer alır.
wwwroot: Statik dosyaların (CSS, JS, resimler) depolandığı klasördür.
2. Veritabanı:
Projede veritabanı yerine test verileri manuel olarak eklenmiştir. Gerçek bir projede veritabanı kullanımı için Entity Framework Core entegrasyonu yapılabilir.

3. ViewModels:
Kayıt olma ve giriş işlemleri için ayrı ViewModel sınıfları oluşturulmuştur:

SignUpViewModel: Kayıt olma formunun veri doğrulamasını sağlar.
LoginViewModel: Giriş işlemleri için veri doğrulama işlemleri yapılır.
4. Routing ve Yapılandırma:
Program.cs dosyasında projenin MVC servisleri eklenmiş ve rotalama yapılandırması şu şekilde ayarlanmıştır:

Anasayfa ve diğer varsayılan sayfalar için route yapılandırması:
csharp
Kodu kopyala
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
5. Statik Dosyalar (wwwroot):
Projede kullanılan CSS ve JavaScript dosyaları wwwroot klasöründe saklanmaktadır. Bu dosyalar, View’lerde kullanılarak sayfanın görünümü ve etkileşimi sağlanmıştır.

Proje Fonksiyonları
1. Kitap Yönetimi:
Kitap Listesi: Tüm kitaplar listelenir. Her bir kitabın düzenleme ve silme işlemleri buradan yapılabilir.
Kitap Detayları: Belirli bir kitabın detay bilgileri görüntülenir.
Kitap Ekleme: Yeni kitap eklenebilir.
Kitap Düzenleme: Mevcut kitap bilgileri düzenlenebilir.
Kitap Silme: Bir kitabın silinmesi için onay alınır ve ardından kitap silinir.
2. Yazar Yönetimi:
Yazar Listesi: Sistemdeki yazarlar listelenir. Yazar silme işlemi burada yapılır.
Yazar Detayları: Seçilen yazarın detay bilgileri görüntülenir.
Yazar Ekleme/Düzenleme: Yeni yazar ekleme veya mevcut yazar bilgilerini güncelleme işlemleri yapılır.
3. Üye Yönetimi:
Kayıt Olma (Sign Up): Kullanıcılar kayıt işlemlerini bu sayfadan gerçekleştirir.
Giriş Yapma (Login): Sisteme giriş işlemi, kullanıcı adı ve şifre ile yapılır.
4. Ana Sayfa ve Hakkında:
Projede bir HomeController aracılığıyla anasayfa ve hakkında sayfaları sunulmuştur.
Footer: Sayfanın alt kısmında sabit bir "hakların saklı olduğu" yazısı eklenmiştir.
Test Etme
1. Manuel Test Süreci:
Proje geliştirilirken aşağıdaki adımlar manuel olarak test edilmiştir:

Kitap İşlemleri:

Yeni kitap eklenip eklenemediği, listeye yansıyıp yansımadığı test edildi.
Var olan bir kitabın düzenleme ve silme işlemlerinin doğru çalışıp çalışmadığı kontrol edildi.
Yazar İşlemleri:

Yazar ekleme, listeleme, düzenleme ve silme işlemleri doğru çalışıyor mu test edildi.
Kullanıcı İşlemleri:

Kayıt olma ve giriş yapma sayfalarının form doğrulamaları test edildi.
Yanlış bilgilerle giriş yapılmaya çalışıldığında hata mesajlarının doğru gösterildiği doğrulandı.
2. Fonksiyon Testleri:
Model Binding Testi: Formlardan gönderilen verilerin modellerle eşleşip eşleşmediği kontrol edildi.
Validasyon Testi: Kayıt olma ve giriş yapma sayfalarındaki validasyon kurallarının doğru çalıştığı test edildi.
