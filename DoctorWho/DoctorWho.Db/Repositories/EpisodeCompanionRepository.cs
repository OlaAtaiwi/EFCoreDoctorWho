
namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository
    {
        public static void AddCompanionToEpisode(int episodeId, int companionId)
        {
            var episode = DoctorWhoCoreDbContext._context.Episodes.Find(episodeId);
            if (episode != null)
            {
                episode.EpisodeCompanions.Add(new EpisodeCompanion { CompanionId = companionId, EpisodeId = episodeId });
                DoctorWhoCoreDbContext._context.SaveChanges();
            }
        }
    }
}
