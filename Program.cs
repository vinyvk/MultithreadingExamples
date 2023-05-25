using System;
using System.Threading;

namespace Thread_C_
{
    class Program
    {
        static  void Main(string[] args)
        {
            Account user1=new Account(101,2500);//amend chnge
            Account user2=new Account(102,2400);

            Console.WriteLine("Enter amount to send:");
            double amount=Convert.ToDouble(Console.ReadLine());

            AccountManage mgr1=new AccountManage(user1,user2,amount);
            AccountManage mgr2=new AccountManage(user2,user1,amount);
            Console.WriteLine("---------------------------BEFORE--------------------------------");
            Account.details(user1);
            Account.details(user2);
            
            Thread t1=new Thread(mgr1.Transfer);t1.Name="User1";
            Thread t2=new Thread(mgr2.Transfer);t2.Name="User2";
            t1.Start();t2.Start();
            t1.Join();t2.Join();

            Console.WriteLine("---------------------------AFTER--------------------------------");
            Account.details(user1);
            Account.details(user2);
        }
    }
}
