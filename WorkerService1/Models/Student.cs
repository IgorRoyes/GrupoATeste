using System.ComponentModel.DataAnnotations.Schema;

namespace GrupoAEducacao.Domain.Models
{
    [Table("students")]
    public class Student
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("ra")]
        public string AcademicRegister { get; set; }

        [Column("cpf")]
        public string CPF { get; set; }
    }
}
