using Server.DTOs;
using Server.Models;

namespace Server.Services
{
    public interface IStudentService
    {
        public Task<IEnumerable<StudentDTO>> GetAllStudentsAsync();
        public Task<StudentDTO> AddStudentAsync(Student student);
    }
}
