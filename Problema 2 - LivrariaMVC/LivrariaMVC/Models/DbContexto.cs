using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LivrariaMVC.Models
{
    public class DbContexto : DbContext
    {
        public DbContexto() : base("BancoLivraria") { }

        public DbSet<Autor> Autor { get; set; }
        public DbSet<Editora> Editora { get; set; }
        public DbSet<Livro> Livro { get; set; }
    }
}