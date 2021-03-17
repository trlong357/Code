using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakingMethodCallsSimpler.Replace_Error_Code_with_Exception
{
    public class ReplaceErrorCodewithException
    {
        private int _balance;
        private int balance;

        ///<exception cref="BalanceException">Thrown when amount > _balance</exception>
        void Withdraw(int amount)
        {
            if (amount > _balance)
            {
                throw new BalanceException();
            }
            balance -= amount;

        }
    }
}
