using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class user_friends : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("02514686-7daa-4276-b30a-949bd0d64cb5"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("026cadb6-3d55-4db8-949a-0b9bbbaa4a63"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("1997f47b-2979-49af-a132-ddab30593d60"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("1a38b735-6392-40c5-9107-584e24a0f849"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("20039998-7fab-4f7c-835b-5ee6ac4b21d6"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("209f7418-b6ac-4be4-ae6b-e64aa9bf7828"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("2c303653-0069-4a26-9c42-f188ef0f18da"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("3a86c3f3-dd76-44b1-8c00-de2f5fcca13d"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("42d63ac8-1eab-4412-8dfd-731a9944edb3"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("43382802-75fa-43be-a72f-95e724989a7f"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("442e0dc4-eb8b-41d1-8b1a-2c4b67d1b8d0"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("596d5ef4-a60f-44ee-9fe5-44beaacdce8e"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("6166af2a-a810-4eae-a178-5ac43c19a842"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("750f03e3-51d3-498a-acaf-4dcebd58317a"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("87a685fa-ed0e-4b9b-96b5-1ddc1eedafb5"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("8803eac0-27ee-46e4-8327-924803ae2123"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("8b02b1d4-5c78-44ab-bfd0-8853092f99ca"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("9045e8d9-54cf-4fb0-ba11-30e651c3f312"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("915556db-cc4c-4593-9431-5890875807c0"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("9a9c5ef1-e9ea-45fe-aef6-c74adacda472"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("9c9c296f-0ab0-4a15-a238-4b3ece52f9da"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("a5cb346a-d3d4-40a8-a152-affb02bae7f3"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("a8887fef-858b-4126-84a4-9e14c705dac6"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("a98f91ae-1b83-46a3-b558-4520114dcfd3"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("b3502469-5b16-4cad-902a-4f85718d1027"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("b6943a35-5717-4730-879d-d0c109e27467"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("cc9b0880-b249-43aa-9e6c-a56b93e9d0fd"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("d32549cc-441b-4bf2-8fe6-ce93239c2bc6"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("e0423ddf-f86d-4f32-88bf-f2359b8f47fc"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("fda9ac36-4a2f-45a7-ba24-a2436d1900b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e04fd15-75e1-4ebf-95e3-73ba7ceb52af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1eb405af-92ab-4511-8286-9147cb6caadd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2621a768-e7b4-414a-a57b-984127be5383"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("26c8bfd5-001c-4590-aa44-3f842e5d53d1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2e7c1af5-10af-4299-b14b-9d0232e5406b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4399b19f-3d81-4d6c-8bb5-dc1bd3da48ce"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("44144e79-c67b-4c8c-b238-f405b622a4b4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("45c0f253-4027-443b-9e54-f40cc8abff30"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5ad92960-edb7-4fa0-a988-c903bd8990b3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6aa19874-1db9-4ebb-83aa-860226827d6b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("78b54657-cc00-4e24-a2f0-442f1212683c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7c1435ae-8302-4f94-a4ca-4805e6e86d43"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8d79725f-7b37-4111-83fc-ac49d5902856"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa62d662-d418-49c6-9355-e8e0756619f9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bb48d020-203a-41fb-9767-4c0f00f66760"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c1d9a350-753d-4f13-b1b0-674bbb34f127"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c2a3ec14-1084-4986-a9df-38b0662d3988"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ca2287e6-d1ff-4abe-b513-2d5ee6686363"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dfa65478-2ae3-433a-9279-d88e4c593a5d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e520bae3-c34c-4719-ad8c-74ec3a1c8d44"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e845915d-b751-4e41-b62e-8c08db34c5bf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("126d27af-566b-4549-af30-ce00f2c6bc2c"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("1cfca5cd-5a94-48d3-a190-de67d90b7f09"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("1ddd034c-aa05-4c7c-897a-c8ffb728718b"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("1e70d0dc-fff2-4aef-8ba8-ab4f84f41681"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("3889a17f-b06d-4b02-ac4b-b43f72e331e8"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("3a328088-d45e-4223-af67-e1bbbed96102"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("3b395a7f-35be-46d5-9aa2-3a8b80786df2"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("47d20fab-d459-430f-a377-72f9daf6aa81"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("4de112c6-dbd8-4453-9714-b96cc8bf4395"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("597d4e64-7f26-436f-92c7-62982dfa27b3"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("5a45b57c-ba1d-41ae-b880-066060de4b60"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("66d8ae98-a951-42ab-bd01-a3dcc848179f"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("7760eea6-fae4-4529-ac17-4b11977c1551"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("898dfaf9-92a6-4448-aed5-6a93bdc71a93"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("a0232e7d-4501-4d70-b284-f90d748fadf5"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("b10b7290-03fe-401e-9a33-9a725a97aa82"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("b1524a69-cdb9-4710-807b-884c2d14ba4c"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("ba6f6592-ef99-4247-9483-6ecfc6403972"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("c3ff5e98-fb19-4e7d-ac74-ea77da425028"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("cd82a094-9c1d-4ab6-a319-3715eede1055"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("0db32b7a-fa94-4631-938f-9c0a7aab0ad5"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("1548a1de-e522-4af1-859b-4e461af076b1"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("53823cac-e405-45a7-a0fa-c5d117a08f0e"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("a955b6ce-7a2e-45eb-a57d-c10b14f7c7ae"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("e66aa05c-4628-4fcb-afbb-217e2c3f0e8b"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("0dcbe3fb-a8ea-4a2b-ac4e-512bd7a6d9cc"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("12f626da-7615-441e-8276-dfe9d958d67c"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("6a465d4d-2c2a-46bc-9972-d3052fabc2c6"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("be00908e-b067-411a-911b-9d0864c639f5"));

            migrationBuilder.CreateTable(
                name: "UserFriends",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFriends", x => new { x.UserId, x.FriendId });
                    table.ForeignKey(
                        name: "FK_UserFriends_Users_FriendId",
                        column: x => x.FriendId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFriends_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1a4f35f1-cceb-4aa9-b448-5ed823df4a9d"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4449), true, "Update", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4450) },
                    { new Guid("56b186d3-1f07-4598-ae23-712b1a5b9fe2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4444), true, "Create", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4444) },
                    { new Guid("63c4e40e-bb10-469a-83a5-0111e6bae0be"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4447), true, "Read", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4447) },
                    { new Guid("aed8b54e-4cc3-4dd6-b68a-1bfd39fca1fd"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4452), true, "Delete", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4452) },
                    { new Guid("b789df21-37e0-42f2-b4e4-f17540b50c2c"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4459), true, "ChangeStatus", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4459) }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0ec17b23-c4d4-4a61-ba31-4b93db9b0823"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4388), true, "Users", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4389) },
                    { new Guid("1b7bf363-2a53-4771-92e7-27036d403473"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4398), true, "Albums", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4398) },
                    { new Guid("ac11bc95-bf0a-4de8-9312-0b50ab30a4e9"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4400), true, "Resources", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4400) },
                    { new Guid("f493c1c3-917d-49fd-914d-42d3f0319f7b"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4395), true, "Moments", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4396) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(3123), true, "Admin", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(3126) },
                    { new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(3128), true, "User", new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(3129) }
                });

            migrationBuilder.InsertData(
                table: "ModuleActions",
                columns: new[] { "Id", "ActionId", "CreatedAt", "IsActive", "ModuleId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("325840f6-bb88-4369-9085-31e29e93467f"), new Guid("1a4f35f1-cceb-4aa9-b448-5ed823df4a9d"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4525), true, new Guid("1b7bf363-2a53-4771-92e7-27036d403473"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4526) },
                    { new Guid("34362d85-5f3c-411e-a39e-12c13bbfec83"), new Guid("1a4f35f1-cceb-4aa9-b448-5ed823df4a9d"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4504), true, new Guid("0ec17b23-c4d4-4a61-ba31-4b93db9b0823"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4505) },
                    { new Guid("4fa09d33-f495-4ebc-9816-6ef4c1a0a17c"), new Guid("56b186d3-1f07-4598-ae23-712b1a5b9fe2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4511), true, new Guid("f493c1c3-917d-49fd-914d-42d3f0319f7b"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4512) },
                    { new Guid("61cdd6d5-e1d2-44ab-9afa-4da446abcc2e"), new Guid("63c4e40e-bb10-469a-83a5-0111e6bae0be"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4533), true, new Guid("ac11bc95-bf0a-4de8-9312-0b50ab30a4e9"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4534) },
                    { new Guid("63618758-605f-4324-a00b-a88921a6c06c"), new Guid("63c4e40e-bb10-469a-83a5-0111e6bae0be"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4515), true, new Guid("f493c1c3-917d-49fd-914d-42d3f0319f7b"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4515) },
                    { new Guid("64ebfe08-a224-4b87-9a7e-17c7fe2fe4e0"), new Guid("56b186d3-1f07-4598-ae23-712b1a5b9fe2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4497), true, new Guid("0ec17b23-c4d4-4a61-ba31-4b93db9b0823"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4497) },
                    { new Guid("6aa109d1-8daf-4820-aace-d0681312496b"), new Guid("b789df21-37e0-42f2-b4e4-f17540b50c2c"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4508), true, new Guid("0ec17b23-c4d4-4a61-ba31-4b93db9b0823"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4508) },
                    { new Guid("7042ef50-5f78-4952-bac5-7731090f29dc"), new Guid("1a4f35f1-cceb-4aa9-b448-5ed823df4a9d"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4517), true, new Guid("f493c1c3-917d-49fd-914d-42d3f0319f7b"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4517) },
                    { new Guid("71928e63-9f4c-45dc-8ebf-94ce99efba04"), new Guid("aed8b54e-4cc3-4dd6-b68a-1bfd39fca1fd"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4527), true, new Guid("1b7bf363-2a53-4771-92e7-27036d403473"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4527) },
                    { new Guid("86745b24-d321-40e6-9bed-0dd1c36a75ed"), new Guid("1a4f35f1-cceb-4aa9-b448-5ed823df4a9d"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4536), true, new Guid("ac11bc95-bf0a-4de8-9312-0b50ab30a4e9"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4536) },
                    { new Guid("abc47213-15f9-4803-916d-4df573367eca"), new Guid("aed8b54e-4cc3-4dd6-b68a-1bfd39fca1fd"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4518), true, new Guid("f493c1c3-917d-49fd-914d-42d3f0319f7b"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4518) },
                    { new Guid("ae152cf3-029d-4f83-8aef-5f87ee7013ec"), new Guid("aed8b54e-4cc3-4dd6-b68a-1bfd39fca1fd"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4538), true, new Guid("ac11bc95-bf0a-4de8-9312-0b50ab30a4e9"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4538) },
                    { new Guid("aebf73a1-7403-451c-804c-e7294b4260fa"), new Guid("b789df21-37e0-42f2-b4e4-f17540b50c2c"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4530), true, new Guid("1b7bf363-2a53-4771-92e7-27036d403473"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4530) },
                    { new Guid("b26a486f-5869-4423-9e86-a6544e6e2e5f"), new Guid("56b186d3-1f07-4598-ae23-712b1a5b9fe2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4531), true, new Guid("ac11bc95-bf0a-4de8-9312-0b50ab30a4e9"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4532) },
                    { new Guid("ddbb18d7-0a32-45cb-9a5c-5c0cb820296d"), new Guid("aed8b54e-4cc3-4dd6-b68a-1bfd39fca1fd"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4506), true, new Guid("0ec17b23-c4d4-4a61-ba31-4b93db9b0823"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4506) },
                    { new Guid("dec8d6a6-7028-41fe-a075-af1d9be343cd"), new Guid("b789df21-37e0-42f2-b4e4-f17540b50c2c"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4520), true, new Guid("f493c1c3-917d-49fd-914d-42d3f0319f7b"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4521) },
                    { new Guid("dfa4d63e-b728-4a90-adfa-af3ad4efffeb"), new Guid("56b186d3-1f07-4598-ae23-712b1a5b9fe2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4522), true, new Guid("1b7bf363-2a53-4771-92e7-27036d403473"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4523) },
                    { new Guid("ecd654b4-0a2e-45da-896d-610da6fcc5cc"), new Guid("63c4e40e-bb10-469a-83a5-0111e6bae0be"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4502), true, new Guid("0ec17b23-c4d4-4a61-ba31-4b93db9b0823"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4503) },
                    { new Guid("f160cf3c-2953-4553-9253-a8743c4a1114"), new Guid("b789df21-37e0-42f2-b4e4-f17540b50c2c"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4539), true, new Guid("ac11bc95-bf0a-4de8-9312-0b50ab30a4e9"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4539) },
                    { new Guid("f2a91eeb-d46e-49bb-8baa-12b913a46d96"), new Guid("63c4e40e-bb10-469a-83a5-0111e6bae0be"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4524), true, new Guid("1b7bf363-2a53-4771-92e7-27036d403473"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4524) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("ec94bf46-2537-4514-8791-5a2a95b1fcea"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(3324), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "ModuleActionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("229cb013-1037-4fe9-aacf-859fe6ade4da"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4812), true, new Guid("f160cf3c-2953-4553-9253-a8743c4a1114"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4812) },
                    { new Guid("267f00e9-655a-4082-97bd-fe572031ad77"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4789), true, new Guid("abc47213-15f9-4803-916d-4df573367eca"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4790) },
                    { new Guid("289c4f18-46d9-4636-9696-6e3114476ec4"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4787), true, new Guid("7042ef50-5f78-4952-bac5-7731090f29dc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4788) },
                    { new Guid("2b5d3c10-8349-4f07-8e0d-c5787290d4a7"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4797), true, new Guid("f2a91eeb-d46e-49bb-8baa-12b913a46d96"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4797) },
                    { new Guid("32d70498-4c33-4fe1-8dae-f78f442b7e9d"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4644), true, new Guid("34362d85-5f3c-411e-a39e-12c13bbfec83"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4644) },
                    { new Guid("4438bef7-348e-4932-af23-7bff6cbd961a"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4638), true, new Guid("64ebfe08-a224-4b87-9a7e-17c7fe2fe4e0"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4639) },
                    { new Guid("4d79993d-f3c6-4fd1-b41a-894ae2a06ad6"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4802), true, new Guid("aebf73a1-7403-451c-804c-e7294b4260fa"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4802) },
                    { new Guid("53c37fdf-ae8d-45be-bb38-e93b6de9f834"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4804), true, new Guid("b26a486f-5869-4423-9e86-a6544e6e2e5f"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4804) },
                    { new Guid("5529ea74-398c-4cdd-9e3d-087f23ac3267"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4793), true, new Guid("dfa4d63e-b728-4a90-adfa-af3ad4efffeb"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4793) },
                    { new Guid("5ad051f6-05d9-40f6-bfa2-c3be514693d7"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4791), true, new Guid("dec8d6a6-7028-41fe-a075-af1d9be343cd"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4792) },
                    { new Guid("675eda32-05a8-48f3-911c-9756bf7e26f0"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4651), true, new Guid("4fa09d33-f495-4ebc-9816-6ef4c1a0a17c"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4652) },
                    { new Guid("9073e03a-cd4d-47e6-9641-08c7c87ead70"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4650), true, new Guid("6aa109d1-8daf-4820-aace-d0681312496b"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4650) },
                    { new Guid("a672fbf3-2173-45f2-9d6e-62869d4d7c3a"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4808), true, new Guid("ae152cf3-029d-4f83-8aef-5f87ee7013ec"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4809) },
                    { new Guid("a88d7172-2f76-43f7-aae4-6a1f68a386a1"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4648), true, new Guid("ddbb18d7-0a32-45cb-9a5c-5c0cb820296d"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4648) },
                    { new Guid("c602c18e-78ca-4e29-81ca-ede548ee8eb0"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4642), true, new Guid("ecd654b4-0a2e-45da-896d-610da6fcc5cc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4642) },
                    { new Guid("e382a1b9-5c7c-4f58-a696-5af08b1f70af"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4805), true, new Guid("61cdd6d5-e1d2-44ab-9afa-4da446abcc2e"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4805) },
                    { new Guid("e580f810-852b-44f3-b99e-cfe537b667af"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4800), true, new Guid("71928e63-9f4c-45dc-8ebf-94ce99efba04"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4801) },
                    { new Guid("e86a2c33-444d-4907-8bea-6dc79d00de77"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4799), true, new Guid("325840f6-bb88-4369-9085-31e29e93467f"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4799) },
                    { new Guid("ed1129bf-ac04-405f-bd0a-92b1e27fd5b2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4653), true, new Guid("63618758-605f-4324-a00b-a88921a6c06c"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4780) },
                    { new Guid("f6a4e475-a0fb-4d3a-bbbd-05da947c5c9e"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4807), true, new Guid("86745b24-d321-40e6-9bed-0dd1c36a75ed"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4807) }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "PermissionId", "RoleId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0129b08e-945b-41c0-b391-c4a9de652bd9"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5246), true, new Guid("e382a1b9-5c7c-4f58-a696-5af08b1f70af"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5247) },
                    { new Guid("065ba2f4-4d21-4741-bc90-5f4dd22aa5da"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5148), true, new Guid("e580f810-852b-44f3-b99e-cfe537b667af"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5148) },
                    { new Guid("10748cdd-ed00-44fc-8961-8350382ccdfa"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5233), true, new Guid("4d79993d-f3c6-4fd1-b41a-894ae2a06ad6"), new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5233) },
                    { new Guid("10b08153-20b0-4d02-bac1-6d497e6e51eb"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5267), true, new Guid("a672fbf3-2173-45f2-9d6e-62869d4d7c3a"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5267) },
                    { new Guid("211691c6-38d7-4184-9732-b510b5aa6f10"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5100), true, new Guid("5ad051f6-05d9-40f6-bfa2-c3be514693d7"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5100) },
                    { new Guid("23a94642-64f2-4bc0-89e4-a1d4c39be7c4"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5066), true, new Guid("ed1129bf-ac04-405f-bd0a-92b1e27fd5b2"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5067) },
                    { new Guid("2f0f7487-2b00-4e21-8de8-76dfbb773550"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5044), true, new Guid("675eda32-05a8-48f3-911c-9756bf7e26f0"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5044) },
                    { new Guid("334188d7-9630-4aa0-9ad8-2688a1ec44cb"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5078), true, new Guid("ed1129bf-ac04-405f-bd0a-92b1e27fd5b2"), new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5078) },
                    { new Guid("438bfa1e-d95d-4ab5-8db5-bd496cbc754b"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5134), true, new Guid("2b5d3c10-8349-4f07-8e0d-c5787290d4a7"), new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5134) },
                    { new Guid("442a4ffc-1ece-4cb0-a866-bfbe2182380a"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5121), true, new Guid("5529ea74-398c-4cdd-9e3d-087f23ac3267"), new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5122) },
                    { new Guid("4a94560b-d848-42db-b8ea-f1d9f260ef18"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5125), true, new Guid("2b5d3c10-8349-4f07-8e0d-c5787290d4a7"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5126) },
                    { new Guid("50d948e4-574c-4e85-b64c-65ba109dbb2e"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5113), true, new Guid("5529ea74-398c-4cdd-9e3d-087f23ac3267"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5113) },
                    { new Guid("56c723e2-47f9-4364-807a-df7b43908f3b"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5220), true, new Guid("4d79993d-f3c6-4fd1-b41a-894ae2a06ad6"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5221) },
                    { new Guid("640e2e75-b497-459a-9bf1-303a2412bac0"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5040), true, new Guid("9073e03a-cd4d-47e6-9641-08c7c87ead70"), new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5040) },
                    { new Guid("75172e58-9ff4-4fc6-8cb7-262d2046e05c"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5137), true, new Guid("e86a2c33-444d-4907-8bea-6dc79d00de77"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5137) },
                    { new Guid("7c45415a-b18e-4d84-91bc-bbf37c7265eb"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5080), true, new Guid("289c4f18-46d9-4636-9696-6e3114476ec4"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5081) },
                    { new Guid("7c7ecafa-68df-41c0-9623-3e44817293f5"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5006), true, new Guid("c602c18e-78ca-4e29-81ca-ede548ee8eb0"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5007) },
                    { new Guid("7eb9179a-aa57-43f0-9932-f7222eaf0139"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5109), true, new Guid("5ad051f6-05d9-40f6-bfa2-c3be514693d7"), new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5109) },
                    { new Guid("942679eb-b801-4d70-969c-64074471e3c5"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5294), true, new Guid("229cb013-1037-4fe9-aacf-859fe6ade4da"), new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5294) },
                    { new Guid("94c24d5e-9b15-4f49-b110-d5b0f39f843f"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5145), true, new Guid("e86a2c33-444d-4907-8bea-6dc79d00de77"), new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5146) },
                    { new Guid("a67dfbec-47d3-43a5-8ab1-d47b1c8cbe7e"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5015), true, new Guid("32d70498-4c33-4fe1-8dae-f78f442b7e9d"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5016) },
                    { new Guid("ac47feb7-847c-4d00-b2e9-22b26a81aec7"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5029), true, new Guid("9073e03a-cd4d-47e6-9641-08c7c87ead70"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5029) },
                    { new Guid("bfbabe3f-f56a-453d-9fd6-e4de77cbb133"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5088), true, new Guid("289c4f18-46d9-4636-9696-6e3114476ec4"), new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5089) },
                    { new Guid("c2e422c3-b7f0-4875-b5ce-ed365bdf26b3"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5236), true, new Guid("53c37fdf-ae8d-45be-bb38-e93b6de9f834"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5236) },
                    { new Guid("c6f3cee1-2904-4973-babc-58de59d1f19a"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5063), true, new Guid("675eda32-05a8-48f3-911c-9756bf7e26f0"), new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5063) },
                    { new Guid("cc34b818-bbff-4997-b3c4-d26e2f874ffb"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4967), true, new Guid("4438bef7-348e-4932-af23-7bff6cbd961a"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(4967) },
                    { new Guid("ebb97300-c246-4758-bc6e-1a1e36112520"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5022), true, new Guid("a88d7172-2f76-43f7-aae4-6a1f68a386a1"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5023) },
                    { new Guid("eca592ba-c9bb-45db-941f-c9be36efda68"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5277), true, new Guid("229cb013-1037-4fe9-aacf-859fe6ade4da"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5277) },
                    { new Guid("f28fbfe2-b014-4540-9c36-95f1848ed66f"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5257), true, new Guid("f6a4e475-a0fb-4d3a-bbbd-05da947c5c9e"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5257) },
                    { new Guid("f8506076-b4bc-49e9-b046-d7720b82c8e5"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5091), true, new Guid("267f00e9-655a-4082-97bd-fe572031ad77"), new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"), new DateTime(2024, 9, 23, 17, 53, 51, 487, DateTimeKind.Utc).AddTicks(5091) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFriends_FriendId",
                table: "UserFriends",
                column: "FriendId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFriends");

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("0129b08e-945b-41c0-b391-c4a9de652bd9"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("065ba2f4-4d21-4741-bc90-5f4dd22aa5da"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("10748cdd-ed00-44fc-8961-8350382ccdfa"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("10b08153-20b0-4d02-bac1-6d497e6e51eb"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("211691c6-38d7-4184-9732-b510b5aa6f10"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("23a94642-64f2-4bc0-89e4-a1d4c39be7c4"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("2f0f7487-2b00-4e21-8de8-76dfbb773550"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("334188d7-9630-4aa0-9ad8-2688a1ec44cb"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("438bfa1e-d95d-4ab5-8db5-bd496cbc754b"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("442a4ffc-1ece-4cb0-a866-bfbe2182380a"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("4a94560b-d848-42db-b8ea-f1d9f260ef18"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("50d948e4-574c-4e85-b64c-65ba109dbb2e"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("56c723e2-47f9-4364-807a-df7b43908f3b"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("640e2e75-b497-459a-9bf1-303a2412bac0"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("75172e58-9ff4-4fc6-8cb7-262d2046e05c"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("7c45415a-b18e-4d84-91bc-bbf37c7265eb"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("7c7ecafa-68df-41c0-9623-3e44817293f5"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("7eb9179a-aa57-43f0-9932-f7222eaf0139"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("942679eb-b801-4d70-969c-64074471e3c5"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("94c24d5e-9b15-4f49-b110-d5b0f39f843f"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("a67dfbec-47d3-43a5-8ab1-d47b1c8cbe7e"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("ac47feb7-847c-4d00-b2e9-22b26a81aec7"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("bfbabe3f-f56a-453d-9fd6-e4de77cbb133"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("c2e422c3-b7f0-4875-b5ce-ed365bdf26b3"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("c6f3cee1-2904-4973-babc-58de59d1f19a"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("cc34b818-bbff-4997-b3c4-d26e2f874ffb"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("ebb97300-c246-4758-bc6e-1a1e36112520"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("eca592ba-c9bb-45db-941f-c9be36efda68"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("f28fbfe2-b014-4540-9c36-95f1848ed66f"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("f8506076-b4bc-49e9-b046-d7720b82c8e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec94bf46-2537-4514-8791-5a2a95b1fcea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("229cb013-1037-4fe9-aacf-859fe6ade4da"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("267f00e9-655a-4082-97bd-fe572031ad77"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("289c4f18-46d9-4636-9696-6e3114476ec4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2b5d3c10-8349-4f07-8e0d-c5787290d4a7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("32d70498-4c33-4fe1-8dae-f78f442b7e9d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4438bef7-348e-4932-af23-7bff6cbd961a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4d79993d-f3c6-4fd1-b41a-894ae2a06ad6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("53c37fdf-ae8d-45be-bb38-e93b6de9f834"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5529ea74-398c-4cdd-9e3d-087f23ac3267"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5ad051f6-05d9-40f6-bfa2-c3be514693d7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("675eda32-05a8-48f3-911c-9756bf7e26f0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9073e03a-cd4d-47e6-9641-08c7c87ead70"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a672fbf3-2173-45f2-9d6e-62869d4d7c3a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a88d7172-2f76-43f7-aae4-6a1f68a386a1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c602c18e-78ca-4e29-81ca-ede548ee8eb0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e382a1b9-5c7c-4f58-a696-5af08b1f70af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e580f810-852b-44f3-b99e-cfe537b667af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e86a2c33-444d-4907-8bea-6dc79d00de77"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed1129bf-ac04-405f-bd0a-92b1e27fd5b2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f6a4e475-a0fb-4d3a-bbbd-05da947c5c9e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1e743715-89d9-4170-ad5b-7577040c23bc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2246f905-b946-4e69-8a0f-e7c0d34408a2"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("325840f6-bb88-4369-9085-31e29e93467f"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("34362d85-5f3c-411e-a39e-12c13bbfec83"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("4fa09d33-f495-4ebc-9816-6ef4c1a0a17c"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("61cdd6d5-e1d2-44ab-9afa-4da446abcc2e"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("63618758-605f-4324-a00b-a88921a6c06c"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("64ebfe08-a224-4b87-9a7e-17c7fe2fe4e0"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("6aa109d1-8daf-4820-aace-d0681312496b"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("7042ef50-5f78-4952-bac5-7731090f29dc"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("71928e63-9f4c-45dc-8ebf-94ce99efba04"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("86745b24-d321-40e6-9bed-0dd1c36a75ed"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("abc47213-15f9-4803-916d-4df573367eca"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("ae152cf3-029d-4f83-8aef-5f87ee7013ec"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("aebf73a1-7403-451c-804c-e7294b4260fa"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("b26a486f-5869-4423-9e86-a6544e6e2e5f"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("ddbb18d7-0a32-45cb-9a5c-5c0cb820296d"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("dec8d6a6-7028-41fe-a075-af1d9be343cd"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("dfa4d63e-b728-4a90-adfa-af3ad4efffeb"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("ecd654b4-0a2e-45da-896d-610da6fcc5cc"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("f160cf3c-2953-4553-9253-a8743c4a1114"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("f2a91eeb-d46e-49bb-8baa-12b913a46d96"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("1a4f35f1-cceb-4aa9-b448-5ed823df4a9d"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("56b186d3-1f07-4598-ae23-712b1a5b9fe2"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("63c4e40e-bb10-469a-83a5-0111e6bae0be"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("aed8b54e-4cc3-4dd6-b68a-1bfd39fca1fd"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("b789df21-37e0-42f2-b4e4-f17540b50c2c"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("0ec17b23-c4d4-4a61-ba31-4b93db9b0823"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("1b7bf363-2a53-4771-92e7-27036d403473"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("ac11bc95-bf0a-4de8-9312-0b50ab30a4e9"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("f493c1c3-917d-49fd-914d-42d3f0319f7b"));

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0db32b7a-fa94-4631-938f-9c0a7aab0ad5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9706), true, "Update", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9706) },
                    { new Guid("1548a1de-e522-4af1-859b-4e461af076b1"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9714), true, "ChangeStatus", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9714) },
                    { new Guid("53823cac-e405-45a7-a0fa-c5d117a08f0e"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9708), true, "Delete", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9708) },
                    { new Guid("a955b6ce-7a2e-45eb-a57d-c10b14f7c7ae"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9704), true, "Read", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9705) },
                    { new Guid("e66aa05c-4628-4fcb-afbb-217e2c3f0e8b"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9702), true, "Create", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9703) }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0dcbe3fb-a8ea-4a2b-ac4e-512bd7a6d9cc"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9632), true, "Users", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9633) },
                    { new Guid("12f626da-7615-441e-8276-dfe9d958d67c"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9647), true, "Moments", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9647) },
                    { new Guid("6a465d4d-2c2a-46bc-9972-d3052fabc2c6"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9649), true, "Albums", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9649) },
                    { new Guid("be00908e-b067-411a-911b-9d0864c639f5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9650), true, "Resources", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9650) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(8336), true, "User", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(8336) },
                    { new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(8331), true, "Admin", new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(8334) }
                });

            migrationBuilder.InsertData(
                table: "ModuleActions",
                columns: new[] { "Id", "ActionId", "CreatedAt", "IsActive", "ModuleId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("126d27af-566b-4549-af30-ce00f2c6bc2c"), new Guid("0db32b7a-fa94-4631-938f-9c0a7aab0ad5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9756), true, new Guid("0dcbe3fb-a8ea-4a2b-ac4e-512bd7a6d9cc"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9757) },
                    { new Guid("1cfca5cd-5a94-48d3-a190-de67d90b7f09"), new Guid("1548a1de-e522-4af1-859b-4e461af076b1"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9786), true, new Guid("be00908e-b067-411a-911b-9d0864c639f5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9786) },
                    { new Guid("1ddd034c-aa05-4c7c-897a-c8ffb728718b"), new Guid("53823cac-e405-45a7-a0fa-c5d117a08f0e"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9775), true, new Guid("6a465d4d-2c2a-46bc-9972-d3052fabc2c6"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9776) },
                    { new Guid("1e70d0dc-fff2-4aef-8ba8-ab4f84f41681"), new Guid("1548a1de-e522-4af1-859b-4e461af076b1"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9778), true, new Guid("6a465d4d-2c2a-46bc-9972-d3052fabc2c6"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9779) },
                    { new Guid("3889a17f-b06d-4b02-ac4b-b43f72e331e8"), new Guid("0db32b7a-fa94-4631-938f-9c0a7aab0ad5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9774), true, new Guid("6a465d4d-2c2a-46bc-9972-d3052fabc2c6"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9775) },
                    { new Guid("3a328088-d45e-4223-af67-e1bbbed96102"), new Guid("a955b6ce-7a2e-45eb-a57d-c10b14f7c7ae"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9766), true, new Guid("12f626da-7615-441e-8276-dfe9d958d67c"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9766) },
                    { new Guid("3b395a7f-35be-46d5-9aa2-3a8b80786df2"), new Guid("e66aa05c-4628-4fcb-afbb-217e2c3f0e8b"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9762), true, new Guid("12f626da-7615-441e-8276-dfe9d958d67c"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9762) },
                    { new Guid("47d20fab-d459-430f-a377-72f9daf6aa81"), new Guid("e66aa05c-4628-4fcb-afbb-217e2c3f0e8b"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9772), true, new Guid("6a465d4d-2c2a-46bc-9972-d3052fabc2c6"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9772) },
                    { new Guid("4de112c6-dbd8-4453-9714-b96cc8bf4395"), new Guid("1548a1de-e522-4af1-859b-4e461af076b1"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9759), true, new Guid("0dcbe3fb-a8ea-4a2b-ac4e-512bd7a6d9cc"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9759) },
                    { new Guid("597d4e64-7f26-436f-92c7-62982dfa27b3"), new Guid("a955b6ce-7a2e-45eb-a57d-c10b14f7c7ae"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9773), true, new Guid("6a465d4d-2c2a-46bc-9972-d3052fabc2c6"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9773) },
                    { new Guid("5a45b57c-ba1d-41ae-b880-066060de4b60"), new Guid("53823cac-e405-45a7-a0fa-c5d117a08f0e"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9784), true, new Guid("be00908e-b067-411a-911b-9d0864c639f5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9785) },
                    { new Guid("66d8ae98-a951-42ab-bd01-a3dcc848179f"), new Guid("a955b6ce-7a2e-45eb-a57d-c10b14f7c7ae"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9781), true, new Guid("be00908e-b067-411a-911b-9d0864c639f5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9781) },
                    { new Guid("7760eea6-fae4-4529-ac17-4b11977c1551"), new Guid("1548a1de-e522-4af1-859b-4e461af076b1"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9770), true, new Guid("12f626da-7615-441e-8276-dfe9d958d67c"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9771) },
                    { new Guid("898dfaf9-92a6-4448-aed5-6a93bdc71a93"), new Guid("e66aa05c-4628-4fcb-afbb-217e2c3f0e8b"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9780), true, new Guid("be00908e-b067-411a-911b-9d0864c639f5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9780) },
                    { new Guid("a0232e7d-4501-4d70-b284-f90d748fadf5"), new Guid("53823cac-e405-45a7-a0fa-c5d117a08f0e"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9758), true, new Guid("0dcbe3fb-a8ea-4a2b-ac4e-512bd7a6d9cc"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9758) },
                    { new Guid("b10b7290-03fe-401e-9a33-9a725a97aa82"), new Guid("53823cac-e405-45a7-a0fa-c5d117a08f0e"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9768), true, new Guid("12f626da-7615-441e-8276-dfe9d958d67c"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9769) },
                    { new Guid("b1524a69-cdb9-4710-807b-884c2d14ba4c"), new Guid("a955b6ce-7a2e-45eb-a57d-c10b14f7c7ae"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9755), true, new Guid("0dcbe3fb-a8ea-4a2b-ac4e-512bd7a6d9cc"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9755) },
                    { new Guid("ba6f6592-ef99-4247-9483-6ecfc6403972"), new Guid("0db32b7a-fa94-4631-938f-9c0a7aab0ad5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9767), true, new Guid("12f626da-7615-441e-8276-dfe9d958d67c"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9767) },
                    { new Guid("c3ff5e98-fb19-4e7d-ac74-ea77da425028"), new Guid("e66aa05c-4628-4fcb-afbb-217e2c3f0e8b"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9750), true, new Guid("0dcbe3fb-a8ea-4a2b-ac4e-512bd7a6d9cc"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9750) },
                    { new Guid("cd82a094-9c1d-4ab6-a319-3715eede1055"), new Guid("0db32b7a-fa94-4631-938f-9c0a7aab0ad5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9783), true, new Guid("be00908e-b067-411a-911b-9d0864c639f5"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(9783) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("9e04fd15-75e1-4ebf-95e3-73ba7ceb52af"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(8528), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 993, DateTimeKind.Utc).AddTicks(8528) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "ModuleActionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1eb405af-92ab-4511-8286-9147cb6caadd"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(186), true, new Guid("ba6f6592-ef99-4247-9483-6ecfc6403972"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(186) },
                    { new Guid("2621a768-e7b4-414a-a57b-984127be5383"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(173), true, new Guid("b1524a69-cdb9-4710-807b-884c2d14ba4c"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(174) },
                    { new Guid("26c8bfd5-001c-4590-aa44-3f842e5d53d1"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(181), true, new Guid("4de112c6-dbd8-4453-9714-b96cc8bf4395"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(182) },
                    { new Guid("2e7c1af5-10af-4299-b14b-9d0232e5406b"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(195), true, new Guid("1ddd034c-aa05-4c7c-897a-c8ffb728718b"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(196) },
                    { new Guid("4399b19f-3d81-4d6c-8bb5-dc1bd3da48ce"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(198), true, new Guid("898dfaf9-92a6-4448-aed5-6a93bdc71a93"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(199) },
                    { new Guid("44144e79-c67b-4c8c-b238-f405b622a4b4"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(197), true, new Guid("1e70d0dc-fff2-4aef-8ba8-ab4f84f41681"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(197) },
                    { new Guid("45c0f253-4027-443b-9e54-f40cc8abff30"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(184), true, new Guid("3a328088-d45e-4223-af67-e1bbbed96102"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(185) },
                    { new Guid("5ad92960-edb7-4fa0-a988-c903bd8990b3"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(190), true, new Guid("47d20fab-d459-430f-a377-72f9daf6aa81"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(190) },
                    { new Guid("6aa19874-1db9-4ebb-83aa-860226827d6b"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(167), true, new Guid("c3ff5e98-fb19-4e7d-ac74-ea77da425028"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(167) },
                    { new Guid("78b54657-cc00-4e24-a2f0-442f1212683c"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(183), true, new Guid("3b395a7f-35be-46d5-9aa2-3a8b80786df2"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(183) },
                    { new Guid("7c1435ae-8302-4f94-a4ca-4805e6e86d43"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(205), true, new Guid("1cfca5cd-5a94-48d3-a190-de67d90b7f09"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(205) },
                    { new Guid("8d79725f-7b37-4111-83fc-ac49d5902856"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(180), true, new Guid("a0232e7d-4501-4d70-b284-f90d748fadf5"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(180) },
                    { new Guid("aa62d662-d418-49c6-9355-e8e0756619f9"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(193), true, new Guid("597d4e64-7f26-436f-92c7-62982dfa27b3"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(193) },
                    { new Guid("bb48d020-203a-41fb-9767-4c0f00f66760"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(175), true, new Guid("126d27af-566b-4549-af30-ce00f2c6bc2c"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(175) },
                    { new Guid("c1d9a350-753d-4f13-b1b0-674bbb34f127"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(194), true, new Guid("3889a17f-b06d-4b02-ac4b-b43f72e331e8"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(194) },
                    { new Guid("c2a3ec14-1084-4986-a9df-38b0662d3988"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(200), true, new Guid("66d8ae98-a951-42ab-bd01-a3dcc848179f"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(200) },
                    { new Guid("ca2287e6-d1ff-4abe-b513-2d5ee6686363"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(187), true, new Guid("b10b7290-03fe-401e-9a33-9a725a97aa82"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(187) },
                    { new Guid("dfa65478-2ae3-433a-9279-d88e4c593a5d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(188), true, new Guid("7760eea6-fae4-4529-ac17-4b11977c1551"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(189) },
                    { new Guid("e520bae3-c34c-4719-ad8c-74ec3a1c8d44"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(202), true, new Guid("5a45b57c-ba1d-41ae-b880-066060de4b60"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(202) },
                    { new Guid("e845915d-b751-4e41-b62e-8c08db34c5bf"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(201), true, new Guid("cd82a094-9c1d-4ab6-a319-3715eede1055"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(201) }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "PermissionId", "RoleId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02514686-7daa-4276-b30a-949bd0d64cb5"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(780), true, new Guid("e845915d-b751-4e41-b62e-8c08db34c5bf"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(780) },
                    { new Guid("026cadb6-3d55-4db8-949a-0b9bbbaa4a63"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(377), true, new Guid("1eb405af-92ab-4511-8286-9147cb6caadd"), new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(377) },
                    { new Guid("1997f47b-2979-49af-a132-ddab30593d60"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(327), true, new Guid("8d79725f-7b37-4111-83fc-ac49d5902856"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(327) },
                    { new Guid("1a38b735-6392-40c5-9107-584e24a0f849"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(315), true, new Guid("2621a768-e7b4-414a-a57b-984127be5383"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(316) },
                    { new Guid("20039998-7fab-4f7c-835b-5ee6ac4b21d6"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(358), true, new Guid("78b54657-cc00-4e24-a2f0-442f1212683c"), new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(358) },
                    { new Guid("209f7418-b6ac-4be4-ae6b-e64aa9bf7828"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(344), true, new Guid("78b54657-cc00-4e24-a2f0-442f1212683c"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(344) },
                    { new Guid("2c303653-0069-4a26-9c42-f188ef0f18da"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(788), true, new Guid("e520bae3-c34c-4719-ad8c-74ec3a1c8d44"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(788) },
                    { new Guid("3a86c3f3-dd76-44b1-8c00-de2f5fcca13d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(773), true, new Guid("c2a3ec14-1084-4986-a9df-38b0662d3988"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(773) },
                    { new Guid("42d63ac8-1eab-4412-8dfd-731a9944edb3"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(796), true, new Guid("7c1435ae-8302-4f94-a4ca-4805e6e86d43"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(796) },
                    { new Guid("43382802-75fa-43be-a72f-95e724989a7f"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(371), true, new Guid("1eb405af-92ab-4511-8286-9147cb6caadd"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(371) },
                    { new Guid("442e0dc4-eb8b-41d1-8b1a-2c4b67d1b8d0"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(765), true, new Guid("4399b19f-3d81-4d6c-8bb5-dc1bd3da48ce"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(765) },
                    { new Guid("596d5ef4-a60f-44ee-9fe5-44beaacdce8e"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(705), true, new Guid("dfa65478-2ae3-433a-9279-d88e4c593a5d"), new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(705) },
                    { new Guid("6166af2a-a810-4eae-a178-5ac43c19a842"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(283), true, new Guid("6aa19874-1db9-4ebb-83aa-860226827d6b"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(283) },
                    { new Guid("750f03e3-51d3-498a-acaf-4dcebd58317a"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(753), true, new Guid("44144e79-c67b-4c8c-b238-f405b622a4b4"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(753) },
                    { new Guid("87a685fa-ed0e-4b9b-96b5-1ddc1eedafb5"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(369), true, new Guid("45c0f253-4027-443b-9e54-f40cc8abff30"), new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(369) },
                    { new Guid("8803eac0-27ee-46e4-8327-924803ae2123"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(744), true, new Guid("2e7c1af5-10af-4299-b14b-9d0232e5406b"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(744) },
                    { new Guid("8b02b1d4-5c78-44ab-bfd0-8853092f99ca"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(360), true, new Guid("45c0f253-4027-443b-9e54-f40cc8abff30"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(361) },
                    { new Guid("9045e8d9-54cf-4fb0-ba11-30e651c3f312"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(719), true, new Guid("5ad92960-edb7-4fa0-a988-c903bd8990b3"), new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(719) },
                    { new Guid("915556db-cc4c-4593-9431-5890875807c0"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(809), true, new Guid("7c1435ae-8302-4f94-a4ca-4805e6e86d43"), new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(809) },
                    { new Guid("9a9c5ef1-e9ea-45fe-aef6-c74adacda472"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(742), true, new Guid("c1d9a350-753d-4f13-b1b0-674bbb34f127"), new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(742) },
                    { new Guid("9c9c296f-0ab0-4a15-a238-4b3ece52f9da"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(733), true, new Guid("aa62d662-d418-49c6-9355-e8e0756619f9"), new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(733) },
                    { new Guid("a5cb346a-d3d4-40a8-a152-affb02bae7f3"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(680), true, new Guid("dfa65478-2ae3-433a-9279-d88e4c593a5d"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(681) },
                    { new Guid("a8887fef-858b-4126-84a4-9e14c705dac6"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(379), true, new Guid("ca2287e6-d1ff-4abe-b513-2d5ee6686363"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(379) },
                    { new Guid("a98f91ae-1b83-46a3-b558-4520114dcfd3"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(333), true, new Guid("26c8bfd5-001c-4590-aa44-3f842e5d53d1"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(333) },
                    { new Guid("b3502469-5b16-4cad-902a-4f85718d1027"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(341), true, new Guid("26c8bfd5-001c-4590-aa44-3f842e5d53d1"), new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(342) },
                    { new Guid("b6943a35-5717-4730-879d-d0c109e27467"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(735), true, new Guid("c1d9a350-753d-4f13-b1b0-674bbb34f127"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(735) },
                    { new Guid("cc9b0880-b249-43aa-9e6c-a56b93e9d0fd"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(726), true, new Guid("aa62d662-d418-49c6-9355-e8e0756619f9"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(726) },
                    { new Guid("d32549cc-441b-4bf2-8fe6-ce93239c2bc6"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(763), true, new Guid("44144e79-c67b-4c8c-b238-f405b622a4b4"), new Guid("4c059b07-b5d3-4132-8114-fc3440a7710d"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(763) },
                    { new Guid("e0423ddf-f86d-4f32-88bf-f2359b8f47fc"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(712), true, new Guid("5ad92960-edb7-4fa0-a988-c903bd8990b3"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(712) },
                    { new Guid("fda9ac36-4a2f-45a7-ba24-a2436d1900b3"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(322), true, new Guid("bb48d020-203a-41fb-9767-4c0f00f66760"), new Guid("ea542f89-7b2a-450e-ada6-fb2d9c77d891"), new DateTime(2024, 8, 31, 21, 14, 32, 994, DateTimeKind.Utc).AddTicks(322) }
                });
        }
    }
}
