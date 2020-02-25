using Microsoft.EntityFrameworkCore.Migrations;

namespace Mellowood.Migrations
{
    public partial class addCMSremoveContentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "AppContents");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AppContents",
                maxLength: 65536,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 65536,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AppContents",
                maxLength: 65536,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 65536);

            migrationBuilder.AddColumn<int>(
                name: "ContentId",
                table: "AppContents",
                nullable: false,
                defaultValue: 0);
        }
    }
}
