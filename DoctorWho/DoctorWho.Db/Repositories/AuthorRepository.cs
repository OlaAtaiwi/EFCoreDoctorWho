
namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        public static void CreateAuthor(string AuthorName)
        {
            if (AuthorName != null)
            {
                var author = new Author { AuthorName = AuthorName };
                DoctorWhoCoreDbContext._context.Authors.Add(author);
                DoctorWhoCoreDbContext._context.SaveChanges();
                Console.WriteLine($"Author {AuthorName} Created");
            }
        }
        public static void DeleteAuthor(string AuthorName)
        {
            if (AuthorName != null)
            {
                var author = DoctorWhoCoreDbContext._context.Authors.Where(a => a.AuthorName == AuthorName).FirstOrDefault();
                if (author != null)
                {
                    DoctorWhoCoreDbContext._context.Authors.Remove(author);
                    DoctorWhoCoreDbContext._context.SaveChanges();
                    Console.WriteLine($"Author {AuthorName} Deleted");
                }
            }
        }
        public static void UpdateAuthor(Author auth)
        {
            DoctorWhoCoreDbContext._context.Authors.Update(auth);
            DoctorWhoCoreDbContext._context.SaveChanges();
        }
    }
}
