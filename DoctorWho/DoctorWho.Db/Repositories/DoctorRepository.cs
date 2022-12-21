
namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository
    {
        public static void CreateDoctor(string doctorName, int doctorNumber)
        {
            if (doctorName != null)
            {
                var doctor = new Doctor { DoctorName = doctorName, DoctorNumber = doctorNumber };
                DoctorWhoCoreDbContext._context.Doctors.Add(doctor);
                DoctorWhoCoreDbContext._context.SaveChanges();
                Console.WriteLine("Doctor Created");
            }
        }

        public static void DeleteDoctor(string doctorName)
        {
            if (doctorName != null)
            {
                var doctor = DoctorWhoCoreDbContext._context.Doctors.Where(d => d.DoctorName == doctorName).FirstOrDefault();
                if (doctor != null)
                {
                    DoctorWhoCoreDbContext._context.Doctors.Remove(doctor);
                    DoctorWhoCoreDbContext._context.SaveChanges();
                    Console.WriteLine("Doctor Deleted");
                }
            }
        }

        public static void UpdateDoctor(Doctor doctor)
        {
            DoctorWhoCoreDbContext._context.Doctors.Update(doctor);
            DoctorWhoCoreDbContext._context.SaveChanges();
        }

        List<Doctor> GetAllDoctors()
        {
            return DoctorWhoCoreDbContext._context.Doctors.ToList();
        }
    }
}
