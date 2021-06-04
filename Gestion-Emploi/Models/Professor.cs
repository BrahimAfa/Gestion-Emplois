using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace GestionEmploi.Models
{
  public class Professor
  {
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    public int ProfessorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    [ScriptIgnore]
    public List<Cour> Cours { get; set; }


  }
}