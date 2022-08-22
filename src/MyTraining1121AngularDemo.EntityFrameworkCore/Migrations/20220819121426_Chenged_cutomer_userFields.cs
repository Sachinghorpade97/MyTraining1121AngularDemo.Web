using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTraining1121AngularDemo.Migrations
{
    public partial class Chenged_cutomer_userFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerUser_AbpUsers_UserRrfId",
                table: "CustomerUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerUser_PbCustomer_CustomerRrfId",
                table: "CustomerUser");

            migrationBuilder.RenameColumn(
                name: "UserRrfId",
                table: "CustomerUser",
                newName: "UserRefId");

            migrationBuilder.RenameColumn(
                name: "CustomerRrfId",
                table: "CustomerUser",
                newName: "CustomerRefId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerUser_UserRrfId",
                table: "CustomerUser",
                newName: "IX_CustomerUser_UserRefId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerUser_CustomerRrfId",
                table: "CustomerUser",
                newName: "IX_CustomerUser_CustomerRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerUser_AbpUsers_UserRefId",
                table: "CustomerUser",
                column: "UserRefId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerUser_PbCustomer_CustomerRefId",
                table: "CustomerUser",
                column: "CustomerRefId",
                principalTable: "PbCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerUser_AbpUsers_UserRefId",
                table: "CustomerUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerUser_PbCustomer_CustomerRefId",
                table: "CustomerUser");

            migrationBuilder.RenameColumn(
                name: "UserRefId",
                table: "CustomerUser",
                newName: "UserRrfId");

            migrationBuilder.RenameColumn(
                name: "CustomerRefId",
                table: "CustomerUser",
                newName: "CustomerRrfId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerUser_UserRefId",
                table: "CustomerUser",
                newName: "IX_CustomerUser_UserRrfId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerUser_CustomerRefId",
                table: "CustomerUser",
                newName: "IX_CustomerUser_CustomerRrfId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerUser_AbpUsers_UserRrfId",
                table: "CustomerUser",
                column: "UserRrfId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerUser_PbCustomer_CustomerRrfId",
                table: "CustomerUser",
                column: "CustomerRrfId",
                principalTable: "PbCustomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
