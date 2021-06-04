using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Emplois
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int EmploisId { get; set; }

    [ForeignKey("Niveau")]
    public int NiveauId { get; set; }
    public virtual Niveau Niveau{ get; set; }

    [ForeignKey("Annee")]
    public int AnneeId { get; set; }
    public Annee Annee { get; set; }

    [ForeignKey("Semaine")]
    public int SemaineId { get; set; }
    public Semaine Semaine { get; set; }

    public List<DetailEmplois> DetailEmplois { get; set; }

    public override string ToString()
    {
      return $"{NiveauId} ${SemaineId}";
    }
  }
}