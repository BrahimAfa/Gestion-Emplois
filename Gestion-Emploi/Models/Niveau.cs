using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Niveau
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int NiveauId { get; set; }
    public string Code { get; set; }
    public string libelle { get; set; }

    [ForeignKey("Filiere")]
    public int FiliereId { get; set; }
    public Filiere Filiere { get; set; }



    public virtual List<Emplois> Emplois{ get; set; }
  }
}