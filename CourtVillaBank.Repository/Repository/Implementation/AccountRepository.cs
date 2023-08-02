using CourtVillaBank.Model.Model;
using CourtVillaBank.Repository.Data;
using CourtVillaBank.Repository.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace CourtVillaBank.Repository.Repository.Implementation
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Account> _accounts;

        public AccountRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _accounts = context.Set<Account>();
        }

        public async Task<Account> GetAccountByAccountNumber(string accountNumber)
        {
            return await  _accounts.Where(x => x.AccountNumber == accountNumber && x.IsActive)
                 .Include(x => x.Transactions).SingleOrDefaultAsync();
        }
        public async Task<Account> GetAccountById(int id)
        {
            return await _accounts.Where(a => a.Id == id && a.IsActive)
             .Include(a => a.Transactions).FirstOrDefaultAsync();

        }


        public async Task<IEnumerable<Account>> GeAlltAccountUser()
        {
            return await _accounts.Include(a => a.Transactions).ToListAsync();
        }


        public async Task<Account> GetAccountsByUserId(int id)
        {
            Account accounts = await _accounts.Include(x => x.Transactions).SingleOrDefaultAsync(x => x.UserId == id);
            return accounts;
        }
        public async Task<string> VerifyAccount(string accountNumber)
        {
            return await _accounts.Where(a => a.AccountNumber == accountNumber && a.IsActive).Select(a => a.FirstName + " " + a.LastName).FirstOrDefaultAsync();
        }

    }
}
