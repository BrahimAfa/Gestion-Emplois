using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Group
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int GroupId { get; set; }
    public string Libelle { get; set; }

  }
}