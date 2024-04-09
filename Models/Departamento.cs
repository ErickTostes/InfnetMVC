using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "O campo Local deve ter no máximo {1} caracteres")]
        public string Local { get; set; }
    }
}