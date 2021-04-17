using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VivazAPI.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActivityTypes",
                columns: new[] { "Id", "Description", "WarrantyInYears", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a4ab5bb6-5d90-419d-b31e-08efbfc55f18"), "Instalação de equipamentos industrializados, como aquecedores, motobombas, filtros e interfones.", 1, new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("36a4b94a-82d9-456e-a7cd-2c9692734597"), "Borrachas, escovas, articulações, fechos e roldanas de esquadrias de alumínio ou PVC.", 2, new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("77439344-dd79-4b07-b097-6f971676d8b4"), "Fundações, estruturas principais e periféricas, contenções e arrimos, envolvendo segurança e estabilidade.", 5, new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("2f0ea821-c651-42f8-96ca-98db082b0a16"), "Instalações elétricas (tomadas, interruptores, disjuntores etc.).", 1, new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("4189a92b-9989-4add-8100-8ecfed2f437b"), "Revestimentos das paredes e pisos em azulejo, cerâmica, pastilhas ou pedra natural, quando estiverem soltos.", 2, new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("bae80e91-55f0-4b96-a867-05243d540673"), "Integridade de portas e batentes dos sistemas de porta corta-fogo.", 5, new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("2b81a331-92dd-4067-9cf1-20b874271bdc"), "Instalações hidráulicas e de gás, louças, caixas de descarga, bancadas, metais, registros e tanques.", 1, new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("67662a59-1764-49ab-964a-55f08e0012c0"), "Piso cimentado, acabado em concreto ou contrapiso, quando houver fissuras.", 2, new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("1b97129d-6014-4bc7-bc59-03ae4e81f46b"), "Integridade das colunas de água quente e fria, esgoto e gás.", 5, new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) }
                });

            migrationBuilder.InsertData(
                table: "AddressStates",
                columns: new[] { "Id", "Name", "Uf", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d2e44dd4-b3ea-4375-a264-9381b91f76a5"), "São Paulo", "SP", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("8aac0e65-bb4b-45e0-acfe-7286a4035ee6"), "Rio de Janeiro", "RJ", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("ab6a718e-9a3b-4bc4-9e7e-5f47db6e1fa7"), "Sergipe", "SE", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("b03af26f-1a20-46f8-92da-8cd66efd999b"), "Amazonas", "AM", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("3ec1e4e1-e5fc-44c3-a625-b02b91514248"), "Rio Grande do Sul", "RS", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Title", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("bf7acf54-349f-45d2-b6b4-56e3b2a11dca"), "Cyrela", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("4e71cfe1-aabc-461c-86bf-94d6e60dec6c"), "Living", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("dce2c82c-99c3-41d5-82e2-80186b331106"), "Vivaz", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("e2a9baed-3e5a-41e4-8b2b-bea1655461e5"), "homelander@mail.com", "admin123456", "admin", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("b034d805-7c91-484c-9b18-8142019ffffd"), "billy_butcher@mail.com", "admin123456", "admin", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("824f7df3-6c8d-469d-b17c-ac11daf430e8"), "black_noir@mail.com", "employee123456", "employee", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("5aff9863-eee6-46e3-bf94-9d570e33dac8"), "queen_maeve@mail.com", "employee123456", "employee", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("03ebf02e-8633-4d3c-86f0-4de9bd80e712"), "a_train@mail.com", "employee123456", "employee", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("a7838f65-50d3-4dba-a892-70015f67779f"), "the_deep@mail.com", "employee123456", "employee", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("d975285b-c72e-47a0-9bff-711cd54a2136"), "translucent@mail.com", "employee123456", "employee", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("1ae02884-9896-400a-adfd-4ab1cedf9b84"), "starlight@mail.com", "customer123456", "customer", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("a5cf0e83-1e1b-468e-b581-9f56cde3511f"), "hughie_campbell@mail.com", "customer123456", "customer", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("c5a52e60-b0ff-460b-8c8e-77c40172edd6"), "mothers_milk@mail.com", "customer123456", "customer", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("5df04274-5176-44c8-8859-5b16dacc106a"), "frenchie@mail.com", "customer123456", "customer", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) },
                    { new Guid("d4a85fae-f6b1-4e0d-8670-9ff7de6f0971"), "kimiko@mail.com", "customer123456", "customer", new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 4, 17, 19, 17, 43, 955, DateTimeKind.Local).AddTicks(8272) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {}
    }
}
