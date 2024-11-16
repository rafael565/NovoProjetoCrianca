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
    [Migration("20241115215721_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("DatadeNascimento")
                        .HasColumnType("date");

                    b.Property<long>("cpf")
                        .HasMaxLength(35)
                        .HasColumnType("bigint");

                    b.Property<int>("dadofamiliaID")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("escolaridade")
                        .HasMaxLength(35)
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

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.AssistenteSocial", b =>
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

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Atendimento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("assistenteSocialID")
                        .HasColumnType("int");

                    b.Property<int>("dadofamiliaID")
                        .HasColumnType("int");

                    b.Property<string>("observacao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.HasIndex("assistenteSocialID");

                    b.HasIndex("dadofamiliaID");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Atividade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DataAtividade")
                        .HasColumnType("datetime2");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

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

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Chamada", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DatadeChamada")
                        .HasColumnType("datetime2");

                    b.Property<string>("Presenca")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("matriculaID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("matriculaID");

                    b.ToTable("Chamadas");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Curso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("CargaHoraria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("periodo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.DadoFamilia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DatadeNascimentoMae")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatadeNascimentoPai")
                        .HasColumnType("datetime2");

                    b.Property<string>("HistoricoFamiliar")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Encaminhamento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DatadeEncaminhamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("alunoID")
                        .HasColumnType("int");

                    b.Property<int>("assistentesocialID")
                        .HasColumnType("int");

                    b.Property<int>("entidadeID")
                        .HasColumnType("int");

                    b.Property<string>("motivo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.HasIndex("alunoID");

                    b.HasIndex("assistentesocialID");

                    b.HasIndex("entidadeID");

                    b.ToTable("Encaminhamentos");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Entidade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DatadeInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatadoFim")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Materia", b =>
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

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Matricula", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.PerfilSocioEconomico", b =>
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

                    b.Property<string>("situacaofamilia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.HasIndex("dadofamiliaID");

                    b.ToTable("PerfisSociosEconomicos");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Professor", b =>
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

                    b.HasKey("id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Turma", b =>
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

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Visita", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("assistenteSocialID")
                        .HasColumnType("int");

                    b.Property<int>("dadofamiliaID")
                        .HasColumnType("int");

                    b.Property<string>("observacao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.HasIndex("assistenteSocialID");

                    b.HasIndex("dadofamiliaID");

                    b.ToTable("Visitas");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Aluno", b =>
                {
                    b.HasOne("ProjetoFundacaoCrianca.Models.DadoFamilia", "dadofamilia")
                        .WithMany()
                        .HasForeignKey("dadofamiliaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dadofamilia");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Atendimento", b =>
                {
                    b.HasOne("ProjetoFundacaoCrianca.Models.AssistenteSocial", "assistenteSocial")
                        .WithMany()
                        .HasForeignKey("assistenteSocialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoFundacaoCrianca.Models.DadoFamilia", "dadofamilia")
                        .WithMany()
                        .HasForeignKey("dadofamiliaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("assistenteSocial");

                    b.Navigation("dadofamilia");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Chamada", b =>
                {
                    b.HasOne("ProjetoFundacaoCrianca.Models.Matricula", "matricula")
                        .WithMany()
                        .HasForeignKey("matriculaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("matricula");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Encaminhamento", b =>
                {
                    b.HasOne("ProjetoFundacaoCrianca.Models.Aluno", "aluno")
                        .WithMany()
                        .HasForeignKey("alunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoFundacaoCrianca.Models.AssistenteSocial", "assistentesocial")
                        .WithMany()
                        .HasForeignKey("assistentesocialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoFundacaoCrianca.Models.Entidade", "entidade")
                        .WithMany()
                        .HasForeignKey("entidadeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("assistentesocial");

                    b.Navigation("entidade");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Materia", b =>
                {
                    b.HasOne("ProjetoFundacaoCrianca.Models.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Matricula", b =>
                {
                    b.HasOne("ProjetoFundacaoCrianca.Models.Aluno", "aluno")
                        .WithMany()
                        .HasForeignKey("alunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoFundacaoCrianca.Models.Turma", "turma")
                        .WithMany()
                        .HasForeignKey("turmaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("turma");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.PerfilSocioEconomico", b =>
                {
                    b.HasOne("ProjetoFundacaoCrianca.Models.DadoFamilia", "dadofamilia")
                        .WithMany()
                        .HasForeignKey("dadofamiliaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dadofamilia");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Turma", b =>
                {
                    b.HasOne("ProjetoFundacaoCrianca.Models.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("cursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });

            modelBuilder.Entity("ProjetoFundacaoCrianca.Models.Visita", b =>
                {
                    b.HasOne("ProjetoFundacaoCrianca.Models.AssistenteSocial", "assistenteSocial")
                        .WithMany()
                        .HasForeignKey("assistenteSocialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoFundacaoCrianca.Models.DadoFamilia", "dadofamilia")
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
