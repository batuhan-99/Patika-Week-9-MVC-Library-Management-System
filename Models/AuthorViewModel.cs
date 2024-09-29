namespace LibraryManagementSystem.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<BookViewModel> Books { get; set; }
    }
}
