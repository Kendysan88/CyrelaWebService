using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VivazAPI.Migrations
{
    public partial class CreateActiveTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiveTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    WarrantyInYears = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ActiveTypes",
                columns: new[] { "Id", "Description", "WarrantyInYears" },
                values: new object[,]
                {
                    { new Guid("659fa627-61c1-4bc6-8be6-aea553bdc0f2"), "Instalação de equipamentos industrializados, como aquecedores, motobombas, filtros e interfones.", 1 },
                    { new Guid("7ffaa512-8988-4e61-9192-9f32ee500e4e"), "Borrachas, escovas, articulações, fechos e roldanas de esquadrias de alumínio ou PVC.", 2 },
                    { new Guid("8ac35cfa-7237-4d55-8aa5-5c4a6e5a7d29"), "Fundações, estruturas principais e periféricas, contenções e arrimos, envolvendo segurança e estabilidade.", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveTypes");
        }
    }
}
