
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NewFolder.DALS
{
    public class DAL_Persona : IDal_Persona
    {

        private List<Persona> personas = new List<Persona>();


        public void insert(Persona persona)
        {
            this.personas.Add(persona);
        }
        public List<Persona> GetPersonas()
        {
            return this.personas;

        }

    }
}
