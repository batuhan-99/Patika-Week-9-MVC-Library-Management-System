using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "Kitap 1", Genre = "Roman", AuthorId = 1, PublishDate = new DateTime(2020, 1, 1), ISBN = "123456789", CopiesAvailable = 5 },
        new Book { Id = 2, Title = "Kitap 2", Genre = "Bilim Kurgu", AuthorId = 2, PublishDate = new DateTime(2021, 6, 15), ISBN = "987654321", CopiesAvailable = 3 },
        new Book { Id = 3, Title = "Kitap 3", Genre = "Felsefe", AuthorId = 1, PublishDate = new DateTime(2019, 10, 22), ISBN = "456789123", CopiesAvailable = 2 },
        new Book { Id = 4, Title = "Kitap 4", Genre = "Tarih", AuthorId = 3, PublishDate = new DateTime(2022, 5, 18), ISBN = "321654987", CopiesAvailable = 1 },
        new Book { Id = 5, Title = "Kitap 5", Genre = "Psikoloji", AuthorId = 2, PublishDate = new DateTime(2018, 3, 12), ISBN = "789123456", CopiesAvailable = 4 }
    };
        

        public IActionResult List()
        {
            var viewModel = books.Select(x => new BookViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Genre = x.Genre,
                AuthorId = x.AuthorId,
                PublishDate = x.PublishDate,
                ISBN = x.ISBN,
                CopiesAvailable = x.CopiesAvailable

            }).ToList();
            return View(viewModel);
        }

        // Belirli bir kitabın detaylarını gösterir
        public IActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // Yeni bir kitap eklemek için form sağlar
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book newBook)
        {
            newBook.Id = books.Max(b => b.Id) + 1; // Yeni kitap id'si
            books.Add(newBook);
            return RedirectToAction("List");
        }
        // Var olan bir kitabı düzenlemek için form sağlar
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        // Kitap düzenleme işlemi
        [HttpPost]
        public IActionResult Edit(Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (book == null)
            {
                return NotFound();
            }

            book.Title = updatedBook.Title;
            book.Genre = updatedBook.Genre;
            book.PublishDate = updatedBook.PublishDate;
            book.ISBN = updatedBook.ISBN;
            book.CopiesAvailable = updatedBook.CopiesAvailable;
            return RedirectToAction("List");
        }
        // Kitabı silmek için bir onay sayfası sağlar
        // Kitap silme işlemi
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
            return RedirectToAction("List");
        }

    }
}
