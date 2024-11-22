using System.ComponentModel.DataAnnotations;

namespace NovoProjetoCrianca.Enum
{
    public enum HistoricoFamiliar
    {
        [Display(Name = "Pobreza Extrema")]
        PobrezaExtrema = 0,

        [Display(Name = "Abandono")]
        Abandono = 1,

    }
}