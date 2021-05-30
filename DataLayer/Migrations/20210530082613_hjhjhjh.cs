using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class hjhjhjh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resever_Id",
                table: "Tbl_Comments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Send_Id",
                table: "Tbl_Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resever_Id",
                table: "Tbl_Comments");

            migrationBuilder.DropColumn(
                name: "Send_Id",
                table: "Tbl_Comments");
        }
    }
}
