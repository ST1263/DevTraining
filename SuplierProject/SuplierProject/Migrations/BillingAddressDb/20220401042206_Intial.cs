using Microsoft.EntityFrameworkCore.Migrations;

namespace SuplierProject.Migrations.BillingAddressDb
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suplier",
                columns: table => new
                {
                    suplierid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supliername = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplier", x => x.suplierid);
                });

            migrationBuilder.CreateTable(
                name: "BillingAddress",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    addressOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addressTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    suplierid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingAddress", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_BillingAddress_Suplier_suplierid",
                        column: x => x.suplierid,
                        principalTable: "Suplier",
                        principalColumn: "suplierid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    produtunit = table.Column<double>(type: "float", nullable: false),
                    suplierid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productid);
                    table.ForeignKey(
                        name: "FK_Product_Suplier_suplierid",
                        column: x => x.suplierid,
                        principalTable: "Suplier",
                        principalColumn: "suplierid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillingAddress_suplierid",
                table: "BillingAddress",
                column: "suplierid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_suplierid",
                table: "Product",
                column: "suplierid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingAddress");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Suplier");
        }
    }
}
