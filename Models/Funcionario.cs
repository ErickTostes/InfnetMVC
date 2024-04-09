using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.Models
{
    public class Funcionario
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")] 
        [StringLength(50, ErrorMessage = "O campo Nome deve ter no máximo 50 caracteres")] 
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)] 
        public string Email { get; set; }

        [Range(18, 100, ErrorMessage = "A idade deve estar entre 18 e 100 anos")] 
        public int Idade { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{3}-\d{2}$", ErrorMessage = "O formato do CPF deve ser XXX-XXX-XXX-XX")] 
        public string CPF { get; set; }

        [DataType(DataType.Date)] 
        public DateTime DataNascimento { get; set; }
    }
}
