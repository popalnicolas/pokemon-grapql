using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLLearning.Migrations
{
    /// <inheritdoc />
    public partial class FKNaming2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pokemons_pokemon_types_pokemon_PokemonsPokemonId",
                table: "pokemons_pokemon_types");

            migrationBuilder.DropForeignKey(
                name: "FK_pokemons_pokemon_types_pokemon_type_PokemonTypesPokemonTypeId",
                table: "pokemons_pokemon_types");

            migrationBuilder.RenameColumn(
                name: "PokemonsPokemonId",
                table: "pokemons_pokemon_types",
                newName: "pokemon_type_id");

            migrationBuilder.RenameColumn(
                name: "PokemonTypesPokemonTypeId",
                table: "pokemons_pokemon_types",
                newName: "pokemon_id");

            migrationBuilder.RenameIndex(
                name: "IX_pokemons_pokemon_types_PokemonsPokemonId",
                table: "pokemons_pokemon_types",
                newName: "IX_pokemons_pokemon_types_pokemon_type_id");

            migrationBuilder.AddForeignKey(
                name: "FK_pokemons_pokemon_types_pokemon_pokemon_id",
                table: "pokemons_pokemon_types",
                column: "pokemon_id",
                principalTable: "pokemon",
                principalColumn: "pokemon_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pokemons_pokemon_types_pokemon_type_pokemon_type_id",
                table: "pokemons_pokemon_types",
                column: "pokemon_type_id",
                principalTable: "pokemon_type",
                principalColumn: "pokemon_type_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pokemons_pokemon_types_pokemon_pokemon_id",
                table: "pokemons_pokemon_types");

            migrationBuilder.DropForeignKey(
                name: "FK_pokemons_pokemon_types_pokemon_type_pokemon_type_id",
                table: "pokemons_pokemon_types");

            migrationBuilder.RenameColumn(
                name: "pokemon_type_id",
                table: "pokemons_pokemon_types",
                newName: "PokemonsPokemonId");

            migrationBuilder.RenameColumn(
                name: "pokemon_id",
                table: "pokemons_pokemon_types",
                newName: "PokemonTypesPokemonTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_pokemons_pokemon_types_pokemon_type_id",
                table: "pokemons_pokemon_types",
                newName: "IX_pokemons_pokemon_types_PokemonsPokemonId");

            migrationBuilder.AddForeignKey(
                name: "FK_pokemons_pokemon_types_pokemon_PokemonsPokemonId",
                table: "pokemons_pokemon_types",
                column: "PokemonsPokemonId",
                principalTable: "pokemon",
                principalColumn: "pokemon_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pokemons_pokemon_types_pokemon_type_PokemonTypesPokemonTypeId",
                table: "pokemons_pokemon_types",
                column: "PokemonTypesPokemonTypeId",
                principalTable: "pokemon_type",
                principalColumn: "pokemon_type_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
