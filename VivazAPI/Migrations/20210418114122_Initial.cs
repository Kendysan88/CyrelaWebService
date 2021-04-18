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
                    WarrantyInYears = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                    Uf = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                    Role = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ActivityTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "UpdatedAt", "WarrantyInYears" },
                values: new object[,]
                {
                    { new Guid("81fed1bb-8b00-418b-80e2-b64f6d82b937"), new DateTime(2021, 4, 18, 8, 41, 22, 42, DateTimeKind.Local).AddTicks(9417), "Instalação de equipamentos industrializados, como aquecedores, motobombas, filtros e interfones.", new DateTime(2021, 4, 18, 8, 41, 22, 42, DateTimeKind.Local).AddTicks(9422), 1 },
                    { new Guid("631f6a11-0ca9-4dba-827b-23b77c9b723d"), new DateTime(2021, 4, 18, 8, 41, 22, 43, DateTimeKind.Local).AddTicks(350), "Borrachas, escovas, articulações, fechos e roldanas de esquadrias de alumínio ou PVC.", new DateTime(2021, 4, 18, 8, 41, 22, 43, DateTimeKind.Local).AddTicks(354), 2 },
                    { new Guid("3114d9d9-9a97-4709-8495-b61fd85d35a5"), new DateTime(2021, 4, 18, 8, 41, 22, 43, DateTimeKind.Local).AddTicks(370), "Fundações, estruturas principais e periféricas, contenções e arrimos, envolvendo segurança e estabilidade.", new DateTime(2021, 4, 18, 8, 41, 22, 43, DateTimeKind.Local).AddTicks(371), 5 }
                });

            migrationBuilder.InsertData(
                table: "AddressStates",
                columns: new[] { "Id", "CreatedAt", "Name", "Uf", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("aaea3b4b-abb2-4de1-ac18-af635809d6ba"), new DateTime(2021, 4, 18, 8, 41, 22, 43, DateTimeKind.Local).AddTicks(1329), "São Paulo", "SP", new DateTime(2021, 4, 18, 8, 41, 22, 43, DateTimeKind.Local).AddTicks(1334) },
                    { new Guid("7ddba2e2-44dd-4ecf-bff7-26cfbef324d9"), new DateTime(2021, 4, 18, 8, 41, 22, 43, DateTimeKind.Local).AddTicks(2428), "Rio de Janeiro", "RJ", new DateTime(2021, 4, 18, 8, 41, 22, 43, DateTimeKind.Local).AddTicks(2433) },
                    { new Guid("fa3cec69-828e-4aec-bbe8-ba73108672c7"), new DateTime(2021, 4, 18, 8, 41, 22, 43, DateTimeKind.Local).AddTicks(2439), "Recife", "RE", new DateTime(2021, 4, 18, 8, 41, 22, 43, DateTimeKind.Local).AddTicks(2440) }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a7d8660e-cf45-43c2-8305-0b90e8cbf176"), new DateTime(2021, 4, 18, 8, 41, 22, 42, DateTimeKind.Local).AddTicks(7806), "Cyrela", new DateTime(2021, 4, 18, 8, 41, 22, 42, DateTimeKind.Local).AddTicks(7814) },
                    { new Guid("ed0c5448-236d-4c0c-ad34-7b001237fc91"), new DateTime(2021, 4, 18, 8, 41, 22, 42, DateTimeKind.Local).AddTicks(8351), "Living", new DateTime(2021, 4, 18, 8, 41, 22, 42, DateTimeKind.Local).AddTicks(8355) },
                    { new Guid("055e7a0e-2a08-4a79-8ddb-ee95eb200b29"), new DateTime(2021, 4, 18, 8, 41, 22, 42, DateTimeKind.Local).AddTicks(8362), "Vivaz", new DateTime(2021, 4, 18, 8, 41, 22, 42, DateTimeKind.Local).AddTicks(8363) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6de1a5ef-5a81-411c-9889-b233d2ae0540"), new DateTime(2021, 4, 18, 8, 41, 22, 40, DateTimeKind.Local).AddTicks(4750), "admin_user@mail.com", "admin123456", "admin", new DateTime(2021, 4, 18, 8, 41, 22, 41, DateTimeKind.Local).AddTicks(841) },
                    { new Guid("61e7f82f-1300-4906-aac5-c8348cde67a2"), new DateTime(2021, 4, 18, 8, 41, 22, 41, DateTimeKind.Local).AddTicks(3716), "employee_user@mail.com", "employee123456", "employee", new DateTime(2021, 4, 18, 8, 41, 22, 41, DateTimeKind.Local).AddTicks(3722) },
                    { new Guid("55151c81-dbbc-4df7-9864-085c5705b016"), new DateTime(2021, 4, 18, 8, 41, 22, 41, DateTimeKind.Local).AddTicks(3731), "customer_user@mail.com", "customer123456", "customer", new DateTime(2021, 4, 18, 8, 41, 22, 41, DateTimeKind.Local).AddTicks(3732) }
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
