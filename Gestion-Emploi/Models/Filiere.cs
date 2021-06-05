using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Filiere
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    [Key]
    public int FiliereId { get; set; }
    [Required( ErrorMessage = "Please Provide Last Name")]
        public string Libelle { get; set; }

  }
}