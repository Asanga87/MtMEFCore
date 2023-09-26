using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtMEFCore.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Shop_Customers_CustomerID",
                table: "Customer_Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Shop_Shops_ShopID",
                table: "Customer_Shop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer_Shop",
                table: "Customer_Shop");

            migrationBuilder.RenameTable(
                name: "Customer_Shop",
                newName: "Customer_Shops");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Shop_CustomerID",
                table: "Customer_Shops",
                newName: "IX_Customer_Shops_CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer_Shops",
                table: "Customer_Shops",
                columns: new[] { "ShopID", "CustomerID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Shops_Customers_CustomerID",
                table: "Customer_Shops",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Shops_Shops_ShopID",
                table: "Customer_Shops",
                column: "ShopID",
                principalTable: "Shops",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Shops_Customers_CustomerID",
                table: "Customer_Shops");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Shops_Shops_ShopID",
                table: "Customer_Shops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer_Shops",
                table: "Customer_Shops");

            migrationBuilder.RenameTable(
                name: "Customer_Shops",
                newName: "Customer_Shop");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Shops_CustomerID",
                table: "Customer_Shop",
                newName: "IX_Customer_Shop_CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer_Shop",
                table: "Customer_Shop",
                columns: new[] { "ShopID", "CustomerID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Shop_Customers_CustomerID",
                table: "Customer_Shop",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Shop_Shops_ShopID",
                table: "Customer_Shop",
                column: "ShopID",
                principalTable: "Shops",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
