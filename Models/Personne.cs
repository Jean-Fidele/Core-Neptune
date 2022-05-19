using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core_neptune.Models
{
    [Table("Personne")]
    public class Personne
    {
        public Personne() {
            Hobbies= new List<Hobbie>();
        }

        [Key]
        [Required]
        public int Id {get;set;}

        [Display(Name ="Nom")]
         [Required]
        public String Nom {get;set;}

        [Display(Name ="Prenom")]
        public String? Prenom {get;set;}

        [Required]
        [Display(Name ="DateNaissance")]
        public DateTime DateNaissance {get;set;}

        public virtual List<Hobbie> Hobbies {get;set;}
    }
}