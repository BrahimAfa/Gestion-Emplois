using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class Professor
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    public int ProfessorId { get; set; }
      [Required]
      public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }

    public virtual List<Cour> Cours { get; set; }


  }
}