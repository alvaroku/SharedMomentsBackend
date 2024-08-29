using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.Migrations
{
    /// <inheritdoc />
    public partial class add_rel_moment_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "MomentUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MomentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MomentUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MomentUsers_Moments_MomentId",
                        column: x => x.MomentId,
                        principalTable: "Moments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MomentUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0cd538a8-7b59-4997-a0f7-1209a5419f29"), new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(564), true, "User", new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(564) },
                    { new Guid("2c7046ed-154d-4465-b5ba-a2bb1b9f7ec5"), new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(557), true, "Admin", new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(561) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("3b52e1b1-af54-4ba7-b570-a541e0190331"), new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(698), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("2c7046ed-154d-4465-b5ba-a2bb1b9f7ec5"), new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.CreateIndex(
                name: "IX_MomentUsers_MomentId",
                table: "MomentUsers",
                column: "MomentId");

            migrationBuilder.CreateIndex(
                name: "IX_MomentUsers_UserId",
                table: "MomentUsers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MomentUsers");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0cd538a8-7b59-4997-a0f7-1209a5419f29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b52e1b1-af54-4ba7-b570-a541e0190331"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2c7046ed-154d-4465-b5ba-a2bb1b9f7ec5"));

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
        }
    }
}
