using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace projetofinal.Data.Migrations
{
    /// <inheritdoc />
    public partial class Quatroo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "Id", "Autor", "Dimensao", "Disponivel", "Editora", "ISBN", "Idioma", "Nome", "Preco", "Sinopse", "Tema" },
                values: new object[,]
                {
                    { 1, "J.R.R. Tolkien", "23x15 cm", true, "HarperCollins", "978-84-670-6004-2", "Português", "O Senhor dos Anéis", 39.99m, "Uma jornada épica na Terra Média.", "Fantasia" },
                    { 2, "George Orwell", "21x14 cm", true, "Companhia das Letras", "978-85-359-0277-4", "Português", "1984", 25.50m, "Uma distopia sobre um futuro totalitário.", "Ficção Científica" },
                    { 3, "Miguel de Cervantes", "22x14 cm", false, "Penguin", "978-85-010-0000-0", "Português", "Dom Quixote", 30.00m, "As aventuras do cavaleiro da triste figura.", "Clássico" }
                });

            migrationBuilder.InsertData(
                table: "Encomendas",
                columns: new[] { "Id", "Estado", "LivroId", "MoradaEnvio", "NomeUtilizador" },
                values: new object[,]
                {
                    { 1, "Pendente", 1, "Rua das Flores, 123, Lisboa", "João Silva" },
                    { 2, "Satisfeita", 2, "Avenida Paulista, 456, São Paulo", "Maria Santos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Encomendas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Encomendas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
