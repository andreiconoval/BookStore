using System.ComponentModel.DataAnnotations;

namespace BookStore.API.DTOs
{
    public class UserForRegistration
    {
        [Required]
        public string username { get; set; }

        [Required]
        [StringLength(8,MinimumLength=4, ErrorMessage = "You should specify password between 4 and 8 characters")]
        public string password { get; set; }
    }
}