using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyyDAL.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "color_tbl",
                columns: table => new
                {
                    colourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    colourName = table.Column<string>(nullable: true),
                    colourCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color_tbl", x => x.colourId);
                });

            migrationBuilder.CreateTable(
                name: "createcredit_tbl",
                columns: table => new
                {
                    creditId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_createcredit_tbl", x => x.creditId);
                });

            migrationBuilder.CreateTable(
                name: "sizee_tbl",
                columns: table => new
                {
                    sizeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sizeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizee_tbl", x => x.sizeId);
                });

            migrationBuilder.CreateTable(
                name: "product_tbl",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(nullable: true),
                    productYear = table.Column<int>(nullable: false),
                    channelId = table.Column<int>(nullable: false),
                    productCode = table.Column<string>(nullable: true),
                    sizeScaleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_tbl", x => x.productId);
                    table.ForeignKey(
                        name: "FK_product_tbl_sizee_tbl_sizeScaleId",
                        column: x => x.sizeScaleId,
                        principalTable: "sizee_tbl",
                        principalColumn: "sizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "article_tbl",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleName = table.Column<string>(nullable: true),
                    colourId = table.Column<int>(nullable: false),
                    productId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_tbl", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_article_tbl_color_tbl_colourId",
                        column: x => x.colourId,
                        principalTable: "color_tbl",
                        principalColumn: "colourId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_article_tbl_product_tbl_productId",
                        column: x => x.productId,
                        principalTable: "product_tbl",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_article_tbl_colourId",
                table: "article_tbl",
                column: "colourId");

            migrationBuilder.CreateIndex(
                name: "IX_article_tbl_productId",
                table: "article_tbl",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_product_tbl_sizeScaleId",
                table: "product_tbl",
                column: "sizeScaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "article_tbl");

            migrationBuilder.DropTable(
                name: "createcredit_tbl");

            migrationBuilder.DropTable(
                name: "color_tbl");

            migrationBuilder.DropTable(
                name: "product_tbl");

            migrationBuilder.DropTable(
                name: "sizee_tbl");
        }
    }
}
