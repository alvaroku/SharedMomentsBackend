using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class user_friends_accepted_flag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFriends_Users_UserId",
                table: "UserFriends");

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("0b401705-e2b3-4a72-830e-59ecf259526f"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("2a2e06b0-b385-4a2b-8fdd-ad7756bf24cb"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("2fb21b03-7761-47f9-80e3-d641df2f4ea6"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("318e7835-c21e-4684-ae0a-d67bd39aa230"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("3ca22413-da76-4187-bbe5-fbe6137976c0"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("4e6c2177-9647-471c-a846-4a46efc9baa9"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("5361ccc1-0f5b-49d8-b669-4494a6f386f8"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("5945165b-e33e-448c-9e66-721bd6138292"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("5e8bfb31-93da-4cde-b83b-98d278b7dbe8"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("635438fe-3efd-47b6-9004-099a63967a57"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("6532c612-0e5b-4899-b451-1b500e84f3e6"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("673e9357-216d-4745-abaa-0bdaa91217bb"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("6e6aa89a-29ba-4317-b7f2-f35c0e0b7f37"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("76792f32-abb3-4b49-933c-c5215d6ba3ab"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("7b3c1903-d913-46ef-b9c6-1f924f8737f2"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("82bdddab-b435-4fe0-ae00-aa3627da4938"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("89011f81-ae29-4b41-935a-740aada8c462"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("9163a812-bdce-44ee-b060-13c312f0dcdf"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("93cd3087-c067-4f5d-b93f-f1458ffc5daa"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("9a7f0430-9619-4fc6-9bf8-8aefff263ab9"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("9fd31ca5-1da6-4e40-a187-0a4731d68adf"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("a599c835-4123-4829-80a2-223047b0140b"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("a8d957ef-1174-43e6-a9d5-cc2cb2934863"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("aaf57ad6-8d05-4f91-a070-b778fd564ead"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("b09c4fab-3c0d-4c9c-a4d9-7d5e396e1568"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("b3633229-0cd8-491d-bb79-d541bdd8bad5"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf65078e-049f-4588-b122-9877732f69f7"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("d4b5c0d5-018d-4b54-b2d7-cf2236ce4bd2"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("f604c3e1-9669-4c47-a163-293afa4ef158"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("fda68cc4-b547-465e-969e-94311c5d6450"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77be2037-896b-4f67-bccc-07ca18ce9041"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0d1de5a5-faab-4a87-90cb-d81dc0ec6c44"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1d76cee5-8ba5-46dd-a178-05363eaffb3e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1f88e8b5-108d-484e-8c3c-83e222df36f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("22850a87-11ff-4bbf-8831-306d87a4871a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("33d425c9-4267-4e52-88f5-92e9ffb5d886"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3675810b-e9be-4412-a58b-c730e9a6d53f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("36b2266e-a6c8-4962-922b-8b2be9720c5a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("39ba2a09-f6b8-4d29-8145-0e6d15164361"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("455cc9fb-f187-4c2f-af5f-5af5ebcc224d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("482adfba-e417-4c4a-ac85-db066c1aa816"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("62917908-4544-4dbd-8ebd-6345bbf2b189"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("78e42460-6722-4b4c-91a7-6a0ad1ef36a1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7fa5b6f1-09bc-465a-9f43-260603a49cf6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("81e0da8a-bde9-46e0-9b97-21cf8f40eb3e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9a67c10b-3e32-4758-9a95-903d31a9da1d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a889ebbb-13f7-47e6-b0ca-ff9ec8a8013a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b13c8f82-cfd0-408c-b5e1-08f13b354a32"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b4b0a7e4-a034-4598-9d5e-ee1e60282401"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dc2bfc38-b0f5-423b-8a4c-927e1725b2df"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("edb88a9c-dc89-4531-ae28-238ca0710bc7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("da7c8204-8ed0-462b-b287-833053b1514e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("2b6607cb-3e80-4ad5-a7f3-42fa017e01e2"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("2c4911d5-7a3e-414c-9ceb-54d1e749aec2"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("3ff900ef-989b-4c45-bd14-ba9efd65383a"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("4b92de4f-06f6-4c1d-8f28-675c9043c354"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("5b548629-b89c-49e9-9f12-6b198f16abec"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("622fc1a5-d3b8-4426-ba7e-3eef9c55c47b"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("67288ef1-7952-4b02-96f8-c28e16791a3d"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("684f266d-c0af-4731-a687-363cf43b44ab"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("6fbfb466-6ff6-4043-9924-85c5bbce0f67"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("749b775c-abeb-49fa-99f9-819b4e554c7c"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("87136741-dab2-4e30-8818-347233405675"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("8751bde9-7d8b-4fbe-8f23-a2293a542f02"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("8919540f-26b8-412d-80ad-48758df9cffd"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("8ffaa508-1f1a-4116-8ef4-1f7185e0ca78"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("9ba36d36-095c-4389-84aa-a2efe122460e"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("aa189dbf-21ae-472b-a9e6-aedabacb7a7b"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("dba59d2c-5617-4a5c-a702-7216583ba46d"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("e443d2e8-8334-40a9-8395-3156d66cd249"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("e73e29a2-14e0-4b9d-98c5-e3838156d66d"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("ffb29d1d-7ea2-41d9-8d32-099b23f84052"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("32226422-fd4b-435d-8622-f5966fadf7d3"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("438df840-9c8a-4e8d-9df5-5e1a01f25470"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("6cc41e61-a0b4-4d88-b963-ecbe5aff1ddb"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("ae666752-8ae3-422e-8e8f-70904beb8d15"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("ff2e2bae-b84e-40d0-8723-0a1c8c4358ff"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("8a5ef4e6-c8bb-4422-8aae-2d80c860d149"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("a5ddeab6-add2-4f76-b8e4-47122a68f989"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("cd9bcd28-6ef4-4601-a259-cba810a90406"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("e917669a-0930-4e29-b1d8-e70e4b479f74"));

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "UserFriends",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02c702d2-3c57-4325-9dcb-b5b7ec44ad65"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3990), true, "ChangeStatus", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3991) },
                    { new Guid("67257b12-7828-4629-8ee3-f2757469c450"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3986), true, "Delete", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3986) },
                    { new Guid("72928ddb-a5fa-4eaa-aecf-093e29da5465"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3985), true, "Update", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3985) },
                    { new Guid("9dbd3419-2a6e-4e3d-aa35-1767af7004e9"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3982), true, "Create", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3982) },
                    { new Guid("c58b3e39-8a67-4ecc-b74c-235eb77914bd"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3983), true, "Read", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3984) }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("533c8997-41d4-48a6-8689-1e83faff1754"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3956), true, "Albums", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3956) },
                    { new Guid("745936be-c608-42d4-8950-9986d587a965"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3954), true, "Moments", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3955) },
                    { new Guid("9d2a6b03-3f98-42d5-b980-6fc93340f9d1"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3951), true, "Users", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3951) },
                    { new Guid("b5b12ef3-3877-4960-9802-1bdea1558d63"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3957), true, "Resources", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3958) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3040), true, "User", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3040) },
                    { new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3035), true, "Admin", new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3037) }
                });

            migrationBuilder.InsertData(
                table: "ModuleActions",
                columns: new[] { "Id", "ActionId", "CreatedAt", "IsActive", "ModuleId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("026e07e3-2597-49d7-9525-e57fee403120"), new Guid("72928ddb-a5fa-4eaa-aecf-093e29da5465"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4089), true, new Guid("533c8997-41d4-48a6-8689-1e83faff1754"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4089) },
                    { new Guid("0a014fab-cb43-4f36-ad3f-3c7efb0b57ac"), new Guid("67257b12-7828-4629-8ee3-f2757469c450"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4089), true, new Guid("533c8997-41d4-48a6-8689-1e83faff1754"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4090) },
                    { new Guid("0a1c7340-c811-4279-a010-caaacdf88a34"), new Guid("9dbd3419-2a6e-4e3d-aa35-1767af7004e9"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4093), true, new Guid("b5b12ef3-3877-4960-9802-1bdea1558d63"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4093) },
                    { new Guid("0b38533e-bd77-4dbb-ac3c-fb60e9c96737"), new Guid("72928ddb-a5fa-4eaa-aecf-093e29da5465"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4020), true, new Guid("9d2a6b03-3f98-42d5-b980-6fc93340f9d1"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4020) },
                    { new Guid("18b3f1b9-49a5-4f2d-9b97-61d0af6ae28b"), new Guid("72928ddb-a5fa-4eaa-aecf-093e29da5465"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4028), true, new Guid("745936be-c608-42d4-8950-9986d587a965"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4028) },
                    { new Guid("1d33b040-3353-4eeb-9ce1-c0e8bd8f49da"), new Guid("9dbd3419-2a6e-4e3d-aa35-1767af7004e9"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4086), true, new Guid("533c8997-41d4-48a6-8689-1e83faff1754"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4086) },
                    { new Guid("2e7a1420-0397-4c15-88bc-3c0ffb034251"), new Guid("c58b3e39-8a67-4ecc-b74c-235eb77914bd"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4087), true, new Guid("533c8997-41d4-48a6-8689-1e83faff1754"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4088) },
                    { new Guid("465be5e6-59a7-4c0f-bcfa-5786573112b0"), new Guid("9dbd3419-2a6e-4e3d-aa35-1767af7004e9"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4024), true, new Guid("745936be-c608-42d4-8950-9986d587a965"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4024) },
                    { new Guid("492b84a9-1a1d-49db-994c-c1d6823a9239"), new Guid("c58b3e39-8a67-4ecc-b74c-235eb77914bd"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4018), true, new Guid("9d2a6b03-3f98-42d5-b980-6fc93340f9d1"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4019) },
                    { new Guid("5343eaf8-28ec-437a-91f1-4f64a8054a4d"), new Guid("02c702d2-3c57-4325-9dcb-b5b7ec44ad65"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4097), true, new Guid("b5b12ef3-3877-4960-9802-1bdea1558d63"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4098) },
                    { new Guid("5ff14bb6-10b6-41fe-9f70-2333d115bdd8"), new Guid("02c702d2-3c57-4325-9dcb-b5b7ec44ad65"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4022), true, new Guid("9d2a6b03-3f98-42d5-b980-6fc93340f9d1"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4022) },
                    { new Guid("60588be8-b18e-4d43-8f8a-f59fee0d5c9a"), new Guid("67257b12-7828-4629-8ee3-f2757469c450"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4021), true, new Guid("9d2a6b03-3f98-42d5-b980-6fc93340f9d1"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4021) },
                    { new Guid("803e67df-264a-4339-8188-655a396a637e"), new Guid("02c702d2-3c57-4325-9dcb-b5b7ec44ad65"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4084), true, new Guid("745936be-c608-42d4-8950-9986d587a965"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4085) },
                    { new Guid("9516146b-3072-4a13-934e-d7dc26b6f04e"), new Guid("67257b12-7828-4629-8ee3-f2757469c450"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4097), true, new Guid("b5b12ef3-3877-4960-9802-1bdea1558d63"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4097) },
                    { new Guid("9707e1cd-0f54-4fc6-b1a3-19c48f8ea764"), new Guid("c58b3e39-8a67-4ecc-b74c-235eb77914bd"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4027), true, new Guid("745936be-c608-42d4-8950-9986d587a965"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4027) },
                    { new Guid("a873a5d9-2cca-4811-a885-c5c52f32930c"), new Guid("67257b12-7828-4629-8ee3-f2757469c450"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4029), true, new Guid("745936be-c608-42d4-8950-9986d587a965"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4029) },
                    { new Guid("bf2a2137-f276-4895-b265-35e102fc4843"), new Guid("9dbd3419-2a6e-4e3d-aa35-1767af7004e9"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4013), true, new Guid("9d2a6b03-3f98-42d5-b980-6fc93340f9d1"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4014) },
                    { new Guid("d3299a5e-aeae-44e5-96d1-1c7b15e92ede"), new Guid("c58b3e39-8a67-4ecc-b74c-235eb77914bd"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4094), true, new Guid("b5b12ef3-3877-4960-9802-1bdea1558d63"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4094) },
                    { new Guid("e5459fbc-71cf-44d2-88b0-1e9e3866662f"), new Guid("72928ddb-a5fa-4eaa-aecf-093e29da5465"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4096), true, new Guid("b5b12ef3-3877-4960-9802-1bdea1558d63"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4096) },
                    { new Guid("f3d31352-0e5e-47be-ac61-575a8b67eed2"), new Guid("02c702d2-3c57-4325-9dcb-b5b7ec44ad65"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4092), true, new Guid("533c8997-41d4-48a6-8689-1e83faff1754"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4092) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("6a12c44d-f920-4336-8345-0b5c8a64c741"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3158), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "ModuleActionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01918278-8f94-4363-960f-1bba50581b88"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4161), true, new Guid("465be5e6-59a7-4c0f-bcfa-5786573112b0"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4161) },
                    { new Guid("0c514eb6-6455-4717-8991-6c8408ba865c"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4156), true, new Guid("0b38533e-bd77-4dbb-ac3c-fb60e9c96737"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4156) },
                    { new Guid("0e08ea03-69e9-45d7-9036-dc5c3b4343a2"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4169), true, new Guid("2e7a1420-0397-4c15-88bc-3c0ffb034251"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4169) },
                    { new Guid("36106883-d3b0-4d17-a232-160a0cefb5e0"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4166), true, new Guid("1d33b040-3353-4eeb-9ce1-c0e8bd8f49da"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4166) },
                    { new Guid("4a2d708f-0249-4648-81ea-1dc6cb02e9b7"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4170), true, new Guid("026e07e3-2597-49d7-9525-e57fee403120"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4170) },
                    { new Guid("4fc2158f-9010-440e-8930-d3cf63c99849"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4171), true, new Guid("0a014fab-cb43-4f36-ad3f-3c7efb0b57ac"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4171) },
                    { new Guid("50a33715-2873-4c3c-b3f6-1f016d152caa"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4159), true, new Guid("60588be8-b18e-4d43-8f8a-f59fee0d5c9a"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4159) },
                    { new Guid("5153a691-f6ad-42f9-b025-d3175afb3bdb"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4174), true, new Guid("d3299a5e-aeae-44e5-96d1-1c7b15e92ede"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4174) },
                    { new Guid("592729f1-6cfd-4df0-b14e-5fe6fe7628f7"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4163), true, new Guid("18b3f1b9-49a5-4f2d-9b97-61d0af6ae28b"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4163) },
                    { new Guid("665a0ac7-7cc1-4cf6-95d6-1f68b9f28b9b"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4175), true, new Guid("9516146b-3072-4a13-934e-d7dc26b6f04e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4176) },
                    { new Guid("70f2226c-9874-48b4-a5f9-3d6a9b95fbc6"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4164), true, new Guid("a873a5d9-2cca-4811-a885-c5c52f32930c"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4164) },
                    { new Guid("7c67bad4-de81-4606-92ec-14fb46bf2162"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4174), true, new Guid("e5459fbc-71cf-44d2-88b0-1e9e3866662f"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4175) },
                    { new Guid("a0554695-4366-4f69-a37a-3db53cfcf15f"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4160), true, new Guid("5ff14bb6-10b6-41fe-9f70-2333d115bdd8"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4160) },
                    { new Guid("a967a98f-1d17-4a6d-b6c6-fdee5a482972"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4173), true, new Guid("0a1c7340-c811-4279-a010-caaacdf88a34"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4173) },
                    { new Guid("aa34f7af-9772-4a06-9fa7-dd475175d6b1"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4178), true, new Guid("5343eaf8-28ec-437a-91f1-4f64a8054a4d"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4178) },
                    { new Guid("ac72909c-bb74-4c59-90bd-0e8ed7709f17"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4172), true, new Guid("f3d31352-0e5e-47be-ac61-575a8b67eed2"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4172) },
                    { new Guid("b7321a31-7f5a-4ef1-b5c5-932bde94dfc1"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4155), true, new Guid("492b84a9-1a1d-49db-994c-c1d6823a9239"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4155) },
                    { new Guid("cd52dfa1-bc13-47a0-ac61-25e6d8da60c9"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4165), true, new Guid("803e67df-264a-4339-8188-655a396a637e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4165) },
                    { new Guid("d60fbdf7-7eef-4dbe-b501-1f9e1a9c3804"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4162), true, new Guid("9707e1cd-0f54-4fc6-b1a3-19c48f8ea764"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4162) },
                    { new Guid("d7ab27ad-3685-4a71-a052-baec97b3d29e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4152), true, new Guid("bf2a2137-f276-4895-b265-35e102fc4843"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4152) }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "PermissionId", "RoleId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("08b352a5-c0cd-4a6a-9a04-0dc9fa842ca5"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4400), true, new Guid("7c67bad4-de81-4606-92ec-14fb46bf2162"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4400) },
                    { new Guid("172c82c3-e39c-4b0a-a1b7-ef459a6bd4a9"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4386), true, new Guid("ac72909c-bb74-4c59-90bd-0e8ed7709f17"), new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4386) },
                    { new Guid("3e4746d7-c551-4714-a60c-5eb5450dff9b"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4350), true, new Guid("36106883-d3b0-4d17-a232-160a0cefb5e0"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4350) },
                    { new Guid("46794543-be34-4ffc-a5fc-ca99760467a7"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4365), true, new Guid("4a2d708f-0249-4648-81ea-1dc6cb02e9b7"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4365) },
                    { new Guid("474c96f0-20ce-4a84-b03a-64a1b615fca4"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4379), true, new Guid("ac72909c-bb74-4c59-90bd-0e8ed7709f17"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4379) },
                    { new Guid("48b624a9-c126-4272-ad41-2fd44490b91b"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4387), true, new Guid("a967a98f-1d17-4a6d-b6c6-fdee5a482972"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4387) },
                    { new Guid("4fcc7fa4-0375-4819-a692-d45c55bd0ac9"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4355), true, new Guid("36106883-d3b0-4d17-a232-160a0cefb5e0"), new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4355) },
                    { new Guid("6c62721a-d403-4e10-825b-b1b803a42e1d"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4370), true, new Guid("4a2d708f-0249-4648-81ea-1dc6cb02e9b7"), new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4370) },
                    { new Guid("6c6881d6-96fc-4931-bba6-9795596d07e4"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4372), true, new Guid("4fc2158f-9010-440e-8930-d3cf63c99849"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4372) },
                    { new Guid("750d9861-c6da-4329-93e7-6864ab6adfa6"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4357), true, new Guid("0e08ea03-69e9-45d7-9036-dc5c3b4343a2"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4358) },
                    { new Guid("764363ab-f2cf-44b8-bf24-1332356180f7"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4253), true, new Guid("b7321a31-7f5a-4ef1-b5c5-932bde94dfc1"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4253) },
                    { new Guid("7f83bf46-324c-424d-8be1-196c27a4716d"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4318), true, new Guid("d60fbdf7-7eef-4dbe-b501-1f9e1a9c3804"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4318) },
                    { new Guid("8e95ea1e-2981-4e32-9705-097f6e2ef437"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4393), true, new Guid("5153a691-f6ad-42f9-b025-d3175afb3bdb"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4394) },
                    { new Guid("91a581db-1f55-426a-a312-e86a6400fa00"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4327), true, new Guid("592729f1-6cfd-4df0-b14e-5fe6fe7628f7"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4328) },
                    { new Guid("97d5f8e1-3551-4611-8385-e02d3c3f1b35"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4315), true, new Guid("01918278-8f94-4363-960f-1bba50581b88"), new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4315) },
                    { new Guid("9b1d36af-c883-4bd2-9cc1-9cf6cec4a5e0"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4259), true, new Guid("0c514eb6-6455-4717-8991-6c8408ba865c"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4259) },
                    { new Guid("9cc121e2-4a3d-4aff-bb21-a304b246383b"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4275), true, new Guid("a0554695-4366-4f69-a37a-3db53cfcf15f"), new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4275) },
                    { new Guid("ae8b5ff0-97dc-457d-b428-4fbc41a6a225"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4347), true, new Guid("cd52dfa1-bc13-47a0-ac61-25e6d8da60c9"), new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4347) },
                    { new Guid("b51c7a70-8524-437c-afd9-f7e3945ad561"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4333), true, new Guid("592729f1-6cfd-4df0-b14e-5fe6fe7628f7"), new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4333) },
                    { new Guid("b73a88b8-b95a-4a31-ba77-dac881d38edf"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4341), true, new Guid("cd52dfa1-bc13-47a0-ac61-25e6d8da60c9"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4342) },
                    { new Guid("b7fa349f-41ab-48cb-b5c4-7375534241b7"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4267), true, new Guid("a0554695-4366-4f69-a37a-3db53cfcf15f"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4267) },
                    { new Guid("c55e6aa7-9c7c-4be0-98e9-38f99723decc"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4326), true, new Guid("d60fbdf7-7eef-4dbe-b501-1f9e1a9c3804"), new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4326) },
                    { new Guid("cb2bd93e-9970-4e9f-b53f-8520ccd88a9d"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4363), true, new Guid("0e08ea03-69e9-45d7-9036-dc5c3b4343a2"), new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4363) },
                    { new Guid("cce8b73e-f612-46b2-88bd-ebb87c13e7fb"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4335), true, new Guid("70f2226c-9874-48b4-a5f9-3d6a9b95fbc6"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4335) },
                    { new Guid("ce7be2ec-c837-436f-97fb-adc1954c222b"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4263), true, new Guid("50a33715-2873-4c3c-b3f6-1f016d152caa"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4263) },
                    { new Guid("cebf5c3b-56b0-4225-9192-b2e33333e618"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4412), true, new Guid("aa34f7af-9772-4a06-9fa7-dd475175d6b1"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4412) },
                    { new Guid("d5307789-2c6d-4e08-99f7-5e9953e50ce3"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4423), true, new Guid("aa34f7af-9772-4a06-9fa7-dd475175d6b1"), new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4424) },
                    { new Guid("e3e9d377-4c6a-46cc-8905-f200fb089410"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4230), true, new Guid("d7ab27ad-3685-4a71-a052-baec97b3d29e"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4230) },
                    { new Guid("e62ce5a0-d44b-410a-910f-0d70df39cfae"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4277), true, new Guid("01918278-8f94-4363-960f-1bba50581b88"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4278) },
                    { new Guid("f505f125-1236-48d1-adfb-189b6504bfaa"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4406), true, new Guid("665a0ac7-7cc1-4cf6-95d6-1f68b9f28b9b"), new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"), new DateTime(2024, 9, 24, 13, 14, 26, 571, DateTimeKind.Utc).AddTicks(4406) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserFriends_Users_UserId",
                table: "UserFriends",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFriends_Users_UserId",
                table: "UserFriends");

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("08b352a5-c0cd-4a6a-9a04-0dc9fa842ca5"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("172c82c3-e39c-4b0a-a1b7-ef459a6bd4a9"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("3e4746d7-c551-4714-a60c-5eb5450dff9b"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("46794543-be34-4ffc-a5fc-ca99760467a7"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("474c96f0-20ce-4a84-b03a-64a1b615fca4"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("48b624a9-c126-4272-ad41-2fd44490b91b"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("4fcc7fa4-0375-4819-a692-d45c55bd0ac9"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("6c62721a-d403-4e10-825b-b1b803a42e1d"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("6c6881d6-96fc-4931-bba6-9795596d07e4"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("750d9861-c6da-4329-93e7-6864ab6adfa6"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("764363ab-f2cf-44b8-bf24-1332356180f7"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("7f83bf46-324c-424d-8be1-196c27a4716d"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("8e95ea1e-2981-4e32-9705-097f6e2ef437"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("91a581db-1f55-426a-a312-e86a6400fa00"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("97d5f8e1-3551-4611-8385-e02d3c3f1b35"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("9b1d36af-c883-4bd2-9cc1-9cf6cec4a5e0"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("9cc121e2-4a3d-4aff-bb21-a304b246383b"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("ae8b5ff0-97dc-457d-b428-4fbc41a6a225"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("b51c7a70-8524-437c-afd9-f7e3945ad561"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("b73a88b8-b95a-4a31-ba77-dac881d38edf"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("b7fa349f-41ab-48cb-b5c4-7375534241b7"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("c55e6aa7-9c7c-4be0-98e9-38f99723decc"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("cb2bd93e-9970-4e9f-b53f-8520ccd88a9d"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("cce8b73e-f612-46b2-88bd-ebb87c13e7fb"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("ce7be2ec-c837-436f-97fb-adc1954c222b"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("cebf5c3b-56b0-4225-9192-b2e33333e618"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("d5307789-2c6d-4e08-99f7-5e9953e50ce3"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("e3e9d377-4c6a-46cc-8905-f200fb089410"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("e62ce5a0-d44b-410a-910f-0d70df39cfae"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("f505f125-1236-48d1-adfb-189b6504bfaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a12c44d-f920-4336-8345-0b5c8a64c741"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("01918278-8f94-4363-960f-1bba50581b88"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0c514eb6-6455-4717-8991-6c8408ba865c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0e08ea03-69e9-45d7-9036-dc5c3b4343a2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("36106883-d3b0-4d17-a232-160a0cefb5e0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4a2d708f-0249-4648-81ea-1dc6cb02e9b7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4fc2158f-9010-440e-8930-d3cf63c99849"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("50a33715-2873-4c3c-b3f6-1f016d152caa"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5153a691-f6ad-42f9-b025-d3175afb3bdb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("592729f1-6cfd-4df0-b14e-5fe6fe7628f7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("665a0ac7-7cc1-4cf6-95d6-1f68b9f28b9b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("70f2226c-9874-48b4-a5f9-3d6a9b95fbc6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7c67bad4-de81-4606-92ec-14fb46bf2162"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a0554695-4366-4f69-a37a-3db53cfcf15f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a967a98f-1d17-4a6d-b6c6-fdee5a482972"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa34f7af-9772-4a06-9fa7-dd475175d6b1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ac72909c-bb74-4c59-90bd-0e8ed7709f17"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b7321a31-7f5a-4ef1-b5c5-932bde94dfc1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cd52dfa1-bc13-47a0-ac61-25e6d8da60c9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d60fbdf7-7eef-4dbe-b501-1f9e1a9c3804"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d7ab27ad-3685-4a71-a052-baec97b3d29e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1a0e7d91-cbca-4b87-94d8-535d1edde83e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("85039db5-a2c2-4736-a0eb-af6762ee4098"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("026e07e3-2597-49d7-9525-e57fee403120"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("0a014fab-cb43-4f36-ad3f-3c7efb0b57ac"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("0a1c7340-c811-4279-a010-caaacdf88a34"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("0b38533e-bd77-4dbb-ac3c-fb60e9c96737"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("18b3f1b9-49a5-4f2d-9b97-61d0af6ae28b"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("1d33b040-3353-4eeb-9ce1-c0e8bd8f49da"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("2e7a1420-0397-4c15-88bc-3c0ffb034251"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("465be5e6-59a7-4c0f-bcfa-5786573112b0"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("492b84a9-1a1d-49db-994c-c1d6823a9239"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("5343eaf8-28ec-437a-91f1-4f64a8054a4d"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("5ff14bb6-10b6-41fe-9f70-2333d115bdd8"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("60588be8-b18e-4d43-8f8a-f59fee0d5c9a"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("803e67df-264a-4339-8188-655a396a637e"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("9516146b-3072-4a13-934e-d7dc26b6f04e"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("9707e1cd-0f54-4fc6-b1a3-19c48f8ea764"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("a873a5d9-2cca-4811-a885-c5c52f32930c"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("bf2a2137-f276-4895-b265-35e102fc4843"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("d3299a5e-aeae-44e5-96d1-1c7b15e92ede"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("e5459fbc-71cf-44d2-88b0-1e9e3866662f"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("f3d31352-0e5e-47be-ac61-575a8b67eed2"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("02c702d2-3c57-4325-9dcb-b5b7ec44ad65"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("67257b12-7828-4629-8ee3-f2757469c450"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("72928ddb-a5fa-4eaa-aecf-093e29da5465"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("9dbd3419-2a6e-4e3d-aa35-1767af7004e9"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("c58b3e39-8a67-4ecc-b74c-235eb77914bd"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("533c8997-41d4-48a6-8689-1e83faff1754"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("745936be-c608-42d4-8950-9986d587a965"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("9d2a6b03-3f98-42d5-b980-6fc93340f9d1"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("b5b12ef3-3877-4960-9802-1bdea1558d63"));

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "UserFriends");

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("32226422-fd4b-435d-8622-f5966fadf7d3"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9778), true, "Read", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9778) },
                    { new Guid("438df840-9c8a-4e8d-9df5-5e1a01f25470"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9779), true, "Update", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9780) },
                    { new Guid("6cc41e61-a0b4-4d88-b963-ecbe5aff1ddb"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9782), true, "ChangeStatus", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9782) },
                    { new Guid("ae666752-8ae3-422e-8e8f-70904beb8d15"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9781), true, "Delete", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9781) },
                    { new Guid("ff2e2bae-b84e-40d0-8723-0a1c8c4358ff"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9775), true, "Create", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9776) }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("8a5ef4e6-c8bb-4422-8aae-2d80c860d149"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9734), true, "Resources", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9734) },
                    { new Guid("a5ddeab6-add2-4f76-b8e4-47122a68f989"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9727), true, "Users", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9727) },
                    { new Guid("cd9bcd28-6ef4-4601-a259-cba810a90406"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9732), true, "Albums", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9733) },
                    { new Guid("e917669a-0930-4e29-b1d8-e70e4b479f74"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9731), true, "Moments", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9731) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(8669), true, "User", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(8669) },
                    { new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(8665), true, "Admin", new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(8667) }
                });

            migrationBuilder.InsertData(
                table: "ModuleActions",
                columns: new[] { "Id", "ActionId", "CreatedAt", "IsActive", "ModuleId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2b6607cb-3e80-4ad5-a7f3-42fa017e01e2"), new Guid("438df840-9c8a-4e8d-9df5-5e1a01f25470"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9815), true, new Guid("a5ddeab6-add2-4f76-b8e4-47122a68f989"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9815) },
                    { new Guid("2c4911d5-7a3e-414c-9ceb-54d1e749aec2"), new Guid("438df840-9c8a-4e8d-9df5-5e1a01f25470"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9833), true, new Guid("8a5ef4e6-c8bb-4422-8aae-2d80c860d149"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9834) },
                    { new Guid("3ff900ef-989b-4c45-bd14-ba9efd65383a"), new Guid("ff2e2bae-b84e-40d0-8723-0a1c8c4358ff"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9826), true, new Guid("cd9bcd28-6ef4-4601-a259-cba810a90406"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9826) },
                    { new Guid("4b92de4f-06f6-4c1d-8f28-675c9043c354"), new Guid("6cc41e61-a0b4-4d88-b963-ecbe5aff1ddb"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9817), true, new Guid("a5ddeab6-add2-4f76-b8e4-47122a68f989"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9817) },
                    { new Guid("5b548629-b89c-49e9-9f12-6b198f16abec"), new Guid("ae666752-8ae3-422e-8e8f-70904beb8d15"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9821), true, new Guid("e917669a-0930-4e29-b1d8-e70e4b479f74"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9822) },
                    { new Guid("622fc1a5-d3b8-4426-ba7e-3eef9c55c47b"), new Guid("ff2e2bae-b84e-40d0-8723-0a1c8c4358ff"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9807), true, new Guid("a5ddeab6-add2-4f76-b8e4-47122a68f989"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9808) },
                    { new Guid("67288ef1-7952-4b02-96f8-c28e16791a3d"), new Guid("6cc41e61-a0b4-4d88-b963-ecbe5aff1ddb"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9837), true, new Guid("8a5ef4e6-c8bb-4422-8aae-2d80c860d149"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9837) },
                    { new Guid("684f266d-c0af-4731-a687-363cf43b44ab"), new Guid("32226422-fd4b-435d-8622-f5966fadf7d3"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9831), true, new Guid("8a5ef4e6-c8bb-4422-8aae-2d80c860d149"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9832) },
                    { new Guid("6fbfb466-6ff6-4043-9924-85c5bbce0f67"), new Guid("ae666752-8ae3-422e-8e8f-70904beb8d15"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9836), true, new Guid("8a5ef4e6-c8bb-4422-8aae-2d80c860d149"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9836) },
                    { new Guid("749b775c-abeb-49fa-99f9-819b4e554c7c"), new Guid("438df840-9c8a-4e8d-9df5-5e1a01f25470"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9821), true, new Guid("e917669a-0930-4e29-b1d8-e70e4b479f74"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9821) },
                    { new Guid("87136741-dab2-4e30-8818-347233405675"), new Guid("438df840-9c8a-4e8d-9df5-5e1a01f25470"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9828), true, new Guid("cd9bcd28-6ef4-4601-a259-cba810a90406"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9828) },
                    { new Guid("8751bde9-7d8b-4fbe-8f23-a2293a542f02"), new Guid("6cc41e61-a0b4-4d88-b963-ecbe5aff1ddb"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9829), true, new Guid("cd9bcd28-6ef4-4601-a259-cba810a90406"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9830) },
                    { new Guid("8919540f-26b8-412d-80ad-48758df9cffd"), new Guid("ff2e2bae-b84e-40d0-8723-0a1c8c4358ff"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9819), true, new Guid("e917669a-0930-4e29-b1d8-e70e4b479f74"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9819) },
                    { new Guid("8ffaa508-1f1a-4116-8ef4-1f7185e0ca78"), new Guid("6cc41e61-a0b4-4d88-b963-ecbe5aff1ddb"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9823), true, new Guid("e917669a-0930-4e29-b1d8-e70e4b479f74"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9823) },
                    { new Guid("9ba36d36-095c-4389-84aa-a2efe122460e"), new Guid("32226422-fd4b-435d-8622-f5966fadf7d3"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9812), true, new Guid("a5ddeab6-add2-4f76-b8e4-47122a68f989"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9812) },
                    { new Guid("aa189dbf-21ae-472b-a9e6-aedabacb7a7b"), new Guid("ae666752-8ae3-422e-8e8f-70904beb8d15"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9829), true, new Guid("cd9bcd28-6ef4-4601-a259-cba810a90406"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9829) },
                    { new Guid("dba59d2c-5617-4a5c-a702-7216583ba46d"), new Guid("32226422-fd4b-435d-8622-f5966fadf7d3"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9827), true, new Guid("cd9bcd28-6ef4-4601-a259-cba810a90406"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9827) },
                    { new Guid("e443d2e8-8334-40a9-8395-3156d66cd249"), new Guid("32226422-fd4b-435d-8622-f5966fadf7d3"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9820), true, new Guid("e917669a-0930-4e29-b1d8-e70e4b479f74"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9820) },
                    { new Guid("e73e29a2-14e0-4b9d-98c5-e3838156d66d"), new Guid("ae666752-8ae3-422e-8e8f-70904beb8d15"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9816), true, new Guid("a5ddeab6-add2-4f76-b8e4-47122a68f989"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9816) },
                    { new Guid("ffb29d1d-7ea2-41d9-8d32-099b23f84052"), new Guid("ff2e2bae-b84e-40d0-8723-0a1c8c4358ff"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9830), true, new Guid("8a5ef4e6-c8bb-4422-8aae-2d80c860d149"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9831) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("77be2037-896b-4f67-bccc-07ca18ce9041"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(8912), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "ModuleActionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0d1de5a5-faab-4a87-90cb-d81dc0ec6c44"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9913), true, new Guid("8751bde9-7d8b-4fbe-8f23-a2293a542f02"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9914) },
                    { new Guid("1d76cee5-8ba5-46dd-a178-05363eaffb3e"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9912), true, new Guid("87136741-dab2-4e30-8818-347233405675"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9912) },
                    { new Guid("1f88e8b5-108d-484e-8c3c-83e222df36f6"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9894), true, new Guid("622fc1a5-d3b8-4426-ba7e-3eef9c55c47b"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9895) },
                    { new Guid("22850a87-11ff-4bbf-8831-306d87a4871a"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9901), true, new Guid("e73e29a2-14e0-4b9d-98c5-e3838156d66d"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9901) },
                    { new Guid("33d425c9-4267-4e52-88f5-92e9ffb5d886"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9910), true, new Guid("3ff900ef-989b-4c45-bd14-ba9efd65383a"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9910) },
                    { new Guid("3675810b-e9be-4412-a58b-c730e9a6d53f"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9909), true, new Guid("8ffaa508-1f1a-4116-8ef4-1f7185e0ca78"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9909) },
                    { new Guid("36b2266e-a6c8-4962-922b-8b2be9720c5a"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9904), true, new Guid("e443d2e8-8334-40a9-8395-3156d66cd249"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9904) },
                    { new Guid("39ba2a09-f6b8-4d29-8145-0e6d15164361"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9917), true, new Guid("2c4911d5-7a3e-414c-9ceb-54d1e749aec2"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9918) },
                    { new Guid("455cc9fb-f187-4c2f-af5f-5af5ebcc224d"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9899), true, new Guid("2b6607cb-3e80-4ad5-a7f3-42fa017e01e2"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9900) },
                    { new Guid("482adfba-e417-4c4a-ac85-db066c1aa816"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9903), true, new Guid("8919540f-26b8-412d-80ad-48758df9cffd"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9903) },
                    { new Guid("62917908-4544-4dbd-8ebd-6345bbf2b189"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9918), true, new Guid("6fbfb466-6ff6-4043-9924-85c5bbce0f67"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9919) },
                    { new Guid("78e42460-6722-4b4c-91a7-6a0ad1ef36a1"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9906), true, new Guid("749b775c-abeb-49fa-99f9-819b4e554c7c"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9907) },
                    { new Guid("7fa5b6f1-09bc-465a-9f43-260603a49cf6"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9902), true, new Guid("4b92de4f-06f6-4c1d-8f28-675c9043c354"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9902) },
                    { new Guid("81e0da8a-bde9-46e0-9b97-21cf8f40eb3e"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9908), true, new Guid("5b548629-b89c-49e9-9f12-6b198f16abec"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9908) },
                    { new Guid("9a67c10b-3e32-4758-9a95-903d31a9da1d"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9916), true, new Guid("684f266d-c0af-4731-a687-363cf43b44ab"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9917) },
                    { new Guid("a889ebbb-13f7-47e6-b0ca-ff9ec8a8013a"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9898), true, new Guid("9ba36d36-095c-4389-84aa-a2efe122460e"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9898) },
                    { new Guid("b13c8f82-cfd0-408c-b5e1-08f13b354a32"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9919), true, new Guid("67288ef1-7952-4b02-96f8-c28e16791a3d"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9920) },
                    { new Guid("b4b0a7e4-a034-4598-9d5e-ee1e60282401"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9912), true, new Guid("aa189dbf-21ae-472b-a9e6-aedabacb7a7b"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9913) },
                    { new Guid("dc2bfc38-b0f5-423b-8a4c-927e1725b2df"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9911), true, new Guid("dba59d2c-5617-4a5c-a702-7216583ba46d"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9911) },
                    { new Guid("edb88a9c-dc89-4531-ae28-238ca0710bc7"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9916), true, new Guid("ffb29d1d-7ea2-41d9-8d32-099b23f84052"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9916) }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "PermissionId", "RoleId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0b401705-e2b3-4a72-830e-59ecf259526f"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(183), true, new Guid("62917908-4544-4dbd-8ebd-6345bbf2b189"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(183) },
                    { new Guid("2a2e06b0-b385-4a2b-8fdd-ad7756bf24cb"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(39), true, new Guid("7fa5b6f1-09bc-465a-9f43-260603a49cf6"), new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(40) },
                    { new Guid("2fb21b03-7761-47f9-80e3-d641df2f4ea6"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(110), true, new Guid("b4b0a7e4-a034-4598-9d5e-ee1e60282401"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(110) },
                    { new Guid("318e7835-c21e-4684-ae0a-d67bd39aa230"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(32), true, new Guid("7fa5b6f1-09bc-465a-9f43-260603a49cf6"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(32) },
                    { new Guid("3ca22413-da76-4187-bbe5-fbe6137976c0"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(189), true, new Guid("b13c8f82-cfd0-408c-b5e1-08f13b354a32"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(190) },
                    { new Guid("4e6c2177-9647-471c-a846-4a46efc9baa9"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(59), true, new Guid("36b2266e-a6c8-4962-922b-8b2be9720c5a"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(59) },
                    { new Guid("5361ccc1-0f5b-49d8-b669-4494a6f386f8"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(93), true, new Guid("33d425c9-4267-4e52-88f5-92e9ffb5d886"), new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(93) },
                    { new Guid("5945165b-e33e-448c-9e66-721bd6138292"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(17), true, new Guid("a889ebbb-13f7-47e6-b0ca-ff9ec8a8013a"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(17) },
                    { new Guid("5e8bfb31-93da-4cde-b83b-98d278b7dbe8"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(161), true, new Guid("0d1de5a5-faab-4a87-90cb-d81dc0ec6c44"), new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(161) },
                    { new Guid("635438fe-3efd-47b6-9004-099a63967a57"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(81), true, new Guid("3675810b-e9be-4412-a58b-c730e9a6d53f"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(81) },
                    { new Guid("6532c612-0e5b-4899-b451-1b500e84f3e6"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(65), true, new Guid("36b2266e-a6c8-4962-922b-8b2be9720c5a"), new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(65) },
                    { new Guid("673e9357-216d-4745-abaa-0bdaa91217bb"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(73), true, new Guid("78e42460-6722-4b4c-91a7-6a0ad1ef36a1"), new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(73) },
                    { new Guid("6e6aa89a-29ba-4317-b7f2-f35c0e0b7f37"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(100), true, new Guid("dc2bfc38-b0f5-423b-8a4c-927e1725b2df"), new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(100) },
                    { new Guid("76792f32-abb3-4b49-933c-c5215d6ba3ab"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(202), true, new Guid("b13c8f82-cfd0-408c-b5e1-08f13b354a32"), new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(202) },
                    { new Guid("7b3c1903-d913-46ef-b9c6-1f924f8737f2"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(95), true, new Guid("dc2bfc38-b0f5-423b-8a4c-927e1725b2df"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(95) },
                    { new Guid("82bdddab-b435-4fe0-ae00-aa3627da4938"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(43), true, new Guid("482adfba-e417-4c4a-ac85-db066c1aa816"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(43) },
                    { new Guid("89011f81-ae29-4b41-935a-740aada8c462"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(155), true, new Guid("0d1de5a5-faab-4a87-90cb-d81dc0ec6c44"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(155) },
                    { new Guid("9163a812-bdce-44ee-b060-13c312f0dcdf"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(169), true, new Guid("9a67c10b-3e32-4758-9a95-903d31a9da1d"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(169) },
                    { new Guid("93cd3087-c067-4f5d-b93f-f1458ffc5daa"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(66), true, new Guid("78e42460-6722-4b4c-91a7-6a0ad1ef36a1"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(67) },
                    { new Guid("9a7f0430-9619-4fc6-9bf8-8aefff263ab9"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(163), true, new Guid("edb88a9c-dc89-4531-ae28-238ca0710bc7"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(163) },
                    { new Guid("9fd31ca5-1da6-4e40-a187-0a4731d68adf"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(86), true, new Guid("3675810b-e9be-4412-a58b-c730e9a6d53f"), new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(86) },
                    { new Guid("a599c835-4123-4829-80a2-223047b0140b"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(108), true, new Guid("1d76cee5-8ba5-46dd-a178-05363eaffb3e"), new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(108) },
                    { new Guid("a8d957ef-1174-43e6-a9d5-cc2cb2934863"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(175), true, new Guid("39ba2a09-f6b8-4d29-8145-0e6d15164361"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(175) },
                    { new Guid("aaf57ad6-8d05-4f91-a070-b778fd564ead"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(103), true, new Guid("1d76cee5-8ba5-46dd-a178-05363eaffb3e"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(103) },
                    { new Guid("b09c4fab-3c0d-4c9c-a4d9-7d5e396e1568"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9986), true, new Guid("1f88e8b5-108d-484e-8c3c-83e222df36f6"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 485, DateTimeKind.Utc).AddTicks(9986) },
                    { new Guid("b3633229-0cd8-491d-bb79-d541bdd8bad5"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(22), true, new Guid("455cc9fb-f187-4c2f-af5f-5af5ebcc224d"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(23) },
                    { new Guid("cf65078e-049f-4588-b122-9877732f69f7"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(55), true, new Guid("482adfba-e417-4c4a-ac85-db066c1aa816"), new Guid("da7c8204-8ed0-462b-b287-833053b1514e"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(55) },
                    { new Guid("d4b5c0d5-018d-4b54-b2d7-cf2236ce4bd2"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(75), true, new Guid("81e0da8a-bde9-46e0-9b97-21cf8f40eb3e"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(75) },
                    { new Guid("f604c3e1-9669-4c47-a163-293afa4ef158"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(28), true, new Guid("22850a87-11ff-4bbf-8831-306d87a4871a"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(28) },
                    { new Guid("fda68cc4-b547-465e-969e-94311c5d6450"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(88), true, new Guid("33d425c9-4267-4e52-88f5-92e9ffb5d886"), new Guid("e6c5469a-4882-4a38-b0d3-1c44ead46a8d"), new DateTime(2024, 9, 24, 5, 34, 28, 486, DateTimeKind.Utc).AddTicks(88) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserFriends_Users_UserId",
                table: "UserFriends",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
