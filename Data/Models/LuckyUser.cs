using Microsoft.AspNetCore.Identity;

namespace Lucky.WebAPI.Data.Models
{
    public class LuckyUser : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public int? Code { get; set; }
    }
}
