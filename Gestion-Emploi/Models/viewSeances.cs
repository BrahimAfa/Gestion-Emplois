using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class viewSeances
  {
    public HashSet<string> seances { get; set; } = new HashSet<string>();
    public Dictionary<string, HashSet<viewseanceForDay>>  seanceByDay{ get; set; } = new Dictionary<string, HashSet<viewseanceForDay>>();

  }

  public class viewseanceForDay:IEqualityComparer<viewseanceForDay>
  {
    public string name { get; set; }
    public int id { get; set; }
    public DetailEmplois Detail { get; set; }



    public new bool Equals(viewseanceForDay x, viewseanceForDay y)
    {
      return x.name.Equals(y.name, StringComparison.InvariantCultureIgnoreCase);
    }

    public int GetHashCode(viewseanceForDay obj)
    {
      return obj.name.GetHashCode();
    }
  }
}