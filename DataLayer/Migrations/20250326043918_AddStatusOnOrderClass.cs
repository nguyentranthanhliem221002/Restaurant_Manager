using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusOnOrderClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Foods_FoodId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_FoodId",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FoodName",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$ABN0ErCUAVysPryX4l8hWONcNqkt64JpeAdcwTt4FDhqEO7lPtaNy");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$nBXdqh6Fpm3uXTL/z88xJ.NNKKvJT14pehhHoibXOaQJjrKG166L.");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$aI5bn9K.7V4ko1q13nblEOFBd3WrsP16Rkdkb73bGMon5KtyBjpRy");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfJoining",
                value: new DateTime(2025, 3, 26, 4, 39, 17, 544, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfJoining",
                value: new DateTime(2025, 3, 26, 4, 39, 17, 544, DateTimeKind.Utc).AddTicks(8905));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FoodName",
                table: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$q2hkf1gk9xRYX9xeapNRe.e0g/DXA4/qjK.LI9dLDFQqAUXkBeP.6");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$HPRWTVrcTgQ5J0iHPYpHKuWlvXafcAABjfuE27hGiyUYHFOnlPxXS");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$AMkONL4GkiIvYTPO5OSyJ.sDQt0edgXV0pKx3Eqv7TzQQP9ncpq5.");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfJoining",
                value: new DateTime(2025, 3, 26, 3, 56, 56, 916, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfJoining",
                value: new DateTime(2025, 3, 26, 3, 56, 56, 916, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_FoodId",
                table: "OrderDetails",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Foods_FoodId",
                table: "OrderDetails",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
