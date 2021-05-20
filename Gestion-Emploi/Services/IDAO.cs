using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploi.Services
{
  public interface IDAO<T>
  {
    T getById(int id);  
    List<T> getAll();
    bool delete(int id);
    bool update(T entity);
    bool create(T entity);

  }
}
