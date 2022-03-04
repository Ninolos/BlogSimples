﻿using BlogPessoal.Web.Data.Mapeamento;
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
        public DbSet<Artigo> Artigos { get; set; }
        public DbSet<Autor> Autores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaDeArtigoMap());
            modelBuilder.Configurations.Add(new ArtigoMap());
            modelBuilder.Configurations.Add(new AutorMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}