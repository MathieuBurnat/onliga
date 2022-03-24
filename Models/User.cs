using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace onliga.Models;

public class User : IdentityUser<string>
{
    [Required]
    public string Pseudo { get; set; }
}

