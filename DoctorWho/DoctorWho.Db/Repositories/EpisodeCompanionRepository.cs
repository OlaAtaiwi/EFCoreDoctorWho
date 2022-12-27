
namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository
    {
        private DoctorWhoCoreDbContext _context;
        public EpisodeCompanionRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void AddCompanionToEpisode(int episodeId, int companionId)
        {
            var episode = _context.Episodes.Find(episodeId);
            if (episode != null)
            {
                episode.EpisodeCompanions.Add(new EpisodeCompanion { CompanionId = companionId, EpisodeId = episodeId });
                _context.SaveChanges();
            }
        }
    }
}
