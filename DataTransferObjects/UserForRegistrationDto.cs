using System.ComponentModel.DataAnnotations;

namespace Lucky.WebAPI.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; init; }

        [Required(ErrorMessage = "Username is required")]
        public string? UserName { get; init; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; init; }
        
        public DateOnly? DateOfBirth { get; init; }
        
        public string? PhoneNumber { get; init; }
        
        public bool AgreedTANDC { get; init; }
        
        public ICollection<string>? Roles { get; init; }
    }
}
