using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTraining1121AngularDemo.Migrations
{
    public partial class Implemented_IMustHaveTenant_For_Cust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "PbCustomer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CustomerUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRrfId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerRrfId = table.Column<int>(type: "int", nullable: false),
                    TotalBillingAmmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerUser_AbpUsers_UserRrfId",
                        column: x => x.UserRrfId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerUser_PbCustomer_CustomerRrfId",
                        column: x => x.CustomerRrfId,
                        principalTable: "PbCustomer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerUser_CustomerRrfId",
                table: "CustomerUser",
                column: "CustomerRrfId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerUser_UserRrfId",
                table: "CustomerUser",
                column: "UserRrfId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerUser");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "PbCustomer");
        }
    }
}
