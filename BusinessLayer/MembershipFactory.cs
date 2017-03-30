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
       
        public IAccountMember GetAccountMemeber(int memberTypeId)
        {
            IAccountMember accountMember;
            
            switch (memberTypeId) {
                case (int)Constants.MembershiptCategory.Standard :
                    accountMember = new StandardMembership();
                break;

                case (int)Constants.MembershiptCategory.Premium :
                    accountMember = new PremiumMembership();
                break;

                case (int)Constants.MembershiptCategory.VIP :
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
