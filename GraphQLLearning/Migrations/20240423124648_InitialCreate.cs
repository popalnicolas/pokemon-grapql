using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLLearning.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pokemon",
                columns: table => new
                {
                    pokemon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pokemon_description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemon", x => x.pokemon_id);
                });

            migrationBuilder.CreateTable(
                name: "pokemon_type",
                columns: table => new
                {
                    pokemon_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_type_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemon_type", x => x.pokemon_type_id);
                });

            migrationBuilder.CreateTable(
                name: "pokemons_pokemon_types",
                columns: table => new
                {
                    PokemonTypesPokemonTypeId = table.Column<int>(type: "int", nullable: false),
                    PokemonsPokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemons_pokemon_types", x => new { x.PokemonTypesPokemonTypeId, x.PokemonsPokemonId });
                    table.ForeignKey(
                        name: "FK_pokemons_pokemon_types_pokemon_PokemonsPokemonId",
                        column: x => x.PokemonsPokemonId,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pokemons_pokemon_types_pokemon_type_PokemonTypesPokemonTypeId",
                        column: x => x.PokemonTypesPokemonTypeId,
                        principalTable: "pokemon_type",
                        principalColumn: "pokemon_type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pokemons_pokemon_types_PokemonsPokemonId",
                table: "pokemons_pokemon_types",
                column: "PokemonsPokemonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pokemons_pokemon_types");

            migrationBuilder.DropTable(
                name: "pokemon");

            migrationBuilder.DropTable(
                name: "pokemon_type");
        }
    }
}
