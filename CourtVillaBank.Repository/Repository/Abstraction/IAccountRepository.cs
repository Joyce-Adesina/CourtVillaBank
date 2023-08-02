using CourtVillaBank.Model.Model;

namespace CourtVillaBank.Repository.Repository.Abstraction
{
    public interface IAccountRepository : IGenericRepository<Account>
    {



        Task<Account> GetAccountById(int id);
        Task<IEnumerable<Account>> GeAlltAccountUser();
        Task<Account> GetAccountsByUserId(int id);
        Task<string> VerifyAccount(string accountNumber);
        
    }
}
