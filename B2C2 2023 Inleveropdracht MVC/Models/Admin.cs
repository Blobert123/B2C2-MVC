using System.ComponentModel.DataAnnotations;

namespace B2C2_2023_Inleveropdracht_MVC.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Naam { get; set; }

        [Required]
        public string? Wachtwoord { get; set; }
    }
}
