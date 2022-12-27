
namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        private DoctorWhoCoreDbContext _context;
        public EpisodeRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void CreateEpisode(Episode episode)
        {
            _context.Episodes.Add(episode);
            _context.SaveChanges();
            Console.WriteLine("Episode Created");
        }

        public void DeleteEpisode(int episodeNumber, string episodeTitle)
        {
            var episode = _context.Episodes.Where(e => e.EpisodeNumber == episodeNumber && e.Title == episodeTitle).FirstOrDefault();
            if (episode != null)
            {
                _context.Episodes.Remove(episode);
                _context.SaveChanges();
                Console.WriteLine("Episode Deleted");
            }
        }
        public void UpdateEpisode(Episode episode)
        {
            _context.Episodes.Update(episode);
            _context.SaveChanges();
        }
    }
}
