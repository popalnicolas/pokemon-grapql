using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLLearning.Migrations
{
    /// <inheritdoc />
    public partial class WeightHeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pokemon_description",
                table: "pokemon",
                newName: "pokemon_weight");

            migrationBuilder.AddColumn<string>(
                name: "pokemon_height",
                table: "pokemon",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pokemon_height",
                table: "pokemon");

            migrationBuilder.RenameColumn(
                name: "pokemon_weight",
                table: "pokemon",
                newName: "pokemon_description");
        }
    }
}
