using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mellowood.Migrations
{
    public partial class addCMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 256, nullable: false),
                    Description = table.Column<string>(maxLength: 65536, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppContents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppContents");
        }
    }
}
