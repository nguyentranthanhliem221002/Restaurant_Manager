using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddRolePermissionUserSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Thêm dữ liệu vào bảng Roles
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            // Thêm dữ liệu vào bảng Permissions
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ViewDashboard" },
                    { 2, "ManageUsers" }
                });

            // Thêm dữ liệu vào bảng Users
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName", "PasswordHash" },
                values: new object[,]
                {
                    { 1, "admin", "1" },
                    { 2, "staff", "123" }
                });

            // Thêm dữ liệu vào bảng RolePermissions
            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RoleId", "PermissionId" },
                values: new object[,]
                {
                    { 1, 1 }, // Admin có quyền ViewDashboard
                    { 1, 2 }, // Admin có quyền ManageUsers
                    { 2, 1 }  // User có quyền ViewDashboard
                });

            // Thêm dữ liệu vào bảng UserRoles
            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1 }, // Admin có role Admin
                    { 2, 2 }  // User1 có role User
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Xóa dữ liệu khi rollback migration
            migrationBuilder.DeleteData(table: "UserRoles", keyColumns: new[] { "UserId", "RoleId" }, keyValues: new object[] { 1, 1 });
            migrationBuilder.DeleteData(table: "UserRoles", keyColumns: new[] { "UserId", "RoleId" }, keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(table: "RolePermissions", keyColumns: new[] { "RoleId", "PermissionId" }, keyValues: new object[] { 1, 1 });
            migrationBuilder.DeleteData(table: "RolePermissions", keyColumns: new[] { "RoleId", "PermissionId" }, keyValues: new object[] { 1, 2 });
            migrationBuilder.DeleteData(table: "RolePermissions", keyColumns: new[] { "RoleId", "PermissionId" }, keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(table: "Users", keyColumn: "Id", keyValue: 1);
            migrationBuilder.DeleteData(table: "Users", keyColumn: "Id", keyValue: 2);

            migrationBuilder.DeleteData(table: "Permissions", keyColumn: "Id", keyValue: 1);
            migrationBuilder.DeleteData(table: "Permissions", keyColumn: "Id", keyValue: 2);

            migrationBuilder.DeleteData(table: "Roles", keyColumn: "Id", keyValue: 1);
            migrationBuilder.DeleteData(table: "Roles", keyColumn: "Id", keyValue: 2);
        }
    }
}
