using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    // Table class.
    public class Category 
    {
        // Columns and HTTP verbs.
        [Key] // <--- Primary key recognizes the line below this.
        public int Id { get; set; }
        [Required] 
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}