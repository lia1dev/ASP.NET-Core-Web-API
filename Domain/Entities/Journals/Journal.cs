using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Journals
{
    public class Journal : BaseEntity
    {
        [Required]
        public long EventId { get; set; }

        [Required]
        public required string Text { get; set; }

        [Required]
        public required string Level { get; set; }
    }
}