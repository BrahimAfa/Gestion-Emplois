using GestionEmploi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploi.Services
{
  public  interface IProfessorService:IDAO<Professor>
    {
        Professor getByFirstName(string firstName);
        Professor getByLastName(string lastName);
        Professor getByEmail(string Email);
    }
}
