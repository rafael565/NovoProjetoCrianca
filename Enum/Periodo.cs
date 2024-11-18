using System.ComponentModel.DataAnnotations;

namespace NovoProjetoCrianca.Enum
{
    public enum Periodo
    {
        [Display(Name = "Manha")]
        Manha = 0,

        [Display(Name = "Tarde")]
        Tarde = 1,

        [Display(Name = "Noite")]
        Noite = 2,
    }
}
