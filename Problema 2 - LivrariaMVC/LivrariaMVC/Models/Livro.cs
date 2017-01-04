using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LivrariaMVC.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Autor")]
        public int IdAutor { get; set; }
        
        public int Ano { get; set; }

        [Display(Name = "Editora")]
        public int IdEditora { get; set; }

        [ForeignKey("IdAutor")]
        public virtual Autor Autor { get; set; }

        [ForeignKey("IdEditora")]
        public virtual Editora Editora { get; set; }
    }
}