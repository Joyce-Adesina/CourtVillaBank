using CourtVillaBank.Core.Services.Abstraction;
using CourtVillaBank.Model.Enum;
using CourtVillaBank.Model.Model;
using CourtVillaBank.Repository.Repository.UnitOfWork.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourtVillaBank.Core.Services.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Account> CreateAccount(int userid,string firstName,string LastName,string email,int transactionPin,string phoneNumber,string accountType)
        {
            _unitOfWork.AccountRepository.VerifyAccount
           {
                return await _unitOfWork.AccountRepository.VerifyAccount(accountNumber);
           }
            
            

            Account account = new 
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                TransactionPin = transactionPin,
                PhoneNumber = phoneNumber,
                AccountType = accountType.ToLower() =="current" ? AccountType.Current : AccountType.Saving,
                MinBalance = AccountType.ToLower() == "current" ? 0:1000,
                AccountNumber = Utilities.Generate100DigitsAccountNumber()

            };
           
        public async Task DeleteAccount(string accountNumber)
        {
            Account account = await GetAccount(accountNumber);
            _unitOfWork.AccountRepository.Delete(account);
            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();
        }
         public async Task ()
    }
}
    


