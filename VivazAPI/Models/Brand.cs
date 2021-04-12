using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VivazAPI.Models
{
    [Table("brands")]
    public class Brand : BaseEntity
    {
        // TODO: use enum
        [Required]
        public string Title { get; set; }
    }
}
