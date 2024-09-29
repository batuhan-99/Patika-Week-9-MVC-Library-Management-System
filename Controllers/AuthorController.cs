using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        // Örnek yazar verileri
        private static List<Author> authors = new List<Author>
    {
        new Author { Id = 1, FirstName = "Ali", LastName = "Yılmaz", DateOfBirth = new DateTime(1970, 5, 12) },
        new Author { Id = 2, FirstName = "Ayşe", LastName = "Demir", DateOfBirth = new DateTime(1980, 8, 23) },
        new Author { Id = 3, FirstName = "Mehmet", LastName = "Kara", DateOfBirth = new DateTime(1965, 3, 19) }
    };

        // Yazarların listelenmesi
        public IActionResult List()
        {
            return View(authors);
        }

        // Belirli bir yazarın detayları
        public IActionResult Details(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        // Yeni yazar ekleme formu
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Yeni yazar ekleme işlemi
        [HttpPost]
        public IActionResult Create(Author newAuthor)
        {
            newAuthor.Id = authors.Max(a => a.Id) + 1; // Yeni yazar id'si
            authors.Add(newAuthor);
            return RedirectToAction("List");
        }

        // Yazar düzenleme formu
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        // Yazar düzenleme işlemi
        [HttpPost]
        public IActionResult Edit(Author updatedAuthor)
        {
            var author = authors.FirstOrDefault(a => a.Id == updatedAuthor.Id);
            if (author == null)
            {
                return NotFound();
            }

            author.FirstName = updatedAuthor.FirstName;
            author.LastName = updatedAuthor.LastName;
            author.DateOfBirth = updatedAuthor.DateOfBirth;
            return RedirectToAction("List");
        }

        // Yazar silme işlemi
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author != null)
            {
                authors.Remove(author);
            }
            return RedirectToAction("List");
        }
    }
}
