using AutoMapper;
using Server.DTOs;
using Server.Models;
using Server.Repositories;

namespace Server.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(StudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StudentDTO>> GetAllStudentsAsync()
        {
            var students = _mapper.Map<IEnumerable<StudentDTO>>(await _studentRepository.GetAllAsync());
            return students;
        }

        public async Task<StudentDTO> AddStudentAsync(Student student)
        {
            return _mapper.Map<StudentDTO>(await _studentRepository.AddAsync(student));
        }
    }
}
