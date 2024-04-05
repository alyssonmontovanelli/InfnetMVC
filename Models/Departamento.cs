using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.Models
{
    public class Departamento
    {

        [Key]
        public int DepartamentoId { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Local { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; } = new HashSet<Funcionario>();

    }
}
