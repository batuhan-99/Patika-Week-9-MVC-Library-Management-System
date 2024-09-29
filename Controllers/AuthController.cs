using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AuthController : Controller
    {
        // Örnek kullanıcı verileri
        private static List<User> users = new List<User>
        {
            new User { Id = 1, FullName = "User One", Email = "user1@example.com", Password = "password1", PhoneNumber = "1234567890", JoinDate = DateTime.Now },
            new User { Id = 2, FullName = "User Two", Email = "user2@example.com", Password = "password2", PhoneNumber = "0987654321", JoinDate = DateTime.Now }
        };

        // Giriş yapma (Login)
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                // Giriş başarılı, kullanıcıyı ana sayfaya yönlendiriyoruz
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Giriş başarısız, hata mesajı göster
                ViewBag.ErrorMessage = "Geçersiz email veya şifre.";
                return View();
            }
        }

        // Kayıt olma (SignUp)
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User newUser, string passwordRepeat)
        {
            // Şifre tekrar kontrolü
            if (newUser.Password != passwordRepeat)
            {
                ViewBag.ErrorMessage = "Şifreler uyuşmuyor.";
                return View();
            }

            // Email'in daha önce kullanılıp kullanılmadığını kontrol et
            if (users.Any(u => u.Email == newUser.Email))
            {
                ViewBag.ErrorMessage = "Bu email zaten kayıtlı.";
                return View();
            }

            // Yeni kullanıcıyı listeye ekle
            newUser.Id = users.Max(u => u.Id) + 1; // Yeni kullanıcı için ID belirle
            newUser.JoinDate = DateTime.Now; // Kayıt tarihi atanıyor
            users.Add(newUser);

            // Kayıt başarılı, giriş sayfasına yönlendir
            return RedirectToAction("Login");
        }

    }
}
