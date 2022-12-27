
namespace DoctorWho.Db.Repositories
{
    public class CallsRepository
    {
        private DoctorWhoCoreDbContext _context;
        public CallsRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void CallViewEpisodesView()
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
        public void CallfnCompanionsFunction(int id)
        {
            var companions = _context.Companions.Select(c =>_context.CallFnCompanions(id)).FirstOrDefault();
            Console.WriteLine(companions);
        }
        public void CallfnEnemiesFunction(int id)
        {
            var enemies =_context.Enemies.Select(e =>_context.CallFnEnemies(id)).FirstOrDefault();
            Console.WriteLine(enemies);
        }
    }
}
