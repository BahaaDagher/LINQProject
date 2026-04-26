using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LINQProject.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into production.categories (category_name)values ('category From Migration ')"); 
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from production.categories where category_name = 'category From Migration '");
        }
    }
}
