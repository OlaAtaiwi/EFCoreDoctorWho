
namespace DoctorWho.Db.Repositories
{
    public class CallsRepository
    {
        private DoctorWhoCoreDbContext _context;
        public CallsRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void ViewEpisodes()
        {
            var episodes = _context.ViewEpisodes.ToList();
            
            Console.WriteLine(String.Format("{0, 5}|{1, 5}|{2, 5}|{3, 5}",
                    "Doctor_Name", "Author_Name", "Companions", "Enemies"));
            foreach (var epesode in episodes)
            {
                Console.WriteLine(String.Format("{0, 5}|{1, 5}|{2, 5}|{3, 5}",
                   epesode.DoctorName, epesode.AuthorName, epesode.Companions, epesode.Enemies));
            }
        }
        public string CompanionsForEpisode(int id)
        {
            var companions = _context.Companions.Select(c =>_context.CallFnCompanions(id)).FirstOrDefault();
            return companions;
        }
        public string EnemiesForEpisode(int id)
        {
            var enemies =_context.Enemies.Select(e =>_context.CallFnEnemies(id)).FirstOrDefault();
            return enemies;
        }
    }
}
