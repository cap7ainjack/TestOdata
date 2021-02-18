using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestOdataProblem.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Active", "AddressLine", "City", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("3416c9e4-4c1c-4122-bf8a-8bb6428238f0"), true, "58 Fair St", "Kingston", "12401" },
                    { new Guid("3f22c7dd-4b17-403e-bbb5-4d8c30520cb7"), true, "426 Brazos Hill Ln", "Sealy", "77474" },
                    { new Guid("3498634e-b8ae-4c8e-b699-0fbafc7d8729"), true, "78 College Ave", "New Brunswick", "08901" },
                    { new Guid("c21fa9a0-98f2-4453-aa1f-7906b7d297dd"), true, "178 Chandlers Ferry Rd", "Hartwell", "30643" },
                    { new Guid("d6a97b73-e935-41e4-88df-9b735bce29b5"), true, "110 Popular St", "Chunky", "39323" },
                    { new Guid("8a01633a-fdb0-44ab-bee1-ca8ccb2ed0de"), true, "111 Yale Rd", "Audubon", "08106" },
                    { new Guid("f36f5352-ed1d-495d-8b20-a8ddfacd792d"), true, "173 N Wantagh Ave", "Levittown", "11756" },
                    { new Guid("096904e4-bab9-4f1a-b7f3-27524e9e658b"), true, "248 Leighton Ave", "Red Bank", "07701" },
                    { new Guid("4200b0ae-de2b-4ebb-8a25-d8227431d921"), true, "837 Estancia Way", "San Rafael", "94903" },
                    { new Guid("1cc41eb5-7839-46e8-8efa-b1cfd2721a62"), true, "42 Meadowbrook Park Dr", "Kernersville", "27284" },
                    { new Guid("0d1259c5-f06b-4e86-b7d0-5f56bfa5c70b"), true, "899  Randall Drive", "Hillo", "96720" },
                    { new Guid("75ae4ecb-50c0-44bb-abd8-c6020ada346c"), true, "303  Gerald L. Bates Drive", "LYNDON", "66451" },
                    { new Guid("3123333b-4ac5-4d1b-9047-7881d060df68"), true, "18 Fair St", "Kingston", "12401" },
                    { new Guid("c563789f-af45-4946-a2ab-46dab5b7856d"), true, "3440  Indiana Avenue", "Kingston", "12401" },
                    { new Guid("691cc6f4-76af-4df6-99dc-34dfbc93ab6e"), false, "108 Fair St", "Kingston", "12401" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "Name", "OfficeId" },
                values: new object[,]
                {
                    { new Guid("26f5d47a-0088-4c4b-9bfb-a893cfde68ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Smith", new Guid("3416c9e4-4c1c-4122-bf8a-8bb6428238f0") },
                    { new Guid("5f324e14-542c-4a40-a4b8-8acca5c0dce6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", new Guid("3416c9e4-4c1c-4122-bf8a-8bb6428238f0") },
                    { new Guid("6d96cbd4-61b2-4786-b9c4-29191c61e41a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vic Down", new Guid("3416c9e4-4c1c-4122-bf8a-8bb6428238f0") },
                    { new Guid("ef90ef76-7751-41f2-9dfc-887c291bd2f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda Tulip", new Guid("3f22c7dd-4b17-403e-bbb5-4d8c30520cb7") },
                    { new Guid("df4fe7a8-c754-473a-aaf1-13ebcbf8be90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ben Foss", new Guid("3498634e-b8ae-4c8e-b699-0fbafc7d8729") },
                    { new Guid("9b3592ae-ab5d-45d3-a153-f6d93a870c9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane S", new Guid("c21fa9a0-98f2-4453-aa1f-7906b7d297dd") },
                    { new Guid("aecfa712-1d14-45ef-8150-9db3ce550c4e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Green", new Guid("c21fa9a0-98f2-4453-aa1f-7906b7d297dd") },
                    { new Guid("7925c62d-1b8d-4009-8559-15e9ed43b46a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milton P Smith", new Guid("8a01633a-fdb0-44ab-bee1-ca8ccb2ed0de") },
                    { new Guid("803fc464-1ecb-40f2-b3a4-54396f5c38ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dewey K Smith", new Guid("8a01633a-fdb0-44ab-bee1-ca8ccb2ed0de") },
                    { new Guid("b75e73ef-bac5-475b-9f06-cbf82e8f344c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harrison F Johnson", new Guid("096904e4-bab9-4f1a-b7f3-27524e9e658b") },
                    { new Guid("2682660b-e6f7-452d-8677-c70c75d6c13d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian K Johnson", new Guid("096904e4-bab9-4f1a-b7f3-27524e9e658b") },
                    { new Guid("7036fab9-6196-4b14-be8f-39012be8109d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amber Smith", new Guid("4200b0ae-de2b-4ebb-8a25-d8227431d921") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2682660b-e6f7-452d-8677-c70c75d6c13d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("26f5d47a-0088-4c4b-9bfb-a893cfde68ea"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5f324e14-542c-4a40-a4b8-8acca5c0dce6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6d96cbd4-61b2-4786-b9c4-29191c61e41a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7036fab9-6196-4b14-be8f-39012be8109d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7925c62d-1b8d-4009-8559-15e9ed43b46a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("803fc464-1ecb-40f2-b3a4-54396f5c38ba"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9b3592ae-ab5d-45d3-a153-f6d93a870c9c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("aecfa712-1d14-45ef-8150-9db3ce550c4e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b75e73ef-bac5-475b-9f06-cbf82e8f344c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("df4fe7a8-c754-473a-aaf1-13ebcbf8be90"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ef90ef76-7751-41f2-9dfc-887c291bd2f9"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("0d1259c5-f06b-4e86-b7d0-5f56bfa5c70b"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("1cc41eb5-7839-46e8-8efa-b1cfd2721a62"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("3123333b-4ac5-4d1b-9047-7881d060df68"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("691cc6f4-76af-4df6-99dc-34dfbc93ab6e"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("75ae4ecb-50c0-44bb-abd8-c6020ada346c"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("c563789f-af45-4946-a2ab-46dab5b7856d"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("d6a97b73-e935-41e4-88df-9b735bce29b5"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("f36f5352-ed1d-495d-8b20-a8ddfacd792d"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("096904e4-bab9-4f1a-b7f3-27524e9e658b"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("3416c9e4-4c1c-4122-bf8a-8bb6428238f0"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("3498634e-b8ae-4c8e-b699-0fbafc7d8729"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("3f22c7dd-4b17-403e-bbb5-4d8c30520cb7"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("4200b0ae-de2b-4ebb-8a25-d8227431d921"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("8a01633a-fdb0-44ab-bee1-ca8ccb2ed0de"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("c21fa9a0-98f2-4453-aa1f-7906b7d297dd"));
        }
    }
}
