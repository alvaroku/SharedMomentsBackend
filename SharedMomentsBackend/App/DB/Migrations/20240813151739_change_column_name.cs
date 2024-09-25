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

            

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Moments",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Moments_UserId",
                table: "Moments",
                newName: "IX_Moments_OwnerId");

             
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

          

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Moments",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Moments_OwnerId",
                table: "Moments",
                newName: "IX_Moments_UserId");

             
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
