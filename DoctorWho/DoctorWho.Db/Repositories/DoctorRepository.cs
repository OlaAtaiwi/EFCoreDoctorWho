
namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository
    {
        private DoctorWhoCoreDbContext _context;
        public DoctorRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void CreateDoctor(string doctorName, int doctorNumber)
        {
            if (!string.IsNullOrEmpty(doctorName))
            {
                var doctor = new Doctor { DoctorName = doctorName, DoctorNumber = doctorNumber };
                _context.Doctors.Add(doctor);
                _context.SaveChanges();
                Console.WriteLine("Doctor Created");
            }
        }

        public void DeleteDoctor(string doctorName)
        {
            if (!string.IsNullOrEmpty(doctorName))
            {
                var doctor =_context.Doctors.Where(d => d.DoctorName == doctorName).FirstOrDefault();
                if (doctor != null)
                {
                    _context.Doctors.Remove(doctor);
                    _context.SaveChanges();
                    Console.WriteLine("Doctor Deleted");
                }
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            _context.Doctors.Update(doctor);
            _context.SaveChanges();
        }

        List<Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }
    }
}
