using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class User : BaseEntity, IValidatableObject
    {
        //[Required]
        public string Email { get; set; }

        //[Required]
        public string Password { get; set; }

        //[Required]
        public string Role { get; set; }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(this.Password))
            {
                yield return new ValidationResult("A Senha não pode ser nula ou vazia e é obrigatória", new[] { nameof(Password) });
            }
        }
    }
}
