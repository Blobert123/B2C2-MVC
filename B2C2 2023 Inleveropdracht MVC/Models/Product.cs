using System.ComponentModel.DataAnnotations;    

namespace B2C2_2023_Inleveropdracht_MVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Naam { get; set; }

        [Required]
        public int Prijs { get; set; }

        [Required]
        public string? Beschrijving { get; set; }
    }
}
