using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models;

public class User
{
    public int Id { get; set; }

    [Column("User_Name")]
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
