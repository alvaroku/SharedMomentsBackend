using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class change_properties_resource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.RenameColumn(
                name: "Format",
                table: "Resources",
                newName: "Extension");

            migrationBuilder.AlterColumn<decimal>(
                name: "Size",
                table: "Resources",
                type: "decimal(20,0)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.RenameColumn(
                name: "Extension",
                table: "Resources",
                newName: "Format");

            migrationBuilder.AlterColumn<long>(
                name: "Size",
                table: "Resources",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)");

           
        }
    }
}
