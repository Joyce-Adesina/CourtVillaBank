using CourtVillaBank.Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourtVillaBank.Model.Model
{
    public class Account : AuditableBaseEntity
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int TransactionPin { get; set; }
        public AccountType AccountType { get; set; }
        [Column(TypeName = "Money")]
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public string PhoneNumber { get; set; }
               

        //Navigation Property
       public ICollection<Transaction> Transactions { get; set; }
        public bool IsActive { get; set; }
    }
}
