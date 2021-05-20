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
    public string libelle { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }

  }
}