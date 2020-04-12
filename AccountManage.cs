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
        //Dead lock solution 
        public void Transfer()
        {
            object lock1,lock2;
            if( FromAccount.Id < ToAccount.Id )
            {
                lock1=FromAccount;lock2=ToAccount;
            }
            else
            {
                lock1=ToAccount;lock2=FromAccount;
            }
            lock(lock1)
            {
                Thread.Sleep(1000);
                 lock(lock2)
                {
                   FromAccount.withDraw(amountTransfer);
                    ToAccount.deposit(amountTransfer);
                    WriteLine("Amount "+amountTransfer+" transfered from "+FromAccount.Id.ToString()+ " to "+ToAccount.Id.ToString());
                }
            }
        }
    }
}