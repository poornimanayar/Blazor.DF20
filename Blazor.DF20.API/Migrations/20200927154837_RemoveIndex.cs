using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor.DF20.API.Migrations
{
    public partial class RemoveIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Movies_Genres_GenreId",
                table: "Movies");              
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
