using Microsoft.EntityFrameworkCore.Migrations;

namespace ByeBikari.InfraEntityFrameWork.Migrations
{
    public partial class ByeBikariReadDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "TbUser",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    SurName = table.Column<string>(maxLength: 100, nullable: false),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    PassWord = table.Column<string>(maxLength: 100, nullable: false),
                    Emailaddress = table.Column<string>(maxLength: 100, nullable: false),
                    TestProp = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUser", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbUser",
                schema: "dbo");
        }
    }
}
