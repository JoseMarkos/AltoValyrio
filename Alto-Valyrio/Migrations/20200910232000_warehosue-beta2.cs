using Microsoft.EntityFrameworkCore.Migrations;

namespace Alto_Valyrio.Migrations
{
    public partial class warehosuebeta2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_WarehouseAddressState_AddressStateId",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WarehouseAddressState",
                table: "WarehouseAddressState");

            migrationBuilder.RenameTable(
                name: "WarehouseAddressState",
                newName: "WarehouseAddressStates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarehouseAddressStates",
                table: "WarehouseAddressStates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_WarehouseAddressStates_AddressStateId",
                table: "Warehouses",
                column: "AddressStateId",
                principalTable: "WarehouseAddressStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_WarehouseAddressStates_AddressStateId",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WarehouseAddressStates",
                table: "WarehouseAddressStates");

            migrationBuilder.RenameTable(
                name: "WarehouseAddressStates",
                newName: "WarehouseAddressState");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarehouseAddressState",
                table: "WarehouseAddressState",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_WarehouseAddressState_AddressStateId",
                table: "Warehouses",
                column: "AddressStateId",
                principalTable: "WarehouseAddressState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
