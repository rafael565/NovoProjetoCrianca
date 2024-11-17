﻿using NovoProjetoCrianca.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovoProjetoCrianca.Models
{
    [Table("Atividades")]
    public class Atividade
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Nome: ")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Descrição é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Descrição: ")]
        public Descricao descricao { get; set; }

        [Display(Name = "Data Atividade: ")]
        public DateOnly DataAtividade { get; set; }

        [Required(ErrorMessage = "Campo Horario de duração é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Horario de duração da atividade: ")]
        public string duracaoAtividade { get; set; }
    }
}
