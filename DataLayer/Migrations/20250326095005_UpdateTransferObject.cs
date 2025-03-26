using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTransferObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$PgHwG8rHFwsbfDt9xjCXTeSE6M/7CDC9FCGsVsYWI9HsdjpONPlT.");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$NpYmPXGltXAwwxCNKB1MUuUUQdldNg/1qfDkdWqqRyfdXR7yssfyK");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$RqGoXYkxl5Vh8dFoqc9aPODJcVP118.ZszkgPZiSSvLGt7ybsCefi");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfJoining",
                value: new DateTime(2025, 3, 26, 9, 50, 4, 749, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfJoining",
                value: new DateTime(2025, 3, 26, 9, 50, 4, 749, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

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
    }
}
