// Models-Item.cs
using System.ComponentModel.DataAnnotations;

namespace SimpleAPI.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}