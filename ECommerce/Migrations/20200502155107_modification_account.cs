using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class modification_account : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_user_Accounts_Id",
                table: "tb_m_user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "tb_m_account");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_account",
                table: "tb_m_account",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_user_tb_m_account_Id",
                table: "tb_m_user",
                column: "Id",
                principalTable: "tb_m_account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_user_tb_m_account_Id",
                table: "tb_m_user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_account",
                table: "tb_m_account");

            migrationBuilder.RenameTable(
                name: "tb_m_account",
                newName: "Accounts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_user_Accounts_Id",
                table: "tb_m_user",
                column: "Id",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
