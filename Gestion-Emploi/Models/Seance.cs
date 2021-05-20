using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Seance
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    public int SeanceId { get; set; }

    public string HeurDebut { get; set; }
    public string HeurFin { get; set; }
    public string Jour { get; set; }
  }
}