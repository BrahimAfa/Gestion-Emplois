using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Semaine
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]


    public int SemaineId { get; set; }
        [Required]
        public string libelle { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime DateDebut { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime DateFin { get; set; }

  }
}