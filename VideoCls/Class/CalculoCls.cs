using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCls.Class
{
    public class CalculoCls
    {
        public int IdClient { get; set; }
        public Decimal LateFee { get; set; }
        public Decimal Discount { get; set; }


        public Decimal AddDiscount(int mIdClient, Decimal mcost)
        {
            Discount = mcost - 1;

            return Discount;
        }

        public Decimal AddLateFee(int mIdClient, Decimal mcost)
        {

            LateFee = mcost + (mcost * (10/100));

            return LateFee;
        }
    }
}
