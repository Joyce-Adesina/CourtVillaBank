using CourtVillaBank.Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourtVillaBank.Model.Model
{
    public class Transaction : AuditableBaseEntity
    {
        public string AcountNumber { get; set; }
        public int TransactionId { get; set; }
        public string ReceipientAccountNumber { get; set; }
        public string TransactionDescription { get; set; }
        public TransactionTypes TransactionTypes { get; set; }
        [Column(TypeName = "Money")]
        public decimal Amount { get; set; }
        public Status Status { get; set; }
        public DateTime DateTime { get; set; }
       
        

        //Navigational properties 
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
