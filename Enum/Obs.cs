using System.ComponentModel.DataAnnotations;

namespace NovoProjetoCrianca.Enum
{
    public enum Obs
    {
        [Display(Name = "Resolvido")]
        Resolvido = 0,

        [Display(Name = "Nao Resolvido")]
        NaoResolvido = 1,

    }
}