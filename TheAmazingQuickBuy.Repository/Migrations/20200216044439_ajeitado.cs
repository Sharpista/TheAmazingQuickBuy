using Microsoft.EntityFrameworkCore.Migrations;

namespace TheAmazingQuickBuy.Repository.Migrations
{
    public partial class ajeitado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_FormOfPayment_FormOfPaymentId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FormPaymentId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "FormOfPaymentId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_FormOfPayment_FormOfPaymentId",
                table: "Orders",
                column: "FormOfPaymentId",
                principalTable: "FormOfPayment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_FormOfPayment_FormOfPaymentId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "FormOfPaymentId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "FormPaymentId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_FormOfPayment_FormOfPaymentId",
                table: "Orders",
                column: "FormOfPaymentId",
                principalTable: "FormOfPayment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
