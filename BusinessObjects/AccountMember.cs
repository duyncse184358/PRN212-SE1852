using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class AccountMember
    {
        public String MemberId { get; set; }
        public String MemberPassword { get; set; }
        public String FullName { get; set; }

        public String EmailAddress { get; set; }
        public int? MemberRole { get; set; }

    }
}
