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
        string AlbumName { get; set; }

        [Display(Name = "Fecha de Salida")]
        DateTime DateReleased { get; set; }

        [Display(Name = "Id de Artista")]
        int ArtistID { get; set; }

        [Display(Name = "Id de Genero")]
        int GenreID { get; set; }

    }
}