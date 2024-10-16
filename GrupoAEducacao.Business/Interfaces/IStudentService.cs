using GrupoAEducacao.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoAEducacao.Business.Interfaces
{
    public interface IStudentService
    {
        public Task<List<StudentDto>> ListAllStudents();
        public Task<StudentDto> GetStudentAsync(int id);
        public Task<int> EditStudentAsync(StudentDto studentDto);
        public Task<bool> DeleteStudentAsync(int id);
    }
}
