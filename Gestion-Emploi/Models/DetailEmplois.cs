using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class DetailEmplois
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int DetailEmploisId { get; set; }

    [ForeignKey("Emplois")]
    public int EmploisId { get; set; }
    public Emplois Emplois{ get; set; }
    
    [ForeignKey("Seance")]
    public int SeanceId { get; set; }
    public Seance Seance { get; set; }

    [ForeignKey("Local")]
    public int LocalId { get; set; }
    public Local Local { get; set; }

    [ForeignKey("Cour")]
    public int CourId { get; set; }
    public Cour Cour { get; set; }

    public DateTime CreatedAt { get; set; } // default

  }
}