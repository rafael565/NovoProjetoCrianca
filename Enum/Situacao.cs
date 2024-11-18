using System.ComponentModel.DataAnnotations;

namespace NovoProjetoCrianca.Enum
{
    public enum Situacao
    {
        [Display(Name = "Desabrigado")]
         Desabrigado = 0,

        [Display(Name = "Pobreza")]
        Pobreza = 1,

        [Display(Name = "Media Baixa")]
        MediaBaixa = 2,

    }
}