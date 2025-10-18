using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models
{
    public class Notes
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string? Title { get; set; }

        [MaxLength(20)]
        public string? Category { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [MaxLength(20)]
        public string? Color { get; set; }

        [Required]
        public string? Content { get; set; }

        public bool IsStar { get; set; } = false;

        [Required]

        public int UserId { get; set; }
        public virtual Users? User { get; set; }
    }
}
