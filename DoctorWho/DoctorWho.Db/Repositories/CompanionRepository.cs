
namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository
    {
        private DoctorWhoCoreDbContext _context;
        public CompanionRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void CreateCompanion(string companionName, string whoPlayed)
        {
            if (!string.IsNullOrEmpty(companionName))
            {
                var companion = new Companion { CompanionName = companionName, WhoPlayed = whoPlayed };
                _context.Companions.Add(companion);
                _context.SaveChanges();
                Console.WriteLine("Companion Created");
            }
        }

        public void DeleteCompanion(string companionName)
        {
            var companion =_context.Companions.Where(c => c.CompanionName == companionName).FirstOrDefault();
            if (companion != null)
            {
                _context.Companions.Remove(companion);
                _context.SaveChanges();
                Console.WriteLine("Companion Deleted");
            }
        }

        public void UpdateCompanion(Companion companion)
        {
            _context.Companions.Update(companion);
            _context.SaveChanges();
        }

        Companion GetCompanionById(int id)
        {
            var companion = _context.Companions.Find(id);
            if (companion != null)
            {
                return companion;
            }
            throw new NullReferenceException("No companions with the provided Id !");
        }
    }
}
