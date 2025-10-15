namespace Day1ITIASP.Models
{
    public interface IInstructorRepository
    {
        IEnumerable<Instructor> GetAll();
        Instructor? GetById(int id);
        void Add(Instructor instructor);
        void Update(Instructor instructor);
       
        void Save();
    }

}
