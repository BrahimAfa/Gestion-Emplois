using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Cour
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

    public int CourId { get; set; }

        [Required]
        public string Libelle { get; set; }
        [Required]
        public int ResponsableId { get; set; }

        [ForeignKey("ResponsableId")]
        public virtual Professor Responsable { get; set; }
        [Required]
        [ForeignKey("Niveau")]
    public int NiveauId { get; set; }
    public virtual Niveau Niveau { get; set; }

    public virtual List<DetailEmplois> DetailEmplois { get; set; }


  }
}