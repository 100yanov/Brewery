using Microsoft.EntityFrameworkCore.Migrations;

namespace Brewery.Data.Migrations
{
    public partial class FixBrewName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_Recipes_RecipeId",
                table: "MyProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "Brews");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_RecipeId",
                table: "Brews",
                newName: "IX_Brews_RecipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brews",
                table: "Brews",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Brews_Recipes_RecipeId",
                table: "Brews",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brews_Recipes_RecipeId",
                table: "Brews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brews",
                table: "Brews");

            migrationBuilder.RenameTable(
                name: "Brews",
                newName: "MyProperty");

            migrationBuilder.RenameIndex(
                name: "IX_Brews_RecipeId",
                table: "MyProperty",
                newName: "IX_MyProperty_RecipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_Recipes_RecipeId",
                table: "MyProperty",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
