using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public string Pseudo { get; set; }
}