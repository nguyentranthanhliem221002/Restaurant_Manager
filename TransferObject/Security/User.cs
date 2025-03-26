﻿using System.ComponentModel.DataAnnotations;

namespace TransferObject.Security
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [MaxLength(10)]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Số điện thoại phải có 10 chữ số.")]
        public string? Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
