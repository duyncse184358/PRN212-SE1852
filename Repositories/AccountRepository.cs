using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class AccountRepository
    {
        public AccountMember GetAccountById(string accountId)
            => AccountDAO.GetAccountById(accountId);
    }
}
