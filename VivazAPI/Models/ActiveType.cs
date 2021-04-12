using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VivazAPI.Models
{
    public class ActiveType : BaseEntity
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public int WarrantyInYears { get; set; }
    }
}
