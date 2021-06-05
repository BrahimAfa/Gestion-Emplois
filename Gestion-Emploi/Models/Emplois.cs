using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

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
    public virtual Annee Annee { get; set; }

    [ForeignKey("Semaine")]
    public int SemaineId { get; set; }
    public virtual Semaine Semaine { get; set; }

    [ScriptIgnore]
    public List<DetailEmplois> DetailEmplois { get; set; }

    public override string ToString()
    {
      return $"{NiveauId} ${SemaineId}";
    }
  }
}