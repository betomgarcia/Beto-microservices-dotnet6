using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductApi.Migrations
{
    public partial class RemoverBaseEntityAddAutoIncrementNovamente2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "product",
                newName: "id");

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "product",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "product",
                newName: "Id");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "product",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:ColumnOrder", 1);
        }
    }
}
