using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Contact : CoreEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Surname { get; set; } = string.Empty;

        [Required(ErrorMessage = "E-posta alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin.")]
        public string Email { get; set; } = string.Empty;
        public string Messages { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public bool Read { get; set; }
    }
}
