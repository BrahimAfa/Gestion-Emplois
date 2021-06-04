using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Models
{
  public class CrossRefEmploisDetail
  {
    public Emplois emplois { get; set; }
    public List<DetailEmplois> detailEmplois { get; set; }
  }
}