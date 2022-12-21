
namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository
    {
        public static void CreateEnemy(string enemyName)
        {
            if (enemyName != null)
            {
                var enemy = new Enemy { EnemyName = enemyName };
                DoctorWhoCoreDbContext._context.Enemies.Add(enemy);
                DoctorWhoCoreDbContext._context.SaveChanges();
                Console.WriteLine("Enemy Created");
            }
        }
        public static void DeleteEnemy(string enemyName)
        {
            var enemy = DoctorWhoCoreDbContext._context.Enemies.Where(e => e.EnemyName == enemyName).FirstOrDefault();
            if (enemy != null)
            {
                DoctorWhoCoreDbContext._context.Enemies.Remove(enemy);
                DoctorWhoCoreDbContext._context.SaveChanges();
                Console.WriteLine("Enemy Deleted");
            }
        }
        public static void UpdateEnemy(Enemy enemy)
        {
            DoctorWhoCoreDbContext._context.Enemies.Update(enemy);
            DoctorWhoCoreDbContext._context.SaveChanges();
        }
    }
}
