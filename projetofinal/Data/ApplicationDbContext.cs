using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using projetofinal.Models;

namespace projetofinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Adicione os DbSet correspondentes às tabelas
        public DbSet<livro> Livros { get; set; }
        public DbSet<Encomenda> Encomendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<livro>().HasData(
           new livro
           {
               Id = 1,
               Nome = "O Senhor dos Anéis",
               Autor = "J.R.R. Tolkien",
               Sinopse = "Uma jornada épica na Terra Média.",
               Preco = 39.99m,
               ISBN = "978-84-670-6004-2",
               Editora = "HarperCollins",
               Idioma = "Português",
               Tema = "Fantasia",
               Dimensao = "23x15 cm",
               Disponivel = true
           },
           new livro
           {
               Id = 2,
               Nome = "1984",
               Autor = "George Orwell",
               Sinopse = "Uma distopia sobre um futuro totalitário.",
               Preco = 25.50m,
               ISBN = "978-85-359-0277-4",
               Editora = "Companhia das Letras",
               Idioma = "Português",
               Tema = "Ficção Científica",
               Dimensao = "21x14 cm",
               Disponivel = true
           },
           new livro
           {
               Id = 3,
               Nome = "Dom Quixote",
               Autor = "Miguel de Cervantes",
               Sinopse = "As aventuras do cavaleiro da triste figura.",
               Preco = 30.00m,
               ISBN = "978-85-010-0000-0",
               Editora = "Penguin",
               Idioma = "Português",
               Tema = "Clássico",
               Dimensao = "22x14 cm",
               Disponivel = false
           }
       );

            // Inserir dados de teste para encomendas
            modelBuilder.Entity<Encomenda>().HasData(
                new Encomenda
                {
                    Id = 1,
                    LivroId = 1, // O Senhor dos Anéis
                    NomeUtilizador = "João Silva",
                    MoradaEnvio = "Rua das Flores, 123, Lisboa",
                    Estado = "Pendente"
                },
                new Encomenda
                {
                    Id = 2,
                    LivroId = 2, // 1984
                    NomeUtilizador = "Maria Santos",
                    MoradaEnvio = "Avenida Paulista, 456, São Paulo",
                    Estado = "Satisfeita"
                }
            );
            // Configurações adicionais de mapeamento podem ser adicionadas aqui
        }
    }
}
