using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovoProjetoCrianca.Migrations
{
    /// <inheritdoc />
    public partial class Agrupamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "turmaID",
                table: "Professores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Professores_turmaID",
                table: "Professores",
                column: "turmaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Turmas_turmaID",
                table: "Professores",
                column: "turmaID",
                principalTable: "Turmas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Turmas_turmaID",
                table: "Professores");

            migrationBuilder.DropIndex(
                name: "IX_Professores_turmaID",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "turmaID",
                table: "Professores");
        }
    }
}
