using CourtVillaBank.Repository.Data;
using CourtVillaBank.Repository.Repository.Abstraction;
using CourtVillaBank.Repository.Repository.Implementation;
using CourtVillaBank.Repository.Repository.UnitOfWork.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace CourtVillaBank.Repository.Repository.UnitOfWork.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private IAccountRepository _accountRepository;
        private IUserRepository _userRepository;
        private ITransactionRepository _transactionRepository;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_appDbContext);
        public IAccountRepository AccountRepository => _accountRepository ?? new AccountRepository(_appDbContext);
        public ITransactionRepository TransactionRepository => _transactionRepository ?? new TransactionRepository(_appDbContext);

        public async Task SaveAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _appDbContext?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
    