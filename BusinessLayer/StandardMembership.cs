using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Contracts;

namespace BusinessLayer
{
    public class StandardMembership : IAccountMember
    {
        public double MembershipDiscout(double price)
        {
            return ((price * Constants.DISCOUNT_FOR_STANDARD_MEMBERSHIP) / 100);
        }

        public bool ApplyMembership(DateTime createDate, int CategoryId)
        {
            throw new NotImplementedException();
        }
                
        public bool MemebershipValidity(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
