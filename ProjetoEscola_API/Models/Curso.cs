using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEscola_API.Models
{
    public class Curso
    {
        [Display(Name = "Código", Description = "Informe um inteiro entre 1 e 99999.")]
        public int id { get; set; }

        [Display(Name = "Código do Curso", Description = "O Código do Curso que o aluno está cursando.")]
        [Required(ErrorMessage = "O campo CodCurso é obrigatório.")]
        [Range(1, 99, ErrorMessage = "Digite o {0} sendo um número entre {1}-{2}.")]
        public int codCurso { get; set; }

        [Display(Name = "Nome", Description = "Nome do Curso")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(30, ErrorMessage = "O campo Nome não pode ultrapassar {1} caracteres")]
        public string? nomeCurso { get; set; }

        [Display(Name = "Periodo", Description = "O Periodo deve estar no formato X.")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "O campo {0} não respeita o formato de Periodo: X")]
        public string? periodo { get; set; }
    }
}

