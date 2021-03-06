using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class CategoriaDeArtigo
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome da Categoria")]
        public string Nome { get; set; }
        [Display(Name = "Descriçao")]
        public string Descricao { get; set; }

        public virtual ICollection<Artigo> Artigos { get; set; }
    }
}