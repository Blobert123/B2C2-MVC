using System.ComponentModel.DataAnnotations;

namespace B2C2_2023_Inleveropdracht_MVC.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }
    }
}
