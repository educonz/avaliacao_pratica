using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LivrariaMVC.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Display(Name = "Nome do autor")]
        public string NomeAutor { get; set; }
    }
}