using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_neptune.Models;
using Core_neptune.Models.Context;

namespace Core_neptune.Metiers
{
    public class PersonneRepos : IPersonneRepos
    {
        public Personne Create(Personne personne)
        {
            return personne;
        }

        public IEnumerable<Personne> FindAll()
        {
            IEnumerable<Personne> personnes;

            using (var db = new CoreContext())
            {
                personnes = db.Personne.ToList();
            }

            return personnes;
        }

        public Personne FindID(int PersonneID)
        {
            return new Personne();
        }

        public int Remove(int PersonneID)
        {
            return 2;
        }
    }
}