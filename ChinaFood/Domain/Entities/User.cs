using Microsoft.AspNetCore.Identity;

namespace ChinaFood.Domain.Entities;
public class User : IdentityUser
{
    public string Avatar { get; set; }
}