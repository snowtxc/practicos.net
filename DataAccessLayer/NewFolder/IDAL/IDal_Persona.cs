using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.NewFolder.DALS;

public interface IDal_Persona
{
    void insert(Persona persona);
    List<Persona> GetPersonas();
}
