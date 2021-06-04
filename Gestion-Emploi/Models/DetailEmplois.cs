using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class DetailEmplois
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int DetailEmploisId { get; set; }

    [Required]
    [ForeignKey("Emplois")]
    public int EmploisId { get; set; }
    public Emplois Emplois{ get; set; }

    [Required]
    [ForeignKey("Seance")]
    public int SeanceId { get; set; }
    public virtual Seance Seance { get; set; }

    [Required]
    [ForeignKey("Local")]
    public int LocalId { get; set; }
    public virtual Local Local { get; set; }

    [Required]
    [ForeignKey("Cour")]
    public int CourId { get; set; }
    public virtual Cour Cour { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now; // default

    public override string ToString()
    {
      return $"{SeanceId} ${LocalId}";
    }

  }
}