using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaMVC.Models
{
    public class ArtistCLS
    {
        [Display(Name ="Artista")]
        public string Name { get; set; }
}