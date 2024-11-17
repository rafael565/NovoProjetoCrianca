using System.ComponentModel.DataAnnotations;

namespace NovoProjetoCrianca.Enum
{
    public enum Cidade
    {
        [Display(Name = "Assis")]
        Assis = 0,

        [Display(Name = "Candido Mota")]
        CandidoMota = 1,

        [Display(Name = "Palmital")]
        Palmital = 2,

        [Display(Name = "Paraguaçu")]
        Paraguaçu = 3,
    }
}