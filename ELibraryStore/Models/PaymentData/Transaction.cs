using System.ComponentModel.DataAnnotations;

namespace ELibraryStore.Models.PaymentData
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string? ShoppingCartId { get; set; } = "";
        public string Email { get; set; }
        public string TransactionReference { get; set; }
        public string Amount { get; set;  }
        public bool Status { get; set; } = true;
        public string Channel { get; set; } = "";
    }
}
