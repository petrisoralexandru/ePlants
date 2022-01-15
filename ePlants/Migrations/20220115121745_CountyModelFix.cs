using Microsoft.EntityFrameworkCore.Migrations;

namespace ePlants.Migrations
{
    public partial class CountyModelFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Counties_Counties_CountyModelId",
                table: "Counties");

            migrationBuilder.DropIndex(
                name: "IX_Counties_CountyModelId",
                table: "Counties");

            migrationBuilder.DropColumn(
                name: "CountyModelId",
                table: "Counties");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountyModelId",
                table: "Counties",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Counties_CountyModelId",
                table: "Counties",
                column: "CountyModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Counties_Counties_CountyModelId",
                table: "Counties",
                column: "CountyModelId",
                principalTable: "Counties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
