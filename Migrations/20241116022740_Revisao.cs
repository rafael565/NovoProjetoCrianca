using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovoProjetoCrianca.Migrations
{
    /// <inheritdoc />
    public partial class Revisao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Alunos",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 35);

            migrationBuilder.CreateTable(
                name: "ProfesTurmCurso",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    professor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    curso = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesTurmCurso", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfesTurmCurso");

            migrationBuilder.AlterColumn<long>(
                name: "cpf",
                table: "Alunos",
                type: "bigint",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);
        }
    }
}
