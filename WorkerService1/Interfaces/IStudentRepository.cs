using GrupoAEducacao.Domain.Models;

namespace GrupoAEducacao.Domain.Interfaces
{
    public interface IStudentRepository
    {
        public Task<IEnumerable<Student>> ListAllStudents();
        public Task<Student> GetStudentAsync(int id);
        public Task<int> AddStudentAsync(Student student);
        public Task<int> EditStudentAsync(Student student);
        public Task<bool> DeleteStudentAsync(int id);
    }
}
