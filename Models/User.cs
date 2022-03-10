using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public string Pseudo { get; set; }

    // public DateTime Test { get; set; }

    public IdentityUser CreateUser()
    {
        try
        {
            return Activator.CreateInstance<User>();
        }
        catch
        {
            throw new InvalidOperationException($"Can't create an instance of '{nameof(User)}'. " +
                $"Ensure that '{nameof(User)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
        }
    }
}