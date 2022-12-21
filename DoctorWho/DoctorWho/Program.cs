using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;


Console.WriteLine("Hello, World!");

AddEnemyToEpisode(1, 5);
void AddCompanionToEpisode(int episodeId,int companionId)
{
    var episode = DoctorWhoCoreDbContext._context.Episodes.Find(episodeId);
    if(episode!=null)
    {
        episode.EpisodeCompanions.Add(new EpisodeCompanion { CompanionId=companionId, EpisodeId=episodeId });
        DoctorWhoCoreDbContext._context.SaveChanges();
    }
}

void AddEnemyToEpisode(int episodeId, int enemyId)
{
    var episode = DoctorWhoCoreDbContext._context.Episodes.Find(episodeId);
    if(episode!= null)
    {
        episode.EpisodeEnemies.Add(new EpisodeEnemy { EnemyId=enemyId, EpisodeId=episodeId });
        DoctorWhoCoreDbContext._context.SaveChanges();
    }
}