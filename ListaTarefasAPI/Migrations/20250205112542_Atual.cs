using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListaTarefasAPI.Migrations
{
    /// <inheritdoc />
    public partial class Atual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tarefaId",
                table: "Tarefas",
                newName: "TarefaId");

            migrationBuilder.RenameColumn(
                name: "Concluída",
                table: "Tarefas",
                newName: "Concluida");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TarefaId",
                table: "Tarefas",
                newName: "tarefaId");

            migrationBuilder.RenameColumn(
                name: "Concluida",
                table: "Tarefas",
                newName: "Concluída");
        }
    }
}
