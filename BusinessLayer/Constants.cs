using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class Constants
    {
        public const int DISCOUNT_FOR_STANDARD_MEMBERSHIP = 10;
        public const int DISCOUNT_FOR_PREMIUM_MEMBERSHIP = 15;
        public const int DISCOUNT_FOR_VIP_MEMBERSHIP = 20;
        public enum MembershiptCategory
        {
            Standard = 1,
            Premium,
            VIP
        }
    }
}
