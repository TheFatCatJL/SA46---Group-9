using System;
using System.Collections;
using System.Text;

namespace ISSBank
{
    class UserMainMenu
    {
        ArrayList AccountList;
        public UserMainMenu(ArrayList accountlist) { AccountList = accountlist; }
        public int[] UserMainMenuScreen(Customer customerA)
        {
            string userinput = "";
            int userinputint = 1;
            int count = 0;
            int[] arrayIndex = new int[10];
            do
            {
                do
                {
                    count = 0;
                    Console.Clear();
                    Console.WriteLine("********************************************************************************");
                    Console.WriteLine("Welcome to ISS Bank. How can we serve you today, {0}", customerA.NameCustomer);
                    Console.WriteLine("********************************************************************************");
                    Console.WriteLine("Please choose your account for your transaction.");
                    Console.WriteLine("********************************************************************************");


                    foreach (BankAccount accounts in AccountList)
                    {
                        if (accounts.AccountCustomerGet.NameCustomer == customerA.NameCustomer)
                        {
                            arrayIndex[count] = AccountList.IndexOf(accounts);
                            count++;
                            Console.WriteLine("Press {0} for {1} account \t: {2} \t: {3:c}", count, accounts.AccountTypeGet, accounts.AccountNumberGet, accounts.AccountValueGet);
                        }
                    }
                    Console.WriteLine("********************************************************************************");
                    userinput = Console.ReadKey(true).KeyChar.ToString();
                } while (int.TryParse(userinput, out userinputint) == false);
            } while (userinputint <= 0 || userinputint > count);
            return arrayIndex;
        }

        //public UserSubMenuScreen(int[] arrayIndex)
        //{

        //}
    }
}
