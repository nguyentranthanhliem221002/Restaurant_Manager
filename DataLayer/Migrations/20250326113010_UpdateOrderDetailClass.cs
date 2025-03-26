using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderDetailClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$zVSA2hWimqhbcyAH9oXn6e0hF8jZ3HQED7Ry4p6uO5gMsIQN63xtG");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$G1JKmdvLmMy2KqC54FNp3uXANkeLQzNHxNVk39DgYJuIIugjC2qEy");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$spCsg9p.ZyKYHEmmqK0DuOUCPKwb0sXosLdp6DPxPQcrEPBXHej.a");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfJoining",
                value: new DateTime(2025, 3, 26, 11, 30, 10, 146, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfJoining",
                value: new DateTime(2025, 3, 26, 11, 30, 10, 146, DateTimeKind.Utc).AddTicks(3512));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Foods_FoodId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_FoodId",
                table: "OrderDetails");

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
        }
    }
}
