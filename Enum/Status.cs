using System.ComponentModel.DataAnnotations;

namespace NovoProjetoCrianca.Enum
{
    public enum Status
    {
        [Display(Name = "Ativo")]
        Ativo = 0,

        [Display(Name = "Desativado")]
        Desativado = 1,

    }
}