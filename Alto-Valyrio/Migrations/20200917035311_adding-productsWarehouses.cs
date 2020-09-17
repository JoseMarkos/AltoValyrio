using Microsoft.EntityFrameworkCore.Migrations;

namespace Alto_Valyrio.Migrations
{
    public partial class addingproductsWarehouses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Warehouses_LocationId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_LocationId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductsWarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    WarehouseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsWarehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsWarehouses_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsWarehouses_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsWarehouses_ProductId",
                table: "ProductsWarehouses",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsWarehouses_WarehouseId",
                table: "ProductsWarehouses",
                column: "WarehouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsWarehouses");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_LocationId",
                table: "Products",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Warehouses_LocationId",
                table: "Products",
                column: "LocationId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
