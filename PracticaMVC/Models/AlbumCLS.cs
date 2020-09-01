using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaMVC.Models
{
    public class AlbumCLS
    {
        [Display(Name ="Nombre del Album")]
        public string AlbumName { get; set; }

        [Display(Name = "Fecha de Salida")]
        public DateTime DateReleased { get; set; }

        /*[Display(Name = "Id de Artista")]
        public int ArtistID { get; set; }

        [Display(Name = "Id de Genero")]
        public int GenreID { get; set; }*/

    }
}