using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace GestionEmploi.Models
{
  public class Local
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int LocalId{ get ; set; }
        [Required]
        public string Libelle { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Capacity { get; set; }
        [Required]
        public string Localisation { get; set; }
    [ScriptIgnore]
    public  List<DetailEmplois> DetailEmplois { get; set; }

  }
}