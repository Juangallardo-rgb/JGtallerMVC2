using System.ComponentModel.DataAnnotations;

namespace JGtallerMVC2.Models
{
    public class Burger
    {
            public int BurgerId { get; set; }

            [Required]
            public string? Name { get; set; }
            public bool WithCheese { get; set; }
            

        [Range(0.01, 9999.99)]
            public decimal Price { get; set; }         
        
    }
}
