using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
   public interface IAccountMember
    {
        bool ApplyMembership(DateTime createDate, int CategoryId);

        double MembershipDiscout(double price);
        bool MemebershipValidity(int Id);
    }
}
