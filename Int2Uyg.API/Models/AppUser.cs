using Microsoft.AspNetCore.Identity;

namespace Int2Uyg.API.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
