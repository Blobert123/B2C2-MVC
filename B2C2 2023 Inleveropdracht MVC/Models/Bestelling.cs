using System.ComponentModel.DataAnnotations;

namespace B2C2_2023_Inleveropdracht_MVC.Models
{
    public class Bestelling
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int TotaalPrijs { get; set; }

        public int KlantId { get; set; }

        public int Punten { get; set;}
    }
}
