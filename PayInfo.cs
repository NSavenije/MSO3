using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
class PayInfo
   {
      public void payCredit(float price, UIPayment payMethod)
      {
         CreditCard c = new CreditCard ();
				c.Connect ();
				int ccid = c.BeginTransaction (price + 0.50f);
				c.EndTransaction (ccid);
      }
      
      public void payDebit(float price, UIPayment payMethod)
     {
        DebitCard d = new DebitCard();
        d.Connect();
        int dcid = d.BeginTransaction(price);
        d.EndTransaction(dcid);
     }

      public void payCash(float price, UIPayment payMethod)
      {
         CoinMachineAdap coin = new CoinMachineAdap();
         coin.start();
         coin.pay(price);
         coin.stop();
      }
      
   }
}
