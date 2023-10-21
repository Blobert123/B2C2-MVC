using System.ComponentModel.DataAnnotations;

namespace B2C2_2023_Inleveropdracht_MVC.Models
{
    public class Klantenkaart
    {
        [Key]
        public int Id { get; set; }

        public int Punten { get; set; }

        public int Korting { get; set; }
    }
}
