using System.ComponentModel.DataAnnotations;

namespace expenses_tracker.Models;

public class Expense
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public decimal Amount { get; set; }
    public Guid? ReceiptPhotoId { get; set; }
}