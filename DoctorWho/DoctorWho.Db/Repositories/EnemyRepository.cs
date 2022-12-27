
namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository
    {
        private DoctorWhoCoreDbContext _context;
        public EnemyRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void CreateEnemy(string enemyName)
        {
            if (!string.IsNullOrEmpty(enemyName))
            {
                var enemy = new Enemy { EnemyName = enemyName };
                _context.Enemies.Add(enemy);
                _context.SaveChanges();
                Console.WriteLine("Enemy Created");
            }
        }

        public void DeleteEnemy(string enemyName)
        {
            var enemy = _context.Enemies.Where(e => e.EnemyName == enemyName).FirstOrDefault();
            if (enemy != null)
            {
                _context.Enemies.Remove(enemy);
                _context.SaveChanges();
                Console.WriteLine("Enemy Deleted");
            }
        }

        public void UpdateEnemy(Enemy enemy)
        {
            _context.Enemies.Update(enemy);
            _context.SaveChanges();
        }

        Enemy GetEnemyById(int id)
        {
            var enemy = _context.Enemies.Find(id);
            if (enemy != null)
            {
                return enemy;
            }
            throw new NullReferenceException("No enemies with the provided Id !");
        }
    }
}
