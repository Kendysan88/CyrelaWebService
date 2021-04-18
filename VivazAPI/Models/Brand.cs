using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class Brand : BaseEntity
    {
        // TODO: use enum
        [Required]
        public string Title { get; set; }
    }
}
