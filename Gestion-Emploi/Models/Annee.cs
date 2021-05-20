using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Annee
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int AnneeId { get; set; }
    public string Libelle { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }

  }
}