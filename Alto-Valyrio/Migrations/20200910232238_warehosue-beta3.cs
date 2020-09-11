using Microsoft.EntityFrameworkCore.Migrations;

namespace Alto_Valyrio.Migrations
{
    public partial class warehosuebeta3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_WarehouseState_StateId",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WarehouseState",
                table: "WarehouseState");

            migrationBuilder.RenameTable(
                name: "WarehouseState",
                newName: "WarehouseStates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarehouseStates",
                table: "WarehouseStates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_WarehouseStates_StateId",
                table: "Warehouses",
                column: "StateId",
                principalTable: "WarehouseStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_WarehouseStates_StateId",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WarehouseStates",
                table: "WarehouseStates");

            migrationBuilder.RenameTable(
                name: "WarehouseStates",
                newName: "WarehouseState");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarehouseState",
                table: "WarehouseState",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_WarehouseState_StateId",
                table: "Warehouses",
                column: "StateId",
                principalTable: "WarehouseState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
