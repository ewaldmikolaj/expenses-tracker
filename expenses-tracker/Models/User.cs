using System.ComponentModel.DataAnnotations;

namespace expenses_tracker.Models;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Email { get; set; }
    [DataType(DataType.Password)]
    public required string Password { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}