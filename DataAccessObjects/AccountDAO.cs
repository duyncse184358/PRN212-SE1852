using BusinessObjects;

namespace DataAccessObjects
{
    public partial class AccountDAO
    {
        public static AccountMember GetAccountById(String accountID)
        {
            AccountMember accountMember = new AccountMember();
            if (accountID.Equals("PS0001"))
            {
                accountMember.MemberId = accountID;
                accountMember.MemberPassword = "@1";
                accountMember.MemberRole = 1;
            }
            return accountMember;
        }

    }
}
