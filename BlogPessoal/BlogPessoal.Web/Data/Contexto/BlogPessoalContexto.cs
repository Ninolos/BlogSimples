using BlogPessoal.Web.Data.Mapeamento;
using BlogPessoal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Data.Contexto
{
    public class BlogPessoalContexto : DbContext
    {
        public BlogPessoalContexto() : base(typeof(BlogPessoalContexto).Name)
        {

        }

        public DbSet<CategoriaDeArtigo> CategoriasDeArtigo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaDeArtigoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}