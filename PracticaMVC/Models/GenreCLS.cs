using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaMVC.Models
{
    public class GenreCLS
    {
        [Display(Name ="Genero musical")]
        public string name { get; set; }
    }
}