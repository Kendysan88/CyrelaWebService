using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class AddressState : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Uf { get; set; }
    }
}
