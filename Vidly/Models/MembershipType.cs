using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public string Name { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte Monthly = 1;
        public static readonly byte Yearly = 2;
        public static readonly byte Gold = 3;
        public static readonly byte Silver = 4;
    }
}