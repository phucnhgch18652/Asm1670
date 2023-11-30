namespace Asm.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Categories { get; set; }

        public string UrlImage { get; set; }

        public string Detail { get; set; }

        public decimal Price { get; set; }
        public string  Author { get; set; }
    }
}
