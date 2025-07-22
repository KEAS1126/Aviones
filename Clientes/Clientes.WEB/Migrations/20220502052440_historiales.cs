using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clientes.WEB.Migrations
{
    public partial class historiales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "historialCorporal",
                columns: table => new
                {
                    IdHistorialesCorporal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreación = table.Column<DateTime>(name: "FechaCreación'", type: "DateTime", nullable: false),
                    NombreDoctor = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    Tratamiento = table.Column<string>(type: "nvarchar(700)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historialCorporal", x => x.IdHistorialesCorporal);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentoIdentidad = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    NumeroTelefono = table.Column<string>(name: "NumeroTelefono'", type: "nvarchar(10)", nullable: false),
                    CorreoElectronico = table.Column<string>(name: "CorreoElectronico'", type: "nvarchar(90)", nullable: false),
                    DireccionHogar = table.Column<string>(name: "DireccionHogar'", type: "nvarchar(90)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(name: "FechaNacimiento'", type: "Date", nullable: false),
                    IdHistorialesCorporal = table.Column<int>(type: "int", nullable: false),
                    HistorialCorporalIdHistorialesCorporal = table.Column<int>(type: "int", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_historialCorporal_HistorialCorporalIdHistorialesCorporal",
                        column: x => x.HistorialCorporalIdHistorialesCorporal,
                        principalTable: "historialCorporal",
                        principalColumn: "IdHistorialesCorporal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_HistorialCorporalIdHistorialesCorporal",
                table: "Clientes",
                column: "HistorialCorporalIdHistorialesCorporal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "historialCorporal");
        }
    }
}
