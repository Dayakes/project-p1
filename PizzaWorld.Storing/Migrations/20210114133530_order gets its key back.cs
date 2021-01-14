using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class ordergetsitskeyback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreEntityId = table.Column<long>(type: "bigint", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreEntityId",
                        column: x => x.StoreEntityId,
                        principalTable: "Stores",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 637462101299024663L, "Dominos" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 637462101299024702L, "Pizza Hut" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreEntityId",
                table: "Orders",
                column: "StoreEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
