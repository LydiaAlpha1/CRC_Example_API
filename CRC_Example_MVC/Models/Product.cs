using System.ComponentModel.DataAnnotations;

namespace CRC_Example_MVC.Models
    {
      public class Product
        {
            [Required]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; } = null!;
            [Required]
            public decimal Price { get; set; }

        }
    }

