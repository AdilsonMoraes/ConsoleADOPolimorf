using CodeFirst.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirst.DAL
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Cadastro_Funcionario") { }

        //Romove a convenção para nao ficar pluralizando as tabelas na criação
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }

    }
}

//  Enable-Migrations –EnableAutomaticMigrations -force
//  EntityFramework\update-database