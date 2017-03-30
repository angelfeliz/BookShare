using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Contracts;

namespace BusinessLayer
{
    public class NotMemebership : IAccountMember
    {
        public bool ApplyMembership(DateTime createDate, int CategoryId)
        {
            throw new NotImplementedException();
        }

        public double MembershipDiscout(double price)
        {
            return 0;
        }

        public bool MemebershipValidity(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
