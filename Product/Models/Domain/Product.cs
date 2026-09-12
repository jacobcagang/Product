using System.ComponentModel.DataAnnotations;

namespace Product.Models.Domain
{
    public class ProductItem
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        [Range(0, 999999)]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int? CategoryId { get; set; }
        public CategoryItem? Category { get; set; }
    }
}