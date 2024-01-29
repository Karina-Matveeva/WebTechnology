using Microsoft.AspNetCore.Identity;

namespace WebTechnology.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[]? AvatarImage { get; set; }
    }
}
