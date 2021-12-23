using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4.EsercitazioneFinale.Core.Entities;

namespace Week4.EsercitazioneFinaleEF
{
    public class Context : DbContext
    {
        public DbSet<Spesa> Spese { get; set; }
        public DbSet<Categoria> Categorie { get; set; }

        public Context() : base() { }

        public Context(DbContextOptions<Context> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionStringSQL = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog=GestioneSpeseEF; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                optionsBuilder.UseSqlServer(connectionStringSQL);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Spesa>(new SpesaConfiguration());
            modelBuilder.ApplyConfiguration<Categoria>(new CategoriaConfiguration());
        }
    }
}
