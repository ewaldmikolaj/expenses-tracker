using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expenses_tracker.Models;

public class Expense
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public decimal Amount { get; set; }
    [ForeignKey("ReceiptPhoto")]
    public ReceiptPhoto? ReceiptPhotoId { get; set; }
    public virtual ReceiptPhoto? ReceiptPhoto { get; set; }
}