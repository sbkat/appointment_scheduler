using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace event_scheduler.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Display (Name="Email: ")]
        [Required (ErrorMessage = "Enter your email.")]
        [EmailAddress]
        public string loginemail { get; set; }
        [Display (Name="Password: ")]
        [Required (ErrorMessage = "Enter your password.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        public string loginpassword { get; set; }
    }
}