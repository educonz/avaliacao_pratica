using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LivrariaMVC.Models
{
    public class Editora
    {
        public int Id { get; set; }

        [Display(Name = "Nome da editora")]
        public string NomeEditora { get; set; }
    }
}