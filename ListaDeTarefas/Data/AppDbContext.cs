using ListaDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeTarefas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Status> Statuses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { CategoriaId = "trabalho", Nome = "Trabalho" },
                new Categoria { CategoriaId = "casa", Nome = "Casa" },
                new Categoria { CategoriaId = "faculdade", Nome = "Faculdade" },
                new Categoria { CategoriaId = "compras", Nome = "Compras" },
                new Categoria { CategoriaId = "academia", Nome = "Academia" }
             );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "aberto", Nome = "Aberto" },
                new Status { StatusId = "completo", Nome = "Completo" }
                );

            modelBuilder.Entity<Tarefa>().HasData(
                new Tarefa { Id = 1, Descricao = "Limpar a casa", DataDeVencimento = DateTime.Now, CategoriaId = "casa", StatusId = "aberto" },
                new Tarefa { Id = 2, Descricao = "Lavar o carro", DataDeVencimento = new DateTime(2024, 7, 9), CategoriaId = "casa", StatusId = "aberto" },
                new Tarefa { Id = 3, Descricao = "Estudar c#", DataDeVencimento = new DateTime(2024, 7, 10), CategoriaId = "faculdade", StatusId = "completo" },
                new Tarefa { Id = 4, Descricao = "Fazer tarefa", DataDeVencimento = new DateTime(2024, 7, 11), CategoriaId = "faculdade", StatusId = "aberto" }
                );
            base.OnModelCreating(modelBuilder);
        }

    }
}
