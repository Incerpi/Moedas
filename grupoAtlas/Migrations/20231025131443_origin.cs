using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace grupoAtlas.Migrations
{
    /// <inheritdoc />
    public partial class origin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MOEDA",
                columns: table => new
                {
                    IdMoeda = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Valor = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    Variacao = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    PctVariacao = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    Data = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOEDA", x => x.IdMoeda);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MOEDA");
        }
    }
}
