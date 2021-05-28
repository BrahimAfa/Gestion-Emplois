using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploi.Services
{
    public interface ISemaineService:IDAO<Semaine>
    {
        void UpdateId(int id);
    }
}
