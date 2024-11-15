using System.ComponentModel.DataAnnotations;

namespace NovoProjetoCrianca.Enum
{
    public enum Periodo
    {
        [Display(Name = "Manha")]
        Manha = 1,

        [Display(Name = "Tarde")]
        Tarde = 2,

        [Display(Name = "Noite")]
        Noite = 3
    }
}
