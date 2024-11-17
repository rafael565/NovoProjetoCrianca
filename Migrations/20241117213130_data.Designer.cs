﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NovoProjetoCrianca.Models;

#nullable disable

namespace NovoProjetoCrianca.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20241117213130_data")]
    partial class data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NovoProjetoCrianca.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("DatadeNascimento")
                        .HasColumnType("date");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("dadofamiliaID")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("escolaridade")
                        .HasColumnType("int");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.HasIndex("dadofamiliaID");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.AssistenteSocial", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.ToTable("AssistentesSociais");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Atendimento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("DataAtendimento")
                        .HasColumnType("date");

                    b.Property<int>("assistenteSocialID")
                        .HasColumnType("int");

                    b.Property<int>("dadofamiliaID")
                        .HasColumnType("int");

                    b.Property<int>("observacao")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("assistenteSocialID");

                    b.HasIndex("dadofamiliaID");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Atividade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("DataAtividade")
                        .HasColumnType("date");

                    b.Property<int>("descricao")
                        .HasMaxLength(35)
                        .HasColumnType("int");

                    b.Property<string>("duracaoAtividade")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.ToTable("Atividades");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Chamada", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("DatadeChamada")
                        .HasColumnType("date");

                    b.Property<int>("Presenca")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int>("matriculaID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("matriculaID");

                    b.ToTable("Chamadas");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Consultas.ProfesTurmCurso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("curso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("professor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("turma")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ProfesTurmCurso");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Curso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("CargaHoraria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("descricao")
                        .HasMaxLength(35)
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("periodo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.DadoFamilia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DatadeNascimentoMae")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatadeNascimentoPai")
                        .HasColumnType("datetime2");

                    b.Property<int>("HistoricoFamiliar")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("cidade")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nomeMae")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("nomePai")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("telefoneMae")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("telefonePai")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.ToTable("DadosFamilias");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Encaminhamento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("DatadeEncaminhamento")
                        .HasColumnType("date");

                    b.Property<int>("alunoID")
                        .HasColumnType("int");

                    b.Property<int>("assistentesocialID")
                        .HasColumnType("int");

                    b.Property<int>("entidadeID")
                        .HasColumnType("int");

                    b.Property<int>("motivo")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("alunoID");

                    b.HasIndex("assistentesocialID");

                    b.HasIndex("entidadeID");

                    b.ToTable("Encaminhamentos");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Entidade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("DatadeInicio")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DatadoFim")
                        .HasColumnType("date");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nomeEntidade")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("statusContrato")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Entidades");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Materia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("CursoID")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.HasIndex("CursoID");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Matricula", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("DataMatricula")
                        .HasColumnType("date");

                    b.Property<int>("alunoID")
                        .HasColumnType("int");

                    b.Property<int>("statusMatricula")
                        .HasColumnType("int");

                    b.Property<int>("turmaID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("alunoID");

                    b.HasIndex("turmaID");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.PerfilSocioEconomico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("dadofamiliaID")
                        .HasColumnType("int");

                    b.Property<string>("profissaoMae")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("profissaoPai")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<float>("rendafamilia")
                        .HasColumnType("real");

                    b.Property<int>("situacaofamilia")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("dadofamiliaID");

                    b.ToTable("PerfisSociosEconomicos");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("especializacao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("turmaID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("turmaID");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Turma", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("cursoID")
                        .HasColumnType("int");

                    b.Property<int>("maximoAluno")
                        .HasColumnType("int");

                    b.Property<int>("minimoAluno")
                        .HasColumnType("int");

                    b.Property<string>("nomeTurma")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("serie")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("cursoID");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Visita", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("DataAtendimento")
                        .HasColumnType("date");

                    b.Property<int>("assistenteSocialID")
                        .HasColumnType("int");

                    b.Property<int>("dadofamiliaID")
                        .HasColumnType("int");

                    b.Property<int>("observacao")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("assistenteSocialID");

                    b.HasIndex("dadofamiliaID");

                    b.ToTable("Visitas");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Aluno", b =>
                {
                    b.HasOne("NovoProjetoCrianca.Models.DadoFamilia", "dadofamilia")
                        .WithMany()
                        .HasForeignKey("dadofamiliaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dadofamilia");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Atendimento", b =>
                {
                    b.HasOne("NovoProjetoCrianca.Models.AssistenteSocial", "assistenteSocial")
                        .WithMany()
                        .HasForeignKey("assistenteSocialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoProjetoCrianca.Models.DadoFamilia", "dadofamilia")
                        .WithMany()
                        .HasForeignKey("dadofamiliaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("assistenteSocial");

                    b.Navigation("dadofamilia");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Chamada", b =>
                {
                    b.HasOne("NovoProjetoCrianca.Models.Matricula", "matricula")
                        .WithMany()
                        .HasForeignKey("matriculaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("matricula");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Encaminhamento", b =>
                {
                    b.HasOne("NovoProjetoCrianca.Models.Aluno", "aluno")
                        .WithMany()
                        .HasForeignKey("alunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoProjetoCrianca.Models.AssistenteSocial", "assistentesocial")
                        .WithMany()
                        .HasForeignKey("assistentesocialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoProjetoCrianca.Models.Entidade", "entidade")
                        .WithMany()
                        .HasForeignKey("entidadeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("assistentesocial");

                    b.Navigation("entidade");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Materia", b =>
                {
                    b.HasOne("NovoProjetoCrianca.Models.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Matricula", b =>
                {
                    b.HasOne("NovoProjetoCrianca.Models.Aluno", "aluno")
                        .WithMany()
                        .HasForeignKey("alunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoProjetoCrianca.Models.Turma", "turma")
                        .WithMany()
                        .HasForeignKey("turmaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("turma");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.PerfilSocioEconomico", b =>
                {
                    b.HasOne("NovoProjetoCrianca.Models.DadoFamilia", "dadofamilia")
                        .WithMany()
                        .HasForeignKey("dadofamiliaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dadofamilia");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Professor", b =>
                {
                    b.HasOne("NovoProjetoCrianca.Models.Turma", "turma")
                        .WithMany()
                        .HasForeignKey("turmaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("turma");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Turma", b =>
                {
                    b.HasOne("NovoProjetoCrianca.Models.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("cursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });

            modelBuilder.Entity("NovoProjetoCrianca.Models.Visita", b =>
                {
                    b.HasOne("NovoProjetoCrianca.Models.AssistenteSocial", "assistenteSocial")
                        .WithMany()
                        .HasForeignKey("assistenteSocialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoProjetoCrianca.Models.DadoFamilia", "dadofamilia")
                        .WithMany()
                        .HasForeignKey("dadofamiliaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("assistenteSocial");

                    b.Navigation("dadofamilia");
                });
#pragma warning restore 612, 618
        }
    }
}
