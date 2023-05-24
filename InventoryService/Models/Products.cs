using System.ComponentModel.DataAnnotations;

namespace InventoryService.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string?  Name { get; set; }
        public string? Category { get; set; }
        public string? Color { get; set; }
        public decimal UnitPrice { get; set; }
        public int AvailableQuantity { get; set; }

    }
}

