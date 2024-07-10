using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ListaDeTarefas.Migrations
{
    /// <inheritdoc />
    public partial class InserindoDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Categorias_CategoriaID",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Statuses_StatusID",
                table: "Tarefas");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "Tarefas",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "CategoriaID",
                table: "Tarefas",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefas_StatusID",
                table: "Tarefas",
                newName: "IX_Tarefas_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefas_CategoriaID",
                table: "Tarefas",
                newName: "IX_Tarefas_CategoriaId");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "Statuses",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "CategoriaID",
                table: "Categorias",
                newName: "CategoriaId");

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "Id", "CategoriaId", "DataDeVencimento", "Descricao", "StatusId" },
                values: new object[,]
                {
                    { 1, "casa", new DateTime(2024, 7, 10, 15, 35, 45, 620, DateTimeKind.Local).AddTicks(8561), "Limpar a casa", "aberto" },
                    { 2, "casa", new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lavar o carro", "aberto" },
                    { 3, "faculdade", new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estudar c#", "completo" },
                    { 4, "faculdade", new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fazer tarefa", "aberto" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Categorias_CategoriaId",
                table: "Tarefas",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Statuses_StatusId",
                table: "Tarefas",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Categorias_CategoriaId",
                table: "Tarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Statuses_StatusId",
                table: "Tarefas");

            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Tarefas",
                newName: "StatusID");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Tarefas",
                newName: "CategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefas_StatusId",
                table: "Tarefas",
                newName: "IX_Tarefas_StatusID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefas_CategoriaId",
                table: "Tarefas",
                newName: "IX_Tarefas_CategoriaID");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Statuses",
                newName: "StatusID");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Categorias",
                newName: "CategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Categorias_CategoriaID",
                table: "Tarefas",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "CategoriaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Statuses_StatusID",
                table: "Tarefas",
                column: "StatusID",
                principalTable: "Statuses",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
