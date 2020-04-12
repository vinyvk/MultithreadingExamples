using System;

namespace Thread_C_
{
    class Account
    {
        public  int Id{get;set;}
        public  double Balance{set;get;}
        public Account(int Id,double Balance)
        {
            this.Id=Id;
            this.Balance=Balance;
        }
        public void withDraw(double amount)
        {
            Balance-=amount;
        }
        public void deposit(double amount)
        {
            Balance+=amount;
        }
        public static void details(Account acc)
        {
            Console.WriteLine("Account Details......");
            Console.WriteLine("Account ID:"+acc.Id);
            Console.WriteLine("Balance   :"+acc.Balance);
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}