
namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        public static void CreateEpisode(int seriesNumber, int episodeNumber, string episodeType, string title, int authorId, int doctorId, DateTime date)
        {
            var episode = new Episode
            {
                SeriesNumber = seriesNumber,
                EpisodeNumber = episodeNumber,
                EpisodeType = episodeType,
                Title = title,
                AuthorId = authorId,
                DoctorId = doctorId,
                EpisodeDate = date,
            };
            DoctorWhoCoreDbContext._context.Episodes.Add(episode);
            DoctorWhoCoreDbContext._context.SaveChanges();
            Console.WriteLine("Episode Created");
        }

        public static void DeleteEpisode(int episodeNumber, string episodeTitle)
        {
            var episode = DoctorWhoCoreDbContext._context.Episodes.Where(e => e.EpisodeNumber == episodeNumber && e.Title == episodeTitle).FirstOrDefault();
            if (episode != null)
            {
                DoctorWhoCoreDbContext._context.Episodes.Remove(episode);
                DoctorWhoCoreDbContext._context.SaveChanges();
                Console.WriteLine("Episode Deleted");
            }
        }
        public static void UpdateEpisode(Episode episode)
        {
            DoctorWhoCoreDbContext._context.Episodes.Update(episode);
            DoctorWhoCoreDbContext._context.SaveChanges();
        }
    }
}
