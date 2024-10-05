namespace expenses_tracker.Models;

public class ReceiptPhoto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Path { get; set; }
}