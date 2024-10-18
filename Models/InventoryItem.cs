using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class InventoryItem
    {
        [Key]
        public int Id { get; set; }
        public string Employee { get; set; }
        public int Piece { get; set; }
        public string? FilePath { get; set; }
        public DateTime DateTime { get; set; }
    }
}
