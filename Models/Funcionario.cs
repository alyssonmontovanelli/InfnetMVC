using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.Models
{
    public class Funcionario
    {

        [Key]
        public int FuncionarioId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateOnly DataNascimento { get; set; }

        [ForeignKey("Departamento")]
        [Display(Name = "Departamento")]
        public int DepartamentoId { get; set; }

        public virtual Departamento? Departamento { get; set; }

    }
}
