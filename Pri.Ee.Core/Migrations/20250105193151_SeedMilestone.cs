using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pri.Ee.Core.Migrations
{
    /// <inheritdoc />
    public partial class SeedMilestone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("0fedeb03-d3ba-4e19-8fdf-bd65e71e0f18"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("6a94dfe1-50e7-43e2-a1c4-dae844a90c39"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("97ea1c82-4a63-4f5a-9c55-f8bc0e9a773d"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("d545023d-f0b0-476b-b1d9-d7dd59237940"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("fa93776e-2751-44bd-9b54-63e3b0eccb21"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("09251331-9350-4e97-9aa9-c4c12c29b5e3"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("1951152d-20e1-4b00-b636-3f62f2a36f9d"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("3b213f0a-3f76-4934-bb82-9b45b726e032"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("3bd964d3-acbb-44b5-82e6-f4258c54588b"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("4888d859-df8f-43a6-ba3b-2aced6ef6495"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("57d74fa0-ff02-4a8f-9c69-a7f8031e2271"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("6431a704-d51f-4216-8db2-7a4a02425945"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("76d71e75-98a1-44d6-b272-055b7daf4836"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("b9062a69-a591-49ff-aee4-5220703a0144"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("ecd4e575-1226-429f-919f-c8fd8a15aeff"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "2dcc0e4d-6939-49ee-a8ba-2a41a2cbc22c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "c541a4a9-323d-4a46-b4d8-af44f5c8b8ff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72f2f5be-f590-4f5b-a616-141a44bab483", "AQAAAAIAAYagAAAAEOPTgoS+q7e2VURJ3SB70G5qB6+CiY1egItvwWqS88S2kA+0oraNy3u4SwuWqSWwdA==", "296f8476-82e3-40de-afd1-72b023fd9490" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5ae0b60-b8ee-40b9-a60e-88fb6db62256", "AQAAAAIAAYagAAAAEO/oAHqvt6sDVe4/5+SdzqYKZREsOzd25RGYHCR8fU0BKfc/uTdVM68mtV1ZkiIBiw==", "32de0a7b-ba50-452f-bd73-a41788a1806e" });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Description", "EndDate", "Progress", "StartDate", "Target", "UserId" },
                values: new object[,]
                {
                    { new Guid("1bcc417d-d600-4bfe-8d22-38dfbf5a4d4a"), "Complete 5 yoga sessions", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("440aa18a-aaf0-4641-bd17-3b77c9d5038d"), "Swim 3 kilometers this month", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("51ea393a-1b5a-4232-bbfc-c25f1f7fb0b3"), "Burn 1000 calories this week", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("6e0f9339-e6ec-4c6b-b5fc-656e1a7e7449"), "Lose 2 kg in 2 months", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("76b5682d-0c96-477e-82be-df2feb39aad7"), "Run 10 km this month", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "00000000-0000-0000-0000-000000000002" }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "CaloriesBurned", "Date", "Duration", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("02a53363-3a92-4ad5-b662-591fe0309114"), 300, new DateTime(2024, 12, 26, 20, 31, 51, 285, DateTimeKind.Local).AddTicks(5701), 30, "Running", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("1065ea41-7cfb-44c9-a841-92ccf4554be3"), 400, new DateTime(2024, 12, 28, 20, 31, 51, 285, DateTimeKind.Local).AddTicks(5809), 45, "Swimming", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("30d295ef-8d00-44e0-a920-1bd60ee5ee24"), 600, new DateTime(2025, 1, 4, 20, 31, 51, 285, DateTimeKind.Local).AddTicks(5856), 90, "Hiking", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("62b5e7be-ef0f-41c8-bbe4-b2fe961c2752"), 450, new DateTime(2025, 1, 2, 20, 31, 51, 285, DateTimeKind.Local).AddTicks(5848), 50, "Swimming", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("96622c72-88a6-4ab4-86b7-fe3402d42c07"), 400, new DateTime(2025, 1, 1, 20, 31, 51, 285, DateTimeKind.Local).AddTicks(5842), 40, "Cycling", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("9c9f70bd-1ec2-4a79-9e55-d6b2ac5664bf"), 500, new DateTime(2024, 12, 27, 20, 31, 51, 285, DateTimeKind.Local).AddTicks(5805), 60, "Cycling", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("cd0e4fde-3851-48fb-af27-3d5d5c927a43"), 100, new DateTime(2024, 12, 29, 20, 31, 51, 285, DateTimeKind.Local).AddTicks(5814), 30, "Yoga", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("d0828d5e-28aa-4314-aa8b-ddf55ce42c9b"), 120, new DateTime(2025, 1, 3, 20, 31, 51, 285, DateTimeKind.Local).AddTicks(5852), 35, "Yoga", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("ed7701f5-e3ee-4311-8c68-25a7254c8a32"), 270, new DateTime(2024, 12, 31, 20, 31, 51, 285, DateTimeKind.Local).AddTicks(5840), 25, "Running", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("f04dcac1-031a-4d52-abd9-fc56a3cdb459"), 350, new DateTime(2024, 12, 30, 20, 31, 51, 285, DateTimeKind.Local).AddTicks(5817), 50, "Weightlifting", "00000000-0000-0000-0000-000000000002" }
                });

            migrationBuilder.InsertData(
                table: "Milestones",
                columns: new[] { "Id", "Description", "GoalId", "Progress", "Target" },
                values: new object[,]
                {
                    { new Guid("59997f67-9416-4397-bb77-213bf0f0e004"), "Run 5 km this month", new Guid("76b5682d-0c96-477e-82be-df2feb39aad7"), 2, 5 },
                    { new Guid("60366059-e80d-40af-8a9f-95058127527e"), "Swim 1 kilometer this month", new Guid("440aa18a-aaf0-4641-bd17-3b77c9d5038d"), 0, 1 },
                    { new Guid("65595f40-7ef6-4839-995b-1696f55055b9"), "Achieve 500 calories burned this week", new Guid("51ea393a-1b5a-4232-bbfc-c25f1f7fb0b3"), 300, 500 },
                    { new Guid("6964e0b2-a344-4132-88dd-cbac0e8ed5b1"), "Lose 1 kg in the first month", new Guid("6e0f9339-e6ec-4c6b-b5fc-656e1a7e7449"), 0, 1 },
                    { new Guid("f666bc0b-b41e-4848-a6d2-eb8dacfe34f7"), "Complete 2 yoga sessions", new Guid("1bcc417d-d600-4bfe-8d22-38dfbf5a4d4a"), 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: new Guid("59997f67-9416-4397-bb77-213bf0f0e004"));

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: new Guid("60366059-e80d-40af-8a9f-95058127527e"));

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: new Guid("65595f40-7ef6-4839-995b-1696f55055b9"));

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: new Guid("6964e0b2-a344-4132-88dd-cbac0e8ed5b1"));

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: new Guid("f666bc0b-b41e-4848-a6d2-eb8dacfe34f7"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("02a53363-3a92-4ad5-b662-591fe0309114"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("1065ea41-7cfb-44c9-a841-92ccf4554be3"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("30d295ef-8d00-44e0-a920-1bd60ee5ee24"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("62b5e7be-ef0f-41c8-bbe4-b2fe961c2752"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("96622c72-88a6-4ab4-86b7-fe3402d42c07"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("9c9f70bd-1ec2-4a79-9e55-d6b2ac5664bf"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("cd0e4fde-3851-48fb-af27-3d5d5c927a43"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("d0828d5e-28aa-4314-aa8b-ddf55ce42c9b"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("ed7701f5-e3ee-4311-8c68-25a7254c8a32"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("f04dcac1-031a-4d52-abd9-fc56a3cdb459"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("1bcc417d-d600-4bfe-8d22-38dfbf5a4d4a"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("440aa18a-aaf0-4641-bd17-3b77c9d5038d"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("51ea393a-1b5a-4232-bbfc-c25f1f7fb0b3"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("6e0f9339-e6ec-4c6b-b5fc-656e1a7e7449"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("76b5682d-0c96-477e-82be-df2feb39aad7"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "f5ca5e20-57c0-4c94-b087-0eb700f81933");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "13a3050a-cff5-4a5c-ad4c-412a443d1450");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "944f6084-75d9-49da-9202-eb117ae77c30", "AQAAAAIAAYagAAAAEEZrTiqBNtEAENLs5chyRpR1BjopGi9Retum5/BJRDQgIFn6DR0ypN/LG8B1gmJnUQ==", "9aa7cd7b-29e0-4c60-b535-fa0cd48c21d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43140505-6909-4a16-82a4-58e2cf0d028e", "AQAAAAIAAYagAAAAECgUglUqKJ3IdZ+wT3rD83IWxunFEw0W0PzkNwzUXHOOPj+7MMo2IRYKym/1lhK1UQ==", "20ca419a-5d6c-4892-b8c9-14e901b6ac0b" });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Description", "EndDate", "Progress", "StartDate", "Target", "UserId" },
                values: new object[,]
                {
                    { new Guid("0fedeb03-d3ba-4e19-8fdf-bd65e71e0f18"), "Lose 2 kg in 2 months", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("6a94dfe1-50e7-43e2-a1c4-dae844a90c39"), "Complete 5 yoga sessions", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("97ea1c82-4a63-4f5a-9c55-f8bc0e9a773d"), "Burn 1000 calories this week", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("d545023d-f0b0-476b-b1d9-d7dd59237940"), "Swim 3 kilometers this month", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("fa93776e-2751-44bd-9b54-63e3b0eccb21"), "Run 10 km this month", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "00000000-0000-0000-0000-000000000002" }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "CaloriesBurned", "Date", "Duration", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("09251331-9350-4e97-9aa9-c4c12c29b5e3"), 270, new DateTime(2024, 12, 31, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7153), 25, "Running", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("1951152d-20e1-4b00-b636-3f62f2a36f9d"), 300, new DateTime(2024, 12, 26, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7073), 30, "Running", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("3b213f0a-3f76-4934-bb82-9b45b726e032"), 100, new DateTime(2024, 12, 29, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7140), 30, "Yoga", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("3bd964d3-acbb-44b5-82e6-f4258c54588b"), 600, new DateTime(2025, 1, 4, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7162), 90, "Hiking", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("4888d859-df8f-43a6-ba3b-2aced6ef6495"), 450, new DateTime(2025, 1, 2, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7157), 50, "Swimming", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("57d74fa0-ff02-4a8f-9c69-a7f8031e2271"), 400, new DateTime(2025, 1, 1, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7155), 40, "Cycling", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("6431a704-d51f-4216-8db2-7a4a02425945"), 350, new DateTime(2024, 12, 30, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7142), 50, "Weightlifting", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("76d71e75-98a1-44d6-b272-055b7daf4836"), 500, new DateTime(2024, 12, 27, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7132), 60, "Cycling", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("b9062a69-a591-49ff-aee4-5220703a0144"), 120, new DateTime(2025, 1, 3, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7159), 35, "Yoga", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("ecd4e575-1226-429f-919f-c8fd8a15aeff"), 400, new DateTime(2024, 12, 28, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7138), 45, "Swimming", "00000000-0000-0000-0000-000000000002" }
                });
        }
    }
}
