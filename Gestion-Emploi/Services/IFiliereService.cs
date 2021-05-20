using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEmploi.Services
{
  public interface IFiliereService : IDAO<Filiere>
  {
    Filiere getByDate(DateTime d);
  }
}