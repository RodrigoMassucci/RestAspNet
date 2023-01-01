using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 3L, "Category", "Description", "www.google.com", "Name", 50m },
                    { 4L, "Category", "Description", "www.google.com", "Name", 100m },
                    { 5L, "Category", "Description", "www.google.com", "Name", 150m },
                    { 6L, "Category", "Description", "www.google.com", "Name", 200m },
                    { 7L, "Category", "Description", "www.google.com", "Name", 250m },
                    { 8L, "Category", "Description", "www.google.com", "Name", 300m },
                    { 9L, "Category", "Description", "www.google.com", "Name", 350m },
                    { 10L, "Category", "Description", "www.google.com", "Name", 400m },
                    { 11L, "Category", "Description", "www.google.com", "Name", 450m },
                    { 12L, "Category", "Description", "www.google.com", "Name", 500m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L);
        }
    }
}
