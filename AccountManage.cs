using System.Threading;
using static System.Console;

namespace Thread_C_
{
    class AccountManage
    {
        public Account FromAccount{get;set;}
        public Account ToAccount{get;set;}
        public double amountTransfer{get;set;}
        public AccountManage(Account from,Account to,double amount)
        {
            FromAccount=from;
            ToAccount=to;
            amountTransfer=amount;
        }
        //Dead lock situation 
        public void Transfer()
        {
            lock(FromAccount)
            {
                Thread.Sleep(1000);
                 lock(ToAccount)
                {
                   FromAccount.withDraw(amountTransfer);
                    ToAccount.deposit(amountTransfer);
                    WriteLine("Amount "+amountTransfer+" transfered from "+FromAccount.Id.ToString()+ " to "+ToAccount.Id.ToString());
                }
            }
        }
    }
}