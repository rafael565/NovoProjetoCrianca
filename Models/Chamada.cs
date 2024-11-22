using NovoProjetoCrianca.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovoProjetoCrianca.Models
{
    [Table("Chamadas")]
    public class Chamada
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }

        public Matricula matricula { get; set; }
        [Display(Name = "Matricula: ")]
        public int matriculaID { get; set; }


        [Display(Name = "Data de Chamada: ")]
        public DateTime DatadeChamada { get; set; }

        [Required(ErrorMessage = "Campo Presença é obrigatório")]
        [Display(Name = "Presença: ")]
        public bool Presenca { get; set; }
        

    }
}
