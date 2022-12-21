using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class CallsRepository
    {
        public static void CallViewEpisodesView()
        {
            var episodes = DoctorWhoCoreDbContext._context.ViewEpisodes.ToList();

            Console.WriteLine(String.Format("{0, 5}|{1, 5}|{2, 5}|{3, 5}",
                    "Doctor_Name", "Author_Name", "Companions", "Enemies"));
            foreach (var epesode in episodes)
            {
                Console.WriteLine(String.Format("{0, 5}|{1, 5}|{2, 5}|{3, 5}",
                   epesode.DoctorName, epesode.AuthorName, epesode.Companions, epesode.Enemies));
            }
        }
        public static void CallfnCompanionsFunction(int id)
        {
            var companions = DoctorWhoCoreDbContext._context.Companions.Select(c => DoctorWhoCoreDbContext._context.CallFnCompanions(id)).FirstOrDefault();
            Console.WriteLine(companions);
        }
        public static void CallfnEnemiesFunction(int id)
        {
            var enemies = DoctorWhoCoreDbContext._context.Enemies.Select(e => DoctorWhoCoreDbContext._context.CallFnEnemies(id)).FirstOrDefault();
            Console.WriteLine(enemies);
        }
    }
}
