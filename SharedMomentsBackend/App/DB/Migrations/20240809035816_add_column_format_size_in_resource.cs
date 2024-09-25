using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class add_column_format_size_in_resource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AddColumn<string>(
                name: "Format",
                table: "Resources",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "Size",
                table: "Resources",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropColumn(
                name: "Format",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Resources");

            
        }
    }
}
