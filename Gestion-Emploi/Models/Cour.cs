using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Cour
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int CourId { get; set; }
    public string Libelle { get; set; }

    public int ResponsableId { get; set; }

    [ForeignKey("ResponsableId")]
    public virtual Professor Responsable { get; set; }

    [ForeignKey("Niveau")]
    public int NiveauId { get; set; }
    public virtual Niveau Niveau { get; set; }

    public virtual List<DetailEmplois> DetailEmplois { get; set; }


  }
}