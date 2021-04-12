using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class ActivityType : BaseEntity
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public int WarrantyInYears { get; set; }
    }
}
