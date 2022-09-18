using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyBurger.API.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Rating = table.Column<double>(type: "double", nullable: false),
                    ImgUrl = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgUrl", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { new Guid("109a39d8-7f02-4778-b19b-9e0089d225d7"), "Smash de 120g de carne angus, queijo gorgonzola, bacon, geleia de tomate e maionese da casa.", "https://static-images.ifood.com.br/image/upload/t_medium/pratos/a9399dc5-5f22-454a-8895-16c154511760/202111021436_0G0V_i.jpg", "Relíquia", 32.00m, 4.0 },
                    { new Guid("5172cb3a-ba03-42e3-aa03-b10410bb3d44"), "Hambúrguer artesanal, queijo, alface americana, tomate, maionese artesanal, bacon e pão de brioche.", "https://static-images.ifood.com.br/image/upload/t_medium/pratos/381719c4-1633-4690-a9bd-b2937d38b658/202102031326_Iejr_.jpeg", "Cheese bacon", 28.9m, 5.0 },
                    { new Guid("81459d7e-fba4-4a3f-b06c-64c5a0417400"), "2 Deliciosos hambúrgueres artesanais 150g, fatias de Cheddar, fatias de mussarela, bacon, maionese, alface americana, tomate, cebola roxa, molho jack no pão tradicional", "https://files.menudino.com/cardapios/33262/189.jpg", "Galaxy", 33.60m, 4.7000000000000002 },
                    { new Guid("8d51cad6-bca4-4f00-bea6-983c71e9dc66"), "Dois hambúrgueres 120 gr de angus, vinagrete de chimichurri, alface no pão brioche.", "https://static-images.ifood.com.br/image/upload/t_medium/pratos/a9399dc5-5f22-454a-8895-16c154511760/202004282006_lkS3_b.jpg", "Brutus", 36.00m, 4.5999999999999996 },
                    { new Guid("f08209a5-ddb7-4e1f-a629-a2ebd87b71da"), "Delicioso hambúrguer artesanal 140g, fatias de Cheddar, molho de cheddar da casa, bacon, alface americana, tomate, cebola roxa, maionese e molho especial no pão tradicional", "https://files.menudino.com/cardapios/33262/196.jpg", "Star", 20.90m, 4.2000000000000002 },
                    { new Guid("feb0dee2-9d82-452f-8707-be0782238953"), "Delicioso hambúrguer artesanal 180g, fatia de Cheddar, empanado de 2 queijos (catupiry e provolone) frito, cebola crispy, fatias de cheddar, bacon e maionese no pão tradicional ou pão de brioche", "https://files.menudino.com/cardapios/33262/188.jpg", "Provolone Crispy", 37.50m, 4.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Name",
                table: "Products",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
