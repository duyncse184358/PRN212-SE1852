using BusinessObjects;
using Repositories;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository iAccountReposirory;

        public AccountService()
        {
            iAccountReposirory = new AccountRepository();
        }
        public AccountMember GetAccountById(string accountID)
        {
            return iAccountReposirory.GetAccountById(accountID);
        }
    }
}
