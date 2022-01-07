using System;
using System.ComponentModel.DataAnnotations;

namespace bianchi.monica._5H.PrimaWeb.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        [Required(ErrorMessage ="Inserisci una Email valida")]
        [EmailAddress]
        public string Email { get; set; } 

        
    }
}
