using GrupoAEducacao.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace GrupoAEducacao.Domain.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) 
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
