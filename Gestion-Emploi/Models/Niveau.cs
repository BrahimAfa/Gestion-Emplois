using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Niveau
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int NiveauId { get; set; }
        [Required]
    public string Code { get; set; }
        [Required]
        public string libelle { get; set; }

    [ForeignKey("Filiere")]
        [Required]
        public int FiliereId { get; set; }
    public virtual Filiere Filiere { get; set; }

    public virtual List<Emplois> Emplois{ get; set; }
  }
}