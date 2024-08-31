using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class security_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c176c03f-b269-459c-9d48-5c8a27dc9b2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af6e602e-eed1-4c05-a1ee-31280ba1fb49"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ee363e14-80a8-40ae-b662-b24b8e22472a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("c176c03f-b269-459c-9d48-5c8a27dc9b2b"), new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1549), true, "User", new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1549) },
                    { new Guid("ee363e14-80a8-40ae-b662-b24b8e22472a"), new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1546), true, "Admin", new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1547) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("af6e602e-eed1-4c05-a1ee-31280ba1fb49"), new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1687), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("ee363e14-80a8-40ae-b662-b24b8e22472a"), new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1687) });
        }
    }
}
