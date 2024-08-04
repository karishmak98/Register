using System.ComponentModel.DataAnnotations;

namespace RegisterForm.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Display(Name="Address")]
        public string ImageURL { get; set; }
    }
}
