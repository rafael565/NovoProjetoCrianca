using System.ComponentModel.DataAnnotations;

namespace NovoProjetoCrianca.Enum
{
    public enum Motivo
    {
        [Display(Name = "Evasao Escolar")]
        EvasaoEscolar = 0,

        [Display(Name = "Abandono Familiar")]
        AbandonoFamiliar = 1,

    }
}