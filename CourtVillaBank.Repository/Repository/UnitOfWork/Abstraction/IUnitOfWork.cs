using CourtVillaBank.Repository.Repository.Abstraction;

namespace CourtVillaBank.Repository.Repository.UnitOfWork.Abstraction
{
    public interface IUnitOfWork
    {
        IAccountRepository AccountRepository { get; }
        IUserRepository UserRepository { get; }
        ITransactionRepository TransactionRepository { get; }
        Task SaveAsync();
        void Dispose();
    }
}
