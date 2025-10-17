using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TvcDay09LabCF.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TvcLoai_San_Pham",
                columns: table => new
                {
                    tvcId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tvcMaLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tvcTenLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    tvcTrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvcLoai_San_Pham", x => x.tvcId);
                });

            migrationBuilder.CreateTable(
                name: "TvcSan_Pham",
                columns: table => new
                {
                    tvcId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tvcMaSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tvcTenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tvcHinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tvcSoLuong = table.Column<int>(type: "int", nullable: false),
                    tvcDonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tvcMaLoai = table.Column<long>(type: "bigint", nullable: false),
                    tvcTrangThai = table.Column<bool>(type: "bit", nullable: false),
                    tvcLoai_San_PhamtvcId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvcSan_Pham", x => x.tvcId);
                    table.ForeignKey(
                        name: "FK_TvcSan_Pham_TvcLoai_San_Pham_tvcLoai_San_PhamtvcId",
                        column: x => x.tvcLoai_San_PhamtvcId,
                        principalTable: "TvcLoai_San_Pham",
                        principalColumn: "tvcId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TvcSan_Pham_tvcLoai_San_PhamtvcId",
                table: "TvcSan_Pham",
                column: "tvcLoai_San_PhamtvcId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TvcSan_Pham");

            migrationBuilder.DropTable(
                name: "TvcLoai_San_Pham");
        }
    }
}
