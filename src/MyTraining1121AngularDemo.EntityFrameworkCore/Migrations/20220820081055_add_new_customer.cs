using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTraining1121AngularDemo.Migrations
{
    public partial class add_new_customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PbCustomer",
                table: "PbCustomer");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PbCustomer");

            migrationBuilder.RenameTable(
                name: "PbCustomer",
                newName: "PbCustomers");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "PbCustomers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "PbCustomers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PbCustomers",
                table: "PbCustomers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CustomerUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRefId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerRefId = table.Column<int>(type: "int", nullable: false),
                    TotalBillingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerUsers_AbpUsers_UserRefId",
                        column: x => x.UserRefId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerUsers_PbCustomers_CustomerRefId",
                        column: x => x.CustomerRefId,
                        principalTable: "PbCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerUsers_CustomerRefId",
                table: "CustomerUsers",
                column: "CustomerRefId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerUsers_UserRefId",
                table: "CustomerUsers",
                column: "UserRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PbCustomers",
                table: "PbCustomers");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "PbCustomers");

            migrationBuilder.RenameTable(
                name: "PbCustomers",
                newName: "PbCustomer");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "PbCustomer",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PbCustomer",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PbCustomer",
                table: "PbCustomer",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CustomerUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerRefId = table.Column<int>(type: "int", nullable: false),
                    UserRefId = table.Column<long>(type: "bigint", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    TotalBillingAmmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerUser_AbpUsers_UserRefId",
                        column: x => x.UserRefId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerUser_PbCustomer_CustomerRefId",
                        column: x => x.CustomerRefId,
                        principalTable: "PbCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerUser_CustomerRefId",
                table: "CustomerUser",
                column: "CustomerRefId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerUser_UserRefId",
                table: "CustomerUser",
                column: "UserRefId");
        }
    }
}
