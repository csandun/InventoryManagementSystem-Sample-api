using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{    
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(4)]
        public string Type { get; set; }
    }
}
