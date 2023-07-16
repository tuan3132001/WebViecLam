using System.ComponentModel.DataAnnotations;
namespace WebViecLam.Models
{
    public class Company
    {
        [Key ]
        public int CompanyId { get; set; }
        [Required]
        public string? CompanyName { get; set; }
        [StringLength(500)]
        public string? CompanyDescription { get; set; }
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string? Email { get; set; }
        [StringLength(50)]
        public string?  CompanyImage  { get; set;}

        public ICollection<Job>? Jobs { get; set; }
    }
}
