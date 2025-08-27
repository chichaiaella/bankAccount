using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bankAccount
{
    public class BankAccount
    {
        private int balanceAccount;
        public int balAccount
        {
            get
            {
                return balanceAccount;
            }
            set
            {
                balanceAccount = value;
            }
        }
        public void exit()
        {
            Console.WriteLine("[ A ] EXIT");
            string selectOpt = Console.ReadLine().ToLower();
             if (selectOpt == "a")
            {
                Console.Clear();
                menu();
            }
            else
            {
                Console.WriteLine("Please Select valid Option");
                exit();
            }
        }
        public void Deposit()
        {    
            Console.Write("Deposit Amount   : ");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            balAccount += depositAmount;
            if (balanceAccount < 0)
            {
                Console.WriteLine("Your Deposit is Invalid");
                balanceAccount = 0;
                Deposit();
            }
            Console.Clear();
            menu();

        }
        public void withdraw()
        {
            int withdrawAmount;

            while (true)
            {
                Console.Write("Withdraw Amount   : ");
                withdrawAmount = Convert.ToInt32(Console.ReadLine());

                if (withdrawAmount <= 0)
                {
                    Console.WriteLine("Please enter a valid positive amount.");
                    continue;
                }

                else if (balAccount < withdrawAmount)
                {
                    Console.WriteLine("Your Withdrawal amount is larger than the Balance");
                    continue;
                }


                balAccount -= withdrawAmount;
                Console.WriteLine($"Withdrawal successful! New balance is {balAccount}");
                Console.Clear();
                menu();
            }
        }
        public void Balance()
        {
            Console.WriteLine("Balance Amount   : " +  balAccount);
            
            exit();
            Console.Clear();
        }
        public void menu()
        {
            Console.WriteLine("Name               : Nigie Tenebroso ");
            Console.WriteLine("Bank Acount number : 241568974565 ");
            Console.WriteLine("[ A ] BALANCE \n[ B ] DEPOSIT \n[ C ] WITHDRAW");
            Console.Write("Please select in Menu ? ");
            string select = Console.ReadLine().ToLower();
            if (select == "a")
            {
                Console.Clear();
                Balance();
            }
            else if (select == "b")
            {
                Console.Clear();
                Deposit();
            }
            else if (select == "c")
            {
                Console.Clear();
                withdraw();
            }
            


        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.menu();
        }
    }
}
