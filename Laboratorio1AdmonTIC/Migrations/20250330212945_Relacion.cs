using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laboratorio1AdmonTIC.Migrations
{
    /// <inheritdoc />
    public partial class Relacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DepartamentoId",
                table: "Municipios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_DepartamentoId",
                table: "Municipios",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Municipios_Departamentos_DepartamentoId",
                table: "Municipios",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Municipios_Departamentos_DepartamentoId",
                table: "Municipios");

            migrationBuilder.DropIndex(
                name: "IX_Municipios_DepartamentoId",
                table: "Municipios");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Municipios");
        }
    }
}
