using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_neptune.Models;

namespace Core_neptune.Metiers
{
    public interface IPersonneRepos
    {
        public IEnumerable<Personne> FindAll();

        public int Create(Personne personne);

        public int Remove(int PersonneID);

        public int Update(Personne personne);
    }
}