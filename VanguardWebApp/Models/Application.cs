using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VanguardWebApp.Models
{
    public class Application
    {
        [Required]
        public string CharacterName { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Spec { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Read all the info on the website!")]
        public bool Requirements { get; set; }
    }
}
