﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NovoProjetoCrianca.Migrations;
using NovoProjetoCrianca.Models;
using NovoProjetoCrianca.Models.Consultas;


namespace NovoProjetoCrianca.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AssistenteSocial> AssistentesSociais { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<Chamada> Chamadas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<DadoFamilia> DadosFamilias { get; set; }
        public DbSet<Encaminhamento> Encaminhamentos { get; set; }
        public DbSet<Entidade> Entidades { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<PerfilSocioEconomico> PerfisSociosEconomicos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }

        public DbSet<Materia> Materias  { get; set; }
        public DbSet<NovoProjetoCrianca.Models.Consultas.ProfesTurmCurso> ProfesTurmCurso { get; set; }

        




    }
}
