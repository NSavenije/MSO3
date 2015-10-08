using System;
using System.Windows.Forms;

namespace Lab3
{
   public class CoinMachineAdap
   {
      IKEAMyntAtare2000 coin = new IKEAMyntAtare2000();
      public void start()
      {
         coin.starta();
      }

      public void stop()
      {
         coin.stoppa();
      }

      public void pay(float price)
      {

         coin.betala((int)Math.Round(price * 100));
      }
   }
}

