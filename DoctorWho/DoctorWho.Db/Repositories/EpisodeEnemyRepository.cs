
namespace DoctorWho.Db.Repositories
{
    public class EpisodeEnemyRepository
    {
        public static void AddEnemyToEpisode(int episodeId, int enemyId)
        {
            var episode = DoctorWhoCoreDbContext._context.Episodes.Find(episodeId);
            if (episode != null)
            {
                episode.EpisodeEnemies.Add(new EpisodeEnemy { EnemyId = enemyId, EpisodeId = episodeId });
                DoctorWhoCoreDbContext._context.SaveChanges();
            }
        }
    }
}
