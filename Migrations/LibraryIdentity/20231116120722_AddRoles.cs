using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Onodi_Blanka_Lab2.Migrations.LibraryIdentity
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51f6cd7d-272c-4ab3-a5eb-9328e63f182f", "d429d24e-398e-437b-b214-5efb9199dd66", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1965837-5116-4ede-902f-41e22457730c", "cbf89184-c5ae-4f7f-aa78-2424fda9ba1d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51f6cd7d-272c-4ab3-a5eb-9328e63f182f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1965837-5116-4ede-902f-41e22457730c");
        }
    }
}
