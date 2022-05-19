using System.ComponentModel.DataAnnotations;

namespace CardBoxWeb.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Username { get; set; }
        public int DisplayOrder { get; set; }
    }
}
