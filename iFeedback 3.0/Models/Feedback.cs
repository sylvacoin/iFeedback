using System;
using System.ComponentModel.DataAnnotations;

namespace iFeedback.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        [Required]
        [MinLength(6)]
        public string CustomerName { get; set; }
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string CustomerEmail { get; set; }
        [Display(Name = "Phone Number")]
        [Required]
        [MaxLength(13)]
        [MinLength(11)]
        public string CustomerPhone { get; set; }
        [Display(Name ="Rating")]
        [Required]
        public int Rating { get; set; }
        [Display(Name ="Feedback (optional)")]
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public String Ip { get; set; }
        public String Country { get; set; }
        public String Region { get; set; }
        public String City { get; set; }

        //public String Lat { get; set; }
        //public String Long { get; set; }
    }

}
