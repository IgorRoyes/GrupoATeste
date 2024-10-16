using GrupoAEducacao.Business.DTOs;
using GrupoAEducacao.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApplication1;

namespace GrupoAEducacao.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("ListAllStudents")]
        public async Task<List<StudentDto>> ListAllStudents()
        {
            return await _studentService.ListAllStudents();
        }

        [HttpGet("GetStudentAsync/{id:int}")]
        public async Task<StudentDto> GetStudentAsync(int id)
        {
            return await _studentService.GetStudentAsync(id);
        }

        [HttpPost("AddStudentAsync")]
        public async Task<int> AddStudentAsync(StudentDto studentDto)
        {
            return await _studentService.AddStudentAsync(studentDto);
        }

        [HttpPost("EditStudentAsync")]
        public async Task<int> EditStudentAsync(StudentDto studentDto)
        {
            return await _studentService.EditStudentAsync(studentDto);
        }

        [HttpPost("DeleteStudentAsync{id:int}")]
        public async Task<bool> DeleteStudentAsync(int id)
        {
            return await _studentService.DeleteStudentAsync(id);
        }
    }
}
