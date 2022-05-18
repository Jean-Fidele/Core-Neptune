using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core_neptune.Models
{
    [Table("Etudiant")]
    public class Etudiant
    {
        [Key]
        [Required]
        public int Id {get;set;}

        [Display(Name ="Nom")]
        public String Nom {get;set;}
    }
}