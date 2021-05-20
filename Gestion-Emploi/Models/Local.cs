using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Local
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int LocalId{ get ; set; }
    public string Libelle { get; set; }
    public string Type { get; set; }
    public string Capacity { get; set; }
    public string Localisation { get; set; }

    public virtual List<DetailEmplois> DetailEmplois { get; set; }

  }
}