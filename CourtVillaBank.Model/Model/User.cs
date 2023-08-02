namespace CourtVillaBank.Model.Model
{
    public class User : AuditableBaseEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        
        //Nav properties
        public ICollection<Account> Accounts { get; set; }

    }
}
