using System.ComponentModel.DataAnnotations;

namespace TheNew1.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name of the Book")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Category of the book")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter price of the book")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Please enter Author of the book")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter picture of the book")]
        public string Picture { get; set; }
    }
}
