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
        public Decimal RentQty { get; set; }
        public Decimal rentCost { get; set; }
        public int timeSpan { get; set; }
        public TimeSpan tempDate { get; set; }


        public Decimal AddDiscount(int mIdClient, Decimal mQty )
        {
            VideoCls.Class.ClientCls clientCls = new ClientCls();

            mIdClient = clientCls.IdClient;
            clientCls.SearchClient();
            RentQty = mQty + clientCls.Qty;

            if (RentQty >= 10)
            {
                RentQty = Math.Truncate((mQty / 5))- mQty;

                Discount = RentQty * 1000;

                return rentCost;
    
            }

            Discount = mQty * 1000;

            return Discount;
        }

        public Decimal AddLateFee(Decimal mcost, DateTime mDate)
        {
            
            tempDate = mDate.Subtract(DateTime.Today);
            
            
            LateFee = Convert.ToDecimal(tempDate.TotalDays) * (mcost + (mcost * (10/100)));

            return LateFee;
        }
    }
}
