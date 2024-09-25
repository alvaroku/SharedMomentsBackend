using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class user_friends_status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "UserFriends");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "UserFriends",
                type: "int",
                nullable: false,
                defaultValue: 0);

           

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
             

            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserFriends");

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "UserFriends",
                type: "bit",
                nullable: false,
                defaultValue: false);

            
        }
    }
}
