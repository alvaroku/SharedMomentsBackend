using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class make_optional_album_moment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moments_Albums_AlbumId",
                table: "Moments");

            

             

            migrationBuilder.AlterColumn<Guid>(
                name: "AlbumId",
                table: "Moments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

             

            
            migrationBuilder.AddForeignKey(
                name: "FK_Moments_Albums_AlbumId",
                table: "Moments",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moments_Albums_AlbumId",
                table: "Moments");

            
            migrationBuilder.AlterColumn<Guid>(
                name: "AlbumId",
                table: "Moments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            
            migrationBuilder.AddForeignKey(
                name: "FK_Moments_Albums_AlbumId",
                table: "Moments",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
