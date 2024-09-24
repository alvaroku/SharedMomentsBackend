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

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "UserFriends",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0b469237-ddce-41d5-9224-1ec1705d45d3"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7418), true, "Read", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7418) },
                    { new Guid("113cd90f-1d17-4dd2-adc8-2b9c6fe9a46a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7422), true, "Delete", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7422) },
                    { new Guid("697df0c9-6c3e-4b5b-8033-af7ac37538ce"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7420), true, "Update", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7420) },
                    { new Guid("b4cf3915-8d94-475e-91bb-74610079f158"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7404), true, "Create", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7404) },
                    { new Guid("fe63ace1-d61b-4ef6-90e2-13a8df8b8f9f"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7424), true, "ChangeStatus", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7424) }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("460d20b1-9e96-47a7-bfe2-eaefa1d70510"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7357), true, "Users", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7357) },
                    { new Guid("57a99491-9bd6-496d-a0d3-0b40b3a72f63"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7364), true, "Albums", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7365) },
                    { new Guid("5d45d4b2-586e-4aa3-99e1-61f99e2ecaff"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7362), true, "Moments", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7362) },
                    { new Guid("82f1df67-bbb8-4524-8195-c999dbce5e79"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7366), true, "Resources", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7367) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(6225), true, "User", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(6225) },
                    { new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(6217), true, "Admin", new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(6221) }
                });

            migrationBuilder.InsertData(
                table: "ModuleActions",
                columns: new[] { "Id", "ActionId", "CreatedAt", "IsActive", "ModuleId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("065ca581-25c2-4d6d-9d60-0f14aaccbf81"), new Guid("697df0c9-6c3e-4b5b-8033-af7ac37538ce"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7473), true, new Guid("5d45d4b2-586e-4aa3-99e1-61f99e2ecaff"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7473) },
                    { new Guid("08b6ae51-589a-4a28-8f3a-9e1620cc4ea3"), new Guid("113cd90f-1d17-4dd2-adc8-2b9c6fe9a46a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7491), true, new Guid("82f1df67-bbb8-4524-8195-c999dbce5e79"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7491) },
                    { new Guid("08ed0564-a9fc-4bb9-bc60-7004bdd3112a"), new Guid("fe63ace1-d61b-4ef6-90e2-13a8df8b8f9f"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7476), true, new Guid("5d45d4b2-586e-4aa3-99e1-61f99e2ecaff"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7477) },
                    { new Guid("30cf1c08-78a5-4c23-a3de-68ae7a129a58"), new Guid("113cd90f-1d17-4dd2-adc8-2b9c6fe9a46a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7474), true, new Guid("5d45d4b2-586e-4aa3-99e1-61f99e2ecaff"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7474) },
                    { new Guid("3b2b40c8-f0ca-42e1-ba2d-ea9ffa128d42"), new Guid("fe63ace1-d61b-4ef6-90e2-13a8df8b8f9f"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7467), true, new Guid("460d20b1-9e96-47a7-bfe2-eaefa1d70510"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7467) },
                    { new Guid("561366ab-3896-4754-99e7-ca7665ddc2d6"), new Guid("0b469237-ddce-41d5-9224-1ec1705d45d3"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7488), true, new Guid("82f1df67-bbb8-4524-8195-c999dbce5e79"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7488) },
                    { new Guid("5b807c70-0391-438a-bd70-ee768e6e7dce"), new Guid("fe63ace1-d61b-4ef6-90e2-13a8df8b8f9f"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7494), true, new Guid("82f1df67-bbb8-4524-8195-c999dbce5e79"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7495) },
                    { new Guid("7720e833-e65e-42d5-b36d-8a57a616cc7b"), new Guid("b4cf3915-8d94-475e-91bb-74610079f158"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7486), true, new Guid("82f1df67-bbb8-4524-8195-c999dbce5e79"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7487) },
                    { new Guid("7c332908-0e1a-4d3f-8df9-3f03d35f9924"), new Guid("697df0c9-6c3e-4b5b-8033-af7ac37538ce"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7462), true, new Guid("460d20b1-9e96-47a7-bfe2-eaefa1d70510"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7462) },
                    { new Guid("877f4c3b-7492-406f-a755-36b49ac1264b"), new Guid("113cd90f-1d17-4dd2-adc8-2b9c6fe9a46a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7465), true, new Guid("460d20b1-9e96-47a7-bfe2-eaefa1d70510"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7465) },
                    { new Guid("87ff39dd-7f8d-4aa7-91f0-83ec7e83b39f"), new Guid("697df0c9-6c3e-4b5b-8033-af7ac37538ce"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7490), true, new Guid("82f1df67-bbb8-4524-8195-c999dbce5e79"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7490) },
                    { new Guid("89cd8602-4b9d-4730-99ec-b97ef2877020"), new Guid("b4cf3915-8d94-475e-91bb-74610079f158"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7470), true, new Guid("5d45d4b2-586e-4aa3-99e1-61f99e2ecaff"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7470) },
                    { new Guid("8ea7a9e8-bdcf-4d1f-9d7a-9aa87f07c3e5"), new Guid("113cd90f-1d17-4dd2-adc8-2b9c6fe9a46a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7483), true, new Guid("57a99491-9bd6-496d-a0d3-0b40b3a72f63"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7484) },
                    { new Guid("8feb61c2-acc0-456b-933e-bdb5bde3f659"), new Guid("b4cf3915-8d94-475e-91bb-74610079f158"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7455), true, new Guid("460d20b1-9e96-47a7-bfe2-eaefa1d70510"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7456) },
                    { new Guid("b105cf60-c1b4-467a-bb1e-8e88f288e5ca"), new Guid("fe63ace1-d61b-4ef6-90e2-13a8df8b8f9f"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7485), true, new Guid("57a99491-9bd6-496d-a0d3-0b40b3a72f63"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7485) },
                    { new Guid("c6ee952c-c968-463f-a07f-440f377e0165"), new Guid("0b469237-ddce-41d5-9224-1ec1705d45d3"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7481), true, new Guid("57a99491-9bd6-496d-a0d3-0b40b3a72f63"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7481) },
                    { new Guid("c79e063a-3914-404b-810b-c2bd6f53fa88"), new Guid("697df0c9-6c3e-4b5b-8033-af7ac37538ce"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7482), true, new Guid("57a99491-9bd6-496d-a0d3-0b40b3a72f63"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7482) },
                    { new Guid("dfd0a636-36f8-46d1-9340-dc3874dce92b"), new Guid("0b469237-ddce-41d5-9224-1ec1705d45d3"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7460), true, new Guid("460d20b1-9e96-47a7-bfe2-eaefa1d70510"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7460) },
                    { new Guid("e1c6f5c6-d92e-40a6-ae29-5880b851c45e"), new Guid("0b469237-ddce-41d5-9224-1ec1705d45d3"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7471), true, new Guid("5d45d4b2-586e-4aa3-99e1-61f99e2ecaff"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7472) },
                    { new Guid("ea289d70-de03-49ed-b2cb-14baf210c483"), new Guid("b4cf3915-8d94-475e-91bb-74610079f158"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7478), true, new Guid("57a99491-9bd6-496d-a0d3-0b40b3a72f63"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7478) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("e975e2c1-1422-4ff3-882f-b87db827eb21"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(6355), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "ModuleActionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2190f638-8f09-41e0-9e1c-cca6f7f09e28"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7575), true, new Guid("08ed0564-a9fc-4bb9-bc60-7004bdd3112a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7575) },
                    { new Guid("2811558f-01ea-4a81-aa9f-64785fa2cb23"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7570), true, new Guid("065ca581-25c2-4d6d-9d60-0f14aaccbf81"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7571) },
                    { new Guid("329825f0-c10b-4c87-88f0-cb5daf548a2c"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7569), true, new Guid("e1c6f5c6-d92e-40a6-ae29-5880b851c45e"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7569) },
                    { new Guid("3481191c-8104-4b09-be4c-230013a7c07b"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7578), true, new Guid("c6ee952c-c968-463f-a07f-440f377e0165"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7578) },
                    { new Guid("402d4b1a-08c0-402e-bf3d-3970be79f627"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7562), true, new Guid("dfd0a636-36f8-46d1-9340-dc3874dce92b"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7562) },
                    { new Guid("4f5cf71f-9698-4fcd-ac27-0a7007b00a27"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7559), true, new Guid("8feb61c2-acc0-456b-933e-bdb5bde3f659"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7559) },
                    { new Guid("571beb8e-073f-43d5-b237-858921750fa0"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7583), true, new Guid("7720e833-e65e-42d5-b36d-8a57a616cc7b"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7583) },
                    { new Guid("776004f5-98f1-492c-a28c-0d424d63a0c9"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7576), true, new Guid("ea289d70-de03-49ed-b2cb-14baf210c483"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7577) },
                    { new Guid("79b711b2-27e9-4d9d-ae73-c4f2cd0faab6"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7620), true, new Guid("5b807c70-0391-438a-bd70-ee768e6e7dce"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7620) },
                    { new Guid("84d0d068-28c7-4331-822c-7bd46596c44e"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7568), true, new Guid("89cd8602-4b9d-4730-99ec-b97ef2877020"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7568) },
                    { new Guid("86729632-d855-4430-81f5-2a33d16158b4"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7580), true, new Guid("8ea7a9e8-bdcf-4d1f-9d7a-9aa87f07c3e5"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7580) },
                    { new Guid("91a50df3-de8d-47d1-b7f7-125ec4f6427d"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7586), true, new Guid("561366ab-3896-4754-99e7-ca7665ddc2d6"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7586) },
                    { new Guid("963096d9-71a4-404b-873e-79f3e7cbf38c"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7617), true, new Guid("87ff39dd-7f8d-4aa7-91f0-83ec7e83b39f"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7617) },
                    { new Guid("9cbe9810-4345-48c4-91dc-ee245323fb18"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7566), true, new Guid("3b2b40c8-f0ca-42e1-ba2d-ea9ffa128d42"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7567) },
                    { new Guid("a7e28263-532e-4b39-b64a-77a6d6ec2dac"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7618), true, new Guid("08b6ae51-589a-4a28-8f3a-9e1620cc4ea3"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7619) },
                    { new Guid("bf1f1bb8-b0b8-4479-a10d-4b75738b3cde"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7574), true, new Guid("30cf1c08-78a5-4c23-a3de-68ae7a129a58"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7574) },
                    { new Guid("e0d426b3-6b4d-458f-ae4e-a730c2ef7408"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7565), true, new Guid("877f4c3b-7492-406f-a755-36b49ac1264b"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7565) },
                    { new Guid("e2216ccb-43b8-44dc-b7d8-b7fba6ec85ee"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7581), true, new Guid("b105cf60-c1b4-467a-bb1e-8e88f288e5ca"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7582) },
                    { new Guid("ee095c4b-eeb5-413a-8578-b673bff92883"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7563), true, new Guid("7c332908-0e1a-4d3f-8df9-3f03d35f9924"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7564) },
                    { new Guid("f26327d0-6265-42da-b3b1-9194f43e7752"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7579), true, new Guid("c79e063a-3914-404b-810b-c2bd6f53fa88"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7579) }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatedAt", "IsActive", "PermissionId", "RoleId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("026a35af-167e-45ea-bc11-264738dc93f0"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7730), true, new Guid("402d4b1a-08c0-402e-bf3d-3970be79f627"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7730) },
                    { new Guid("02fa69dc-752b-44a9-b447-22dfb1d41db8"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7695), true, new Guid("4f5cf71f-9698-4fcd-ac27-0a7007b00a27"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7696) },
                    { new Guid("0ae33f65-c437-487f-a5ce-aa7068bb76ab"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7829), true, new Guid("776004f5-98f1-492c-a28c-0d424d63a0c9"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7829) },
                    { new Guid("0b41a382-7003-4fb8-abfd-939d030f7b67"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7889), true, new Guid("86729632-d855-4430-81f5-2a33d16158b4"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7890) },
                    { new Guid("26a8681c-9117-47d2-bc70-c6087b79a26a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7847), true, new Guid("3481191c-8104-4b09-be4c-230013a7c07b"), new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7847) },
                    { new Guid("2e91d916-dc9a-4722-90b6-c1d84d5a497d"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7827), true, new Guid("2190f638-8f09-41e0-9e1c-cca6f7f09e28"), new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7827) },
                    { new Guid("2f78dca6-b1e9-4e67-88e9-edb198348c96"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7953), true, new Guid("79b711b2-27e9-4d9d-ae73-c4f2cd0faab6"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7953) },
                    { new Guid("3bcbb11a-a04e-4a20-bc30-63b463577dac"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7942), true, new Guid("a7e28263-532e-4b39-b64a-77a6d6ec2dac"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7942) },
                    { new Guid("3be3020f-6a1d-4424-9dfe-cd4641fe4f1c"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7752), true, new Guid("9cbe9810-4345-48c4-91dc-ee245323fb18"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7752) },
                    { new Guid("47b728ee-0db0-448d-bc3d-23939a217a11"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7909), true, new Guid("e2216ccb-43b8-44dc-b7d8-b7fba6ec85ee"), new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7909) },
                    { new Guid("4bb38e57-460d-40e5-a2c7-5ed1911a3ba8"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7921), true, new Guid("91a50df3-de8d-47d1-b7f7-125ec4f6427d"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7921) },
                    { new Guid("4f5b73a4-7172-4617-9b8e-014bf7bc77a2"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7911), true, new Guid("571beb8e-073f-43d5-b237-858921750fa0"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7912) },
                    { new Guid("510452ad-bf08-432b-a096-0e7ea41e444e"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7744), true, new Guid("e0d426b3-6b4d-458f-ae4e-a730c2ef7408"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7744) },
                    { new Guid("6efa0670-4c1e-47b1-a1eb-3c150b1388ed"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7738), true, new Guid("ee095c4b-eeb5-413a-8578-b673bff92883"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7738) },
                    { new Guid("6f5f6018-879d-445f-b0f7-d98057f1d8f1"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7805), true, new Guid("2811558f-01ea-4a81-aa9f-64785fa2cb23"), new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7805) },
                    { new Guid("70fa7318-651a-4b7d-bace-9d666377a7ed"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7765), true, new Guid("9cbe9810-4345-48c4-91dc-ee245323fb18"), new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7765) },
                    { new Guid("79f5a5af-888f-47f7-b10f-617c6d5f3081"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7768), true, new Guid("84d0d068-28c7-4331-822c-7bd46596c44e"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7768) },
                    { new Guid("7cfc7a3a-10a4-4c26-878e-49c841e34122"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7797), true, new Guid("2811558f-01ea-4a81-aa9f-64785fa2cb23"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7798) },
                    { new Guid("92227a14-e665-4507-9661-d872b0d9d20b"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7968), true, new Guid("79b711b2-27e9-4d9d-ae73-c4f2cd0faab6"), new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7969) },
                    { new Guid("97ebae1c-ffbd-4334-8408-0795460049fa"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7810), true, new Guid("bf1f1bb8-b0b8-4479-a10d-4b75738b3cde"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7810) },
                    { new Guid("9e1bbe86-87bc-4843-a5b1-fbee794ceb5c"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7900), true, new Guid("e2216ccb-43b8-44dc-b7d8-b7fba6ec85ee"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7900) },
                    { new Guid("a246c2a0-10e8-4c6d-991e-6ff11a605902"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7839), true, new Guid("3481191c-8104-4b09-be4c-230013a7c07b"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7840) },
                    { new Guid("a310060d-ffc0-4401-90ec-1600f257793e"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7795), true, new Guid("329825f0-c10b-4c87-88f0-cb5daf548a2c"), new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7796) },
                    { new Guid("af379af9-49c7-43d5-bfa6-67d017a1a672"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7932), true, new Guid("963096d9-71a4-404b-873e-79f3e7cbf38c"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7933) },
                    { new Guid("c33cdb57-b8cc-4d8e-ae01-db572532a537"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7786), true, new Guid("329825f0-c10b-4c87-88f0-cb5daf548a2c"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7786) },
                    { new Guid("d77ba6fd-3f07-4dee-bf2b-aaedfd49a744"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7886), true, new Guid("f26327d0-6265-42da-b3b1-9194f43e7752"), new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7887) },
                    { new Guid("dbb1d913-c270-473f-857b-a4410c5b822e"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7819), true, new Guid("2190f638-8f09-41e0-9e1c-cca6f7f09e28"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7819) },
                    { new Guid("edec0caa-2b04-4ef9-8004-03ec9002d8f2"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7782), true, new Guid("84d0d068-28c7-4331-822c-7bd46596c44e"), new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7783) },
                    { new Guid("f2f2d544-281f-4482-b320-0d7fbdc91920"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7849), true, new Guid("f26327d0-6265-42da-b3b1-9194f43e7752"), new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7850) },
                    { new Guid("f7f7ca35-a042-4ee3-ad05-fa16372392f0"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7836), true, new Guid("776004f5-98f1-492c-a28c-0d424d63a0c9"), new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"), new DateTime(2024, 9, 24, 14, 10, 47, 741, DateTimeKind.Utc).AddTicks(7837) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("026a35af-167e-45ea-bc11-264738dc93f0"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("02fa69dc-752b-44a9-b447-22dfb1d41db8"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("0ae33f65-c437-487f-a5ce-aa7068bb76ab"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("0b41a382-7003-4fb8-abfd-939d030f7b67"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("26a8681c-9117-47d2-bc70-c6087b79a26a"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("2e91d916-dc9a-4722-90b6-c1d84d5a497d"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("2f78dca6-b1e9-4e67-88e9-edb198348c96"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("3bcbb11a-a04e-4a20-bc30-63b463577dac"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("3be3020f-6a1d-4424-9dfe-cd4641fe4f1c"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("47b728ee-0db0-448d-bc3d-23939a217a11"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("4bb38e57-460d-40e5-a2c7-5ed1911a3ba8"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("4f5b73a4-7172-4617-9b8e-014bf7bc77a2"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("510452ad-bf08-432b-a096-0e7ea41e444e"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("6efa0670-4c1e-47b1-a1eb-3c150b1388ed"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("6f5f6018-879d-445f-b0f7-d98057f1d8f1"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("70fa7318-651a-4b7d-bace-9d666377a7ed"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("79f5a5af-888f-47f7-b10f-617c6d5f3081"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("7cfc7a3a-10a4-4c26-878e-49c841e34122"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("92227a14-e665-4507-9661-d872b0d9d20b"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("97ebae1c-ffbd-4334-8408-0795460049fa"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("9e1bbe86-87bc-4843-a5b1-fbee794ceb5c"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("a246c2a0-10e8-4c6d-991e-6ff11a605902"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("a310060d-ffc0-4401-90ec-1600f257793e"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("af379af9-49c7-43d5-bfa6-67d017a1a672"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("c33cdb57-b8cc-4d8e-ae01-db572532a537"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("d77ba6fd-3f07-4dee-bf2b-aaedfd49a744"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("dbb1d913-c270-473f-857b-a4410c5b822e"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("edec0caa-2b04-4ef9-8004-03ec9002d8f2"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("f2f2d544-281f-4482-b320-0d7fbdc91920"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("f7f7ca35-a042-4ee3-ad05-fa16372392f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e975e2c1-1422-4ff3-882f-b87db827eb21"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2190f638-8f09-41e0-9e1c-cca6f7f09e28"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2811558f-01ea-4a81-aa9f-64785fa2cb23"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("329825f0-c10b-4c87-88f0-cb5daf548a2c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3481191c-8104-4b09-be4c-230013a7c07b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("402d4b1a-08c0-402e-bf3d-3970be79f627"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4f5cf71f-9698-4fcd-ac27-0a7007b00a27"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("571beb8e-073f-43d5-b237-858921750fa0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("776004f5-98f1-492c-a28c-0d424d63a0c9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("79b711b2-27e9-4d9d-ae73-c4f2cd0faab6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("84d0d068-28c7-4331-822c-7bd46596c44e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("86729632-d855-4430-81f5-2a33d16158b4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("91a50df3-de8d-47d1-b7f7-125ec4f6427d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("963096d9-71a4-404b-873e-79f3e7cbf38c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9cbe9810-4345-48c4-91dc-ee245323fb18"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a7e28263-532e-4b39-b64a-77a6d6ec2dac"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bf1f1bb8-b0b8-4479-a10d-4b75738b3cde"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e0d426b3-6b4d-458f-ae4e-a730c2ef7408"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e2216ccb-43b8-44dc-b7d8-b7fba6ec85ee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ee095c4b-eeb5-413a-8578-b673bff92883"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f26327d0-6265-42da-b3b1-9194f43e7752"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20db92a1-12b6-4e38-8579-0f646283a47a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc41e204-95b3-4d29-be09-b0c7bc803765"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("065ca581-25c2-4d6d-9d60-0f14aaccbf81"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("08b6ae51-589a-4a28-8f3a-9e1620cc4ea3"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("08ed0564-a9fc-4bb9-bc60-7004bdd3112a"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("30cf1c08-78a5-4c23-a3de-68ae7a129a58"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("3b2b40c8-f0ca-42e1-ba2d-ea9ffa128d42"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("561366ab-3896-4754-99e7-ca7665ddc2d6"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("5b807c70-0391-438a-bd70-ee768e6e7dce"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("7720e833-e65e-42d5-b36d-8a57a616cc7b"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("7c332908-0e1a-4d3f-8df9-3f03d35f9924"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("877f4c3b-7492-406f-a755-36b49ac1264b"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("87ff39dd-7f8d-4aa7-91f0-83ec7e83b39f"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("89cd8602-4b9d-4730-99ec-b97ef2877020"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("8ea7a9e8-bdcf-4d1f-9d7a-9aa87f07c3e5"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("8feb61c2-acc0-456b-933e-bdb5bde3f659"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("b105cf60-c1b4-467a-bb1e-8e88f288e5ca"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("c6ee952c-c968-463f-a07f-440f377e0165"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("c79e063a-3914-404b-810b-c2bd6f53fa88"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("dfd0a636-36f8-46d1-9340-dc3874dce92b"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("e1c6f5c6-d92e-40a6-ae29-5880b851c45e"));

            migrationBuilder.DeleteData(
                table: "ModuleActions",
                keyColumn: "Id",
                keyValue: new Guid("ea289d70-de03-49ed-b2cb-14baf210c483"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("0b469237-ddce-41d5-9224-1ec1705d45d3"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("113cd90f-1d17-4dd2-adc8-2b9c6fe9a46a"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("697df0c9-6c3e-4b5b-8033-af7ac37538ce"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("b4cf3915-8d94-475e-91bb-74610079f158"));

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "Id",
                keyValue: new Guid("fe63ace1-d61b-4ef6-90e2-13a8df8b8f9f"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("460d20b1-9e96-47a7-bfe2-eaefa1d70510"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("57a99491-9bd6-496d-a0d3-0b40b3a72f63"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("5d45d4b2-586e-4aa3-99e1-61f99e2ecaff"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("82f1df67-bbb8-4524-8195-c999dbce5e79"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserFriends");

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
        }
    }
}
