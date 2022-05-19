using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_neptune.Metiers;
using Core_neptune.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_neptune.Controllers
{
   
    [ApiController]
    [Route("api/personne")]
    public class PersonneController : Controller
    {
        
        IPersonneRepos repos = new PersonneRepos();

        public PersonneController()
        {
            
        }

        [Route("")]
        public IEnumerable<Personne> List()
        {
            return repos.FindAll();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}