using Microsoft.EntityFrameworkCore.Migrations;

namespace Alto_Valyrio.Migrations
{
    public partial class wth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPurchases_Purchases_PurchaseId",
                table: "ProductPurchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Users_CustomerId",
                table: "Purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPurchases",
                table: "ProductPurchases");

            migrationBuilder.RenameTable(
                name: "Purchases",
                newName: "Purchase");

            migrationBuilder.RenameTable(
                name: "ProductPurchases",
                newName: "ProductPurchase");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_CustomerId",
                table: "Purchase",
                newName: "IX_Purchase_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPurchases_PurchaseId",
                table: "ProductPurchase",
                newName: "IX_ProductPurchase_PurchaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPurchase",
                table: "ProductPurchase",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPurchase_Purchase_PurchaseId",
                table: "ProductPurchase",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Users_CustomerId",
                table: "Purchase",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPurchase_Purchase_PurchaseId",
                table: "ProductPurchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Users_CustomerId",
                table: "Purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPurchase",
                table: "ProductPurchase");

            migrationBuilder.RenameTable(
                name: "Purchase",
                newName: "Purchases");

            migrationBuilder.RenameTable(
                name: "ProductPurchase",
                newName: "ProductPurchases");

            migrationBuilder.RenameIndex(
                name: "IX_Purchase_CustomerId",
                table: "Purchases",
                newName: "IX_Purchases_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPurchase_PurchaseId",
                table: "ProductPurchases",
                newName: "IX_ProductPurchases_PurchaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPurchases",
                table: "ProductPurchases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPurchases_Purchases_PurchaseId",
                table: "ProductPurchases",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Users_CustomerId",
                table: "Purchases",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
