using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class modification_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_item_tb_m_supplier_Supplier_Id",
                table: "tb_m_item");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "tb_m_supplier",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Supplier_Id",
                table: "tb_m_item",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_item_tb_m_supplier_Supplier_Id",
                table: "tb_m_item",
                column: "Supplier_Id",
                principalTable: "tb_m_supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_item_tb_m_supplier_Supplier_Id",
                table: "tb_m_item");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "tb_m_supplier",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Supplier_Id",
                table: "tb_m_item",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_item_tb_m_supplier_Supplier_Id",
                table: "tb_m_item",
                column: "Supplier_Id",
                principalTable: "tb_m_supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
