using System.ComponentModel.DataAnnotations;

namespace Lab7.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }


    }
}
