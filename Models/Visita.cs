﻿using NovoProjetoCrianca.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovoProjetoCrianca.Models
{
    [Table("Visitas")]
    public class Visita

    {

        [Display(Name = "ID: ")]
        public int id { get; set; }

        public AssistenteSocial assistenteSocial { get; set; }
        [Display(Name = "Assistente Social: ")]
        public int assistenteSocialID { get; set; }

        public DadoFamilia dadofamilia { get; set; }
        [Display(Name = "Dados da Familia: ")]
        public int dadofamiliaID { get; set; }

        [Display(Name = "Data do Atendimento : ")]
        public DateOnly DataAtendimento { get; set; }

        [Required(ErrorMessage = "Campo observação é obrigatório")]
        [Display(Name = "Observação: ")]
        public bool observacao { get; set; }
    }
}
