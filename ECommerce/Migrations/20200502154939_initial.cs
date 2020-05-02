using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_notification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_notification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_supplier",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_user",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_user", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_m_user_Accounts_Id",
                        column: x => x.Id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Supplier_Id = table.Column<string>(nullable: true),
                    Category_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_m_item_tb_m_category_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "tb_m_category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_m_item_tb_m_supplier_Supplier_Id",
                        column: x => x.Supplier_Id,
                        principalTable: "tb_m_supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_item_detail",
                columns: table => new
                {
                    Serial = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Item_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_item_detail", x => x.Serial);
                    table.ForeignKey(
                        name: "FK_tb_m_item_detail_tb_m_item_Item_Id",
                        column: x => x.Item_Id,
                        principalTable: "tb_m_item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_item_photo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Photo = table.Column<string>(nullable: true),
                    Item_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_item_photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_m_item_photo_tb_m_item_Item_Id",
                        column: x => x.Item_Id,
                        principalTable: "tb_m_item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_item_Category_Id",
                table: "tb_m_item",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_item_Supplier_Id",
                table: "tb_m_item",
                column: "Supplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_item_detail_Item_Id",
                table: "tb_m_item_detail",
                column: "Item_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_item_photo_Item_Id",
                table: "tb_m_item_photo",
                column: "Item_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_m_item_detail");

            migrationBuilder.DropTable(
                name: "tb_m_item_photo");

            migrationBuilder.DropTable(
                name: "tb_m_notification");

            migrationBuilder.DropTable(
                name: "tb_m_role");

            migrationBuilder.DropTable(
                name: "tb_m_user");

            migrationBuilder.DropTable(
                name: "tb_m_item");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "tb_m_category");

            migrationBuilder.DropTable(
                name: "tb_m_supplier");
        }
    }
}
