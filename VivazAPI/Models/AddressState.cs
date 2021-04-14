using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class AddressState
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Uf { get; set; }
    }
}
