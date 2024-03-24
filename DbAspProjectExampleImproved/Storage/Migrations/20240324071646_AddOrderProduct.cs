using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbAspProjectExampleImproved.Storage.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "orderProducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "orderProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_orderProducts_OrderId",
                table: "orderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_orderProducts_ProductId",
                table: "orderProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderProducts_Orders_OrderId",
                table: "orderProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orderProducts_Products_ProductId",
                table: "orderProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderProducts_Orders_OrderId",
                table: "orderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_orderProducts_Products_ProductId",
                table: "orderProducts");

            migrationBuilder.DropIndex(
                name: "IX_orderProducts_OrderId",
                table: "orderProducts");

            migrationBuilder.DropIndex(
                name: "IX_orderProducts_ProductId",
                table: "orderProducts");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "orderProducts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "orderProducts");
        }
    }
}
