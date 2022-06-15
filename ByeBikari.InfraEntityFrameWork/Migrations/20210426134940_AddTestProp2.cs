using Microsoft.EntityFrameworkCore.Migrations;

namespace ByeBikari.InfraEntityFrameWork.Migrations
{
    public partial class AddTestProp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TestProp2",
                schema: "dbo",
                table: "TbUser",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestProp2",
                schema: "dbo",
                table: "TbUser");
        }
    }
}
