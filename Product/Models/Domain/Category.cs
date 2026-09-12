using System.ComponentModel.DataAnnotations;

namespace Product.Models.Domain
{
    public class CategoryItem
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public List<ProductItem> Products { get; set; } = new();
    }
}