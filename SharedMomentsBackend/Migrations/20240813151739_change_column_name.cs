using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.Migrations
{
    /// <inheritdoc />
    public partial class change_column_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moments_Users_UserId",
                table: "Moments");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("78eaf133-a824-455b-b95c-9db3f18c13e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ab823f0-fbf9-4946-8073-8b487af51712"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8fc26b3c-cb55-4dc3-be6a-0abcafd96c3b"));

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Moments",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Moments_UserId",
                table: "Moments",
                newName: "IX_Moments_OwnerId");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("636b6318-de7f-45a8-be84-ccee51f42bbe"), new DateTime(2024, 8, 13, 15, 17, 38, 556, DateTimeKind.Utc).AddTicks(3738), true, "Admin", new DateTime(2024, 8, 13, 15, 17, 38, 556, DateTimeKind.Utc).AddTicks(3741) },
                    { new Guid("9c028acd-e75a-42c1-8cdf-ac5bb835fe23"), new DateTime(2024, 8, 13, 15, 17, 38, 556, DateTimeKind.Utc).AddTicks(3743), true, "User", new DateTime(2024, 8, 13, 15, 17, 38, 556, DateTimeKind.Utc).AddTicks(3743) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("3511dd83-bb2f-43c0-8c24-99ec2127ac21"), new DateTime(2024, 8, 13, 15, 17, 38, 556, DateTimeKind.Utc).AddTicks(3890), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("636b6318-de7f-45a8-be84-ccee51f42bbe"), new DateTime(2024, 8, 13, 15, 17, 38, 556, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.AddForeignKey(
                name: "FK_Moments_Users_OwnerId",
                table: "Moments",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moments_Users_OwnerId",
                table: "Moments");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9c028acd-e75a-42c1-8cdf-ac5bb835fe23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3511dd83-bb2f-43c0-8c24-99ec2127ac21"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("636b6318-de7f-45a8-be84-ccee51f42bbe"));

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Moments",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Moments_OwnerId",
                table: "Moments",
                newName: "IX_Moments_UserId");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("78eaf133-a824-455b-b95c-9db3f18c13e8"), new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3158), true, "User", new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3158) },
                    { new Guid("8fc26b3c-cb55-4dc3-be6a-0abcafd96c3b"), new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3152), true, "Admin", new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3155) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("6ab823f0-fbf9-4946-8073-8b487af51712"), new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3306), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("8fc26b3c-cb55-4dc3-be6a-0abcafd96c3b"), new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.AddForeignKey(
                name: "FK_Moments_Users_UserId",
                table: "Moments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
