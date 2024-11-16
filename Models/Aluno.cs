using NovoProjetoCrianca.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovoProjetoCrianca.Models
{
   
    [Table("Alunos")]
    public class Aluno
    {

        [Display(Name = "ID: ")]
        public int id { get; set; }

        public DadoFamilia dadofamilia { get; set; }
        [Display(Name = "Dados da Familia: ")]
        public int dadofamiliaID { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Nome: ")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        [StringLength(35)]
        [Display(Name = "CPF: ")]
        public string cpf { get; set; }


        
        
        [Display(Name = "Genero: ")]
        public Genero genero { get; set; }

        
        [Display(Name = "Escolaridade: ")]
        public Escolaridade escolaridade { get; set; }


        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateOnly DatadeNascimento { get; set; }


        [Required(ErrorMessage = "Campo E-mail é obrigatório")]
        [StringLength(35)]
        [Display(Name = "E-mail: ")]
        public string email { get; set; }




    }
}
