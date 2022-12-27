
namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        private DoctorWhoCoreDbContext _context;
        public AuthorRepository(DoctorWhoCoreDbContext context)
        {
                _context=context;
        }
        public  void CreateAuthor(string authorName)
        {
            if (!string.IsNullOrEmpty(authorName))
            {
                var author = new Author { AuthorName = authorName };
                _context.Authors.Add(author);
                _context.SaveChanges();
                Console.WriteLine($"Author {authorName} Created");
            }
        }
        public void DeleteAuthor(string authorName)
        {
            if (!string.IsNullOrEmpty(authorName))
            {
                var author =_context.Authors.Where(a => a.AuthorName == authorName).FirstOrDefault();
                if (author != null)
                {
                    _context.Authors.Remove(author);
                    _context.SaveChanges();
                    Console.WriteLine($"Author {authorName} Deleted");
                }
            }
        }
        public void UpdateAuthor(Author auth)
        {
           _context.Authors.Update(auth);
           _context.SaveChanges();
        }
    }
}
