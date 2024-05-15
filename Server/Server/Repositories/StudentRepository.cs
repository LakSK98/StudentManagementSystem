using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;
using System;

namespace Server.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ServerDbContext _context;

        public StudentRepository(ServerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> AddAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }
    }
}
