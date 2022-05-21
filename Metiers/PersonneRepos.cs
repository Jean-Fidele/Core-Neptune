using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core_neptune.Models;
using Core_neptune.Models.Context;

namespace Core_neptune.Metiers
{
    public class PersonneRepos : IPersonneRepos
    {
        public Task<List<Personne>> FindAll()
        {
            Task<List<Personne>> personnes = null;
            using (var db = new CoreContext())
            {
                personnes = db.Personne.Include(x=>x.Hobbies).ToListAsync();
            }
            return personnes;
        }

        public int Create(Personne personne)
        {
            int res = -1;
            using (var db = new CoreContext())
            {
                Personne pers_to_check = db.Personne.FirstOrDefault(p => p.Id == personne.Id); //Retourne la personne si il existe ou null si non
                if(pers_to_check == null){
                    db.Personne.Add(personne);
                    res = db.SaveChanges();
                    Console.WriteLine("Create OK.");
                }
            }
            return res;
        }


        public int Remove(int PersonneID)
        {
            int res = -1;
            using (var db = new CoreContext())
            {
                Personne pers_to_delete = db.Personne.Include(x=>x.Hobbies).Single(p => p.Id == PersonneID); //Retourne la personne si il existe ou null si non
                if(pers_to_delete != null){
                    List<Hobbie> hobbies = pers_to_delete.Hobbies; 
                    db.Hobbie.RemoveRange(hobbies);
                    db.Personne.Remove(pers_to_delete);
                    res = db.SaveChanges();
                    Console.WriteLine("Delete OK.");
                }
            }
            return res;
        }

        public int Update(Personne personne)
        {
            int res = -1;
            Personne pers_to_update =null;

            using (var db1 = new CoreContext())
            {
                pers_to_update = db1.Personne.Find(personne.Id);
            }

            using (var db = new CoreContext())
            {
                if(pers_to_update != null){
                    db.Personne.Update(personne);
                    res = db.SaveChanges();
                    Console.WriteLine("Update OK");
                }
            }
            return res;
        }
    }
}