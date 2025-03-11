using System.ComponentModel.DataAnnotations;

namespace MVC_Agile_Process.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }  // Added Price to match the controller
    }
}
