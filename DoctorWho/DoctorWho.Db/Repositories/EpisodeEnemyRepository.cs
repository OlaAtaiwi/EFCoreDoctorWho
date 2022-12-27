
namespace DoctorWho.Db.Repositories
{
    public class EpisodeEnemyRepository
    {
        private DoctorWhoCoreDbContext _context;
        public EpisodeEnemyRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void AddEnemyToEpisode(int episodeId, int enemyId)
        {
            var episode = _context.Episodes.Find(episodeId);
            if (episode != null)
            {
                episode.EpisodeEnemies.Add(new EpisodeEnemy { EnemyId = enemyId, EpisodeId = episodeId });
                _context.SaveChanges();
            }
        }
    }
}
