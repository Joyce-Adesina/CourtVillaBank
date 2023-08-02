using CourtVillaBank.Model.Model;
using CourtVillaBank.Repository.Data;
using CourtVillaBank.Repository.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace CourtVillaBank.Repository.Repository.Implementation
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<Transaction> _transactions;

        public TransactionRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
            _transactions = _appDbContext.Set<Transaction>();
        }
        public async Task <Transaction> GetTransactionById(int id)
        {
            return await _transactions.Where(a => a.AccountId == id).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Transaction>> GetAllAccountTransaction(string accountNumber)
        {
            return await _transactions.Where(t => t.AcountNumber == accountNumber)
                .ToListAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllTransaction()
        {
           return await _transactions.ToListAsync();
           
        }

        public IEnumerable<Transaction> GetAllDailyTransactions(DateOnly date)
        {
            DateTime dateTime = date.ToDateTime(TimeOnly.MinValue);
            return  _transactions.Where(t => t.DateTime == dateTime).ToList();  
        }

    }
} 
      