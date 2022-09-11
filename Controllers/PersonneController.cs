using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core_neptune.Metiers;
using Core_neptune.Models;
using Core_neptune.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace Core_neptune.Controllers
{
   
    [ApiController]
    [Route("api/personne")]
    public class PersonneController : Controller
    {
        private IPersonneRepos repos = new PersonneRepos();

        public PersonneController()
        {
            Console.WriteLine("Debut du programme...");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personne>>> List()
        {
            List<Personne> personnes = null;
            try{
                personnes = await repos.FindAll();
                if(personnes == null){
                    return NoContent();
                }
            }
            catch(Exception ex){
                Console.WriteLine("Exception from list personne : " + ex.Message);
                return StatusCode(500);
            }            
            return personnes;
        }

        [HttpPost]
        public int Create([FromBody]Personne personne)
        {
            int res = -1;
            try{
                res = repos.Create(personne);
            }
            catch(Exception ex){
                Console.WriteLine("Exception from create personne : " + ex.Message);
            }
        
            return res;
        }

        [HttpPut]
        public int Update([FromBody]Personne personne)
        {
            int res = -1;
            try{
                res = repos.Update(personne);
            }
            catch(Exception ex){
                Console.WriteLine("Exception from update personne: " + ex.Message);
            }
            return res;
        }

        
        [HttpDelete]
        public int Delete(int personneId)
        {
            int res = -1;
            try{
                res = repos.Remove(personneId);
            }
            catch(Exception ex){
                Console.WriteLine("Exception from delete personne : " + ex.Message);
            }       
            return res;
        }
    }
}