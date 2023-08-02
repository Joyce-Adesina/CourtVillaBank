using CourtVillaBank.Model.Model;

namespace CourtVillaBank.Repository.Repository.Abstraction
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        Task<Transaction> GetTransactionById(int id);
        Task<IEnumerable<Transaction>> GetAllAccountTransaction(string accountNumber);
        Task<IEnumerable<Transaction>> GetAllTransaction();
        IEnumerable<Transaction> GetAllDailyTransactions(DateOnly date);
    }
}
