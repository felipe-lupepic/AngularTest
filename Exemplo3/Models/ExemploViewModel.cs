using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exemplo3.Models
{
    public class ExemploViewModel
    {
        [Display(Name="Identificador")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Speaker")]
        public string Speaker { get; set; }

        [Display(Name = "Venue")]
        public string Venue { get; set; }

        [Display(Name = "Duration")]
        public string Duration { get; set; }
    }
}