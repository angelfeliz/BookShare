using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Contracts;

namespace BusinessLayer
{
    public class MembershipFactory : IMemeberFactory
    {
        public enum  MembershiptCategory {
            Standard = 1,
            Premium,
            VIP
        }
        public IAccountMember GetAccountMemeber(int memberTypeId)
        {
            IAccountMember accountMember;
            
            switch (memberTypeId) {
                case (int)MembershiptCategory.Standard :
                    accountMember = new StandardMembership();
                break;

                case (int)MembershiptCategory.Premium :
                    accountMember = new PremiumMembership();
                break;

                case (int)MembershiptCategory.VIP :
                    accountMember = new VipMembership();
                break;
                default:
                    accountMember = new NotMemebership();
                break;
            }

            return accountMember;
        }
    }
}
