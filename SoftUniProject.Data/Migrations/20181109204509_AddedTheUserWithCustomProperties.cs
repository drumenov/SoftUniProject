using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftUniProject.Data.Migrations
{
    public partial class AddedTheUserWithCustomProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpoertsReceipts_Receipts_ReceiptId",
                table: "ExpoertsReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpoertsReceipts_AspNetUsers_UserId",
                table: "ExpoertsReceipts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpoertsReceipts",
                table: "ExpoertsReceipts");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "ExpoertsReceipts",
                newName: "ExpertsReceipts");

            migrationBuilder.RenameIndex(
                name: "IX_ExpoertsReceipts_ReceiptId",
                table: "ExpertsReceipts",
                newName: "IX_ExpertsReceipts_ReceiptId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpertsReceipts",
                table: "ExpertsReceipts",
                columns: new[] { "UserId", "ReceiptId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertsReceipts_Receipts_ReceiptId",
                table: "ExpertsReceipts",
                column: "ReceiptId",
                principalTable: "Receipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertsReceipts_AspNetUsers_UserId",
                table: "ExpertsReceipts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpertsReceipts_Receipts_ReceiptId",
                table: "ExpertsReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpertsReceipts_AspNetUsers_UserId",
                table: "ExpertsReceipts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpertsReceipts",
                table: "ExpertsReceipts");

            migrationBuilder.RenameTable(
                name: "ExpertsReceipts",
                newName: "ExpoertsReceipts");

            migrationBuilder.RenameIndex(
                name: "IX_ExpertsReceipts_ReceiptId",
                table: "ExpoertsReceipts",
                newName: "IX_ExpoertsReceipts_ReceiptId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpoertsReceipts",
                table: "ExpoertsReceipts",
                columns: new[] { "UserId", "ReceiptId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExpoertsReceipts_Receipts_ReceiptId",
                table: "ExpoertsReceipts",
                column: "ReceiptId",
                principalTable: "Receipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpoertsReceipts_AspNetUsers_UserId",
                table: "ExpoertsReceipts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
