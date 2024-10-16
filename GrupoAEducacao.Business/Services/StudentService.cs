using GrupoAEducacao.Business.DTOs;
using GrupoAEducacao.Business.Interfaces;
using GrupoAEducacao.Domain.Interfaces;
using GrupoAEducacao.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoAEducacao.Business.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDto>> ListAllStudents()
        {
            var studentsDtoList = new List<StudentDto>();
            var studentList = await _studentRepository.ListAllStudents();
            
            foreach ( var studentItem in studentList)
            {
                var studentDto = MapStudentEntityToDto(studentItem);

                studentsDtoList.Add(studentDto);
            }

            return studentsDtoList.ToList();
        }

        public async Task<StudentDto> GetStudentAsync(int id)
        {
            var student = await _studentRepository.GetStudentAsync(id);

            var studentDto = MapStudentEntityToDto(student);

            return studentDto;
        }

        public async Task<int> AddStudentAsync(StudentDto studentDto)
        {
            var student = MapStudentDtoToEntity(studentDto);

            return await _studentRepository.AddStudentAsync(student);
        }

        public async Task<int> EditStudentAsync(StudentDto studentDto)
        {
            var student = MapStudentDtoToEntity(studentDto);

            return await _studentRepository.EditStudentAsync(student);
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            return await _studentRepository.DeleteStudentAsync(id);
        }

        private StudentDto MapStudentEntityToDto(Student student)
        {
            return new StudentDto()
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email,
                AcademicRegister = student.AcademicRegister,
                CPF = student.CPF
            };
        }

        private Student MapStudentDtoToEntity(StudentDto studentDto)
        {
            return new Student()
            {
                Id = studentDto.Id,
                Name = studentDto.Name,
                Email = studentDto.Email,
                AcademicRegister = studentDto.AcademicRegister,
                CPF = studentDto.CPF
            };
        }
    }
}
