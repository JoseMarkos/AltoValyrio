using Microsoft.EntityFrameworkCore.Migrations;

namespace Alto_Valyrio.Migrations
{
    public partial class fixusrrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_UserroleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserRolesId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserroleId",
                table: "Users",
                newName: "UserRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserroleId",
                table: "Users",
                newName: "IX_Users_UserRoleId");

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_UserRoleId",
                table: "Users",
                column: "UserRoleId",
                principalTable: "UserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_UserRoleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserRoleId",
                table: "Users",
                newName: "UserroleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserRoleId",
                table: "Users",
                newName: "IX_Users_UserroleId");

            migrationBuilder.AlterColumn<int>(
                name: "UserroleId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserRolesId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_UserroleId",
                table: "Users",
                column: "UserroleId",
                principalTable: "UserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
