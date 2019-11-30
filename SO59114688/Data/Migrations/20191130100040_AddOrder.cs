using Microsoft.EntityFrameworkCore.Migrations;

namespace SO59114688.Data.Migrations
{
    public partial class AddOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gander",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Imei",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastNumber",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Themapnail",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gander",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Imei",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Themapnail",
                table: "AspNetUsers");
        }
    }
}
