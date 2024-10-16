using GrupoAEducacao.Domain.Data;
using GrupoAEducacao.Domain.Interfaces;
using GrupoAEducacao.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace GrupoAEducacao.Domain.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _context;

        public StudentRepository(StudentContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> ListAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null) 
                return new Student(); //Igor: Implementar Excessão

            return student;
        }
        
        public async Task<int> AddStudentAsync(Student student)
        {
            _context.Students.Add(student);

            await _context.SaveChangesAsync();

            return student.Id;
        }

        public async Task<int> EditStudentAsync(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return student.Id;
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
                return false; //Igor: Implementar Excessão

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
