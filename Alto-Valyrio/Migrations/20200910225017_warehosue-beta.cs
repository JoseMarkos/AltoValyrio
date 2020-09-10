using Microsoft.EntityFrameworkCore.Migrations;

namespace Alto_Valyrio.Migrations
{
    public partial class warehosuebeta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WarehouseAddressState",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseAddressState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseState",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StateId = table.Column<int>(nullable: false),
                    AddressStateId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_WarehouseAddressState_AddressStateId",
                        column: x => x.AddressStateId,
                        principalTable: "WarehouseAddressState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Warehouses_WarehouseState_StateId",
                        column: x => x.StateId,
                        principalTable: "WarehouseState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_AddressStateId",
                table: "Warehouses",
                column: "AddressStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_StateId",
                table: "Warehouses",
                column: "StateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "WarehouseAddressState");

            migrationBuilder.DropTable(
                name: "WarehouseState");
        }
    }
}
