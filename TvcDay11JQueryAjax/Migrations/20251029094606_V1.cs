using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TvcDay11JQueryAjax.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TvcStudent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvcStudent", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TvcStudent",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 19, "Nguyễn Văn An" },
                    { 2, 20, "Trần Thị Bình" },
                    { 3, 21, "Lê Văn Cường" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TvcStudent");
        }
    }
}
