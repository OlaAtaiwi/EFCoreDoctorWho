
namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository
    {
        public static void CreateCompanion(string companionName, string WhoPlayed)
        {
            if (companionName != null)
            {
                var companion = new Companion { CompanionName = companionName, WhoPlayed = WhoPlayed };
                DoctorWhoCoreDbContext._context.Companions.Add(companion);
                DoctorWhoCoreDbContext._context.SaveChanges();
                Console.WriteLine("Companion Created");
            }
        }

        public static void DeleteCompanion(string companionName)
        {
            var companion = DoctorWhoCoreDbContext._context.Companions.Where(c => c.CompanionName == companionName).FirstOrDefault();
            if (companion != null)
            {
                DoctorWhoCoreDbContext._context.Companions.Remove(companion);
                DoctorWhoCoreDbContext._context.SaveChanges();
                Console.WriteLine("Companion Deleted");
            }
        }

        public static void UpdateCompanion(Companion companion)
        {
            DoctorWhoCoreDbContext._context.Companions.Update(companion);
            DoctorWhoCoreDbContext._context.SaveChanges();
        }

        Companion GetCompanionById(int id)
        {
            var companion = DoctorWhoCoreDbContext._context.Companions.Find(id);
            if (companion != null)
            {
                return companion;
            }
            throw new NullReferenceException("No companions with the provided Id !");
        }
    }
}
