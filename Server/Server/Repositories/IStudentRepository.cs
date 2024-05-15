using Server.Models;

namespace Server.Repositories
{
    public interface IStudentRepository
    {
        public Task<IEnumerable<Student>> GetAllAsync();
        public Task<Student> AddAsync(Student student);
    }
}
