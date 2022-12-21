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

List<Doctor> GetAllDoctors()
{
   return DoctorWhoCoreDbContext._context.Doctors.ToList();
}

Enemy GetEnemyById(int id)
{
    var enemy= DoctorWhoCoreDbContext._context.Enemies.Find(id);
    if(enemy!=null)
    {
        return enemy;
    }
    throw new NullReferenceException("No enemies with the provided Id !");
}

Companion GetCompanionById(int id)
{
    var companion = DoctorWhoCoreDbContext._context.Companions.Find(id);
    if(companion!=null)
    {
        return companion;
    }
    throw new NullReferenceException("No companions with the provided Id !");
}