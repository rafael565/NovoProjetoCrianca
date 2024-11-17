using NovoProjetoCrianca.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovoProjetoCrianca.Models
{
    [Table("Entidades")]
    public class Entidade
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Nome da entidade : ")]
        public string nomeEntidade { get; set; }

        [Required(ErrorMessage = "Campo Endereço é obrigatório")]
        [StringLength(50)]
        [Display(Name = "Endereço : ")]

        public string endereco { get; set; }

        [Required(ErrorMessage = "Campo Status Contrato é obrigatório")]

        [Display(Name = "Status do Contrato: ")]
        public Status statusContrato { get; set; }


        [Display(Name = "Data de Inicio: ")]
        public DateOnly DatadeInicio { get; set; }

        [Display(Name = "Data de Fim: ")]
        public DateOnly DatadoFim { get; set; }


    }
}
