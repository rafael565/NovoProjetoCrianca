using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovoProjetoCrianca.Models
{

    [Table("Materias")]
    public class Materia
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }
        public Curso curso { get; set; }
        [Display(Name = "Cursos: ")]
        public int CursoID { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Nome da Materia: ")]
        public string nome { get; set; }
    }
}
