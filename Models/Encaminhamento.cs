using NovoProjetoCrianca.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovoProjetoCrianca.Models
{
    [Table("Encaminhamentos")]
    public class Encaminhamento
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }

        public Entidade entidade { get; set; }
        [Display(Name = "Entidade: ")]
        public int entidadeID { get; set; }

        public AssistenteSocial assistentesocial { get; set; }
        [Display(Name = "Assistente Social: ")]
        public int assistentesocialID { get; set; }

        public Aluno aluno { get; set; }
        [Display(Name = "Aluno: ")]
        public int alunoID { get; set; }

        [Required(ErrorMessage = "Campo Motivo é obrigatório")]
        [StringLength(50)]
        [Display(Name = "Motivo: ")]
        public bool motivo { get; set; }

        [Display(Name = "Data do Encaminhamento: ")]
        public DateTime DatadeEncaminhamento { get; set; }



    }
}
