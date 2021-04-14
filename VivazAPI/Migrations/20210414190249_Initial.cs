using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VivazAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    WarrantyInYears = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Uf = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ActivityTypes",
                columns: new[] { "Id", "Description", "WarrantyInYears" },
                values: new object[,]
                {
                    { new Guid("07d418e3-4bd0-4d1c-a185-18d3983bded0"), "Instalação de equipamentos industrializados, como aquecedores, motobombas, filtros e interfones.", 1 },
                    { new Guid("0a7fc9a1-a55e-4ab1-b0ac-834d56dc518a"), "Borrachas, escovas, articulações, fechos e roldanas de esquadrias de alumínio ou PVC.", 2 },
                    { new Guid("3afc886e-06e7-4e60-b063-0597bddb8fa3"), "Fundações, estruturas principais e periféricas, contenções e arrimos, envolvendo segurança e estabilidade.", 5 }
                });

            migrationBuilder.InsertData(
                table: "AddressStates",
                columns: new[] { "Id", "Name", "Uf" },
                values: new object[,]
                {
                    { new Guid("fedc4169-1386-4fdb-adaf-b7f9a027fa79"), "São Paulo", "SP" },
                    { new Guid("bd1b5d86-2df8-43b6-a566-61c91d1fe1a8"), "Rio de Janeiro", "RJ" },
                    { new Guid("00e4d596-468e-4c4d-81db-ee79d55c4a40"), "Recife", "RE" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("313c8631-8add-462f-a464-060f9d03fd03"), "Cyrela" },
                    { new Guid("ee629e24-cc13-4cc3-9601-3ca3561d6255"), "Living" },
                    { new Guid("642403e5-93c5-498b-9802-1ba37feebee7"), "Vivaz" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role" },
                values: new object[,]
                {
                    { new Guid("b4c2eed6-b60b-43b0-a643-03fbff474128"), "admin_user@mail.com", "admin123456", "admin" },
                    { new Guid("ff99ed43-ded8-4c7a-9370-32c5b295e28d"), "employee_user@mail.com", "employee123456", "employee" },
                    { new Guid("6552bba8-ee49-4d6c-b3fd-f089578f126f"), "customer_user@mail.com", "customer123456", "customer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityTypes");

            migrationBuilder.DropTable(
                name: "AddressStates");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
