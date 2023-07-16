using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebViecLam.Models
{
    public class Job
    {

        [Key]
        public int JobId { get; set; }
        [StringLength(50)]
        public string? JobName { get; set; }
        [StringLength(500)]
        public string? JobDescription { get; set; }
        [Required]
        public string? JobStatus { get; set; }
        [Required]
        public DateTime JobCreated { get; set; } = DateTime.Now;
        [Required]
        public int  JobQuantity { get; set; }

        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        
    }
}
