using Microsoft.EntityFrameworkCore;

namespace Day1ITIASP.Models
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly AppDBcontext _Db= new AppDBcontext();
        public void Add(Instructor instructor)
        {
            _Db?.Instructors.Add(instructor);
        }

      

        public IEnumerable<Instructor> GetAll()
        {
            return _Db.Instructors.AsNoTracking().
                OrderBy(i => i.HireDate).
                ToList();
        }

        public Instructor? GetById(int id)
        {
            return _Db?.Instructors.Find(id);
        }

        public void Save()
        {
            _Db?.SaveChanges();
        }

        public void Update(Instructor instructor)
        {
            _Db?.Instructors.Update(instructor);
        }
    }


}
