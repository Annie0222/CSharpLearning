using System;
using ClassLibrary;

namespace AccountsAPP
{
    class Program
    {
        private static void AddAccountItem(Accounts accounts)
        {
            Console.WriteLine("Please fill follow part of your account item");
            Console.Write("\tName: ");
            string name = Console.ReadLine();
            string category = "";
            do
            {
                Console.Write("\tCategory (Spending or Income): ");
                category = Console.ReadLine();
                if (category != "Spending" && category != "Income")
                {
                    Console.WriteLine("Wrong Input!");
                }
            } while (category != "Spending" && category != "Income");
            string currency = "";
            do
            {
                Console.Write("\tCurrency(RMB, EUR or USD): ");
                currency = Console.ReadLine();
                if (currency != "RMB" && currency != "EUR" && currency != "USD")
                {
                    Console.WriteLine("Wrong Input!");
                } else
                {
                    break;
                }
            } while (true);
            Console.Write("\tAmount: ");
            double faceValue = double.Parse(Console.ReadLine());
            string[] occuredTime={""};
            do {
                Console.Write("\tTime (yyyy/mm/dd): ");
                occuredTime = Console.ReadLine().Split('/');
                if (occuredTime.Length != 3)
                {
                    Console.WriteLine("Wrong format!");
                }
            } while (occuredTime.Length != 3);
            Console.Write("\tContent (If applicable): ");
            string content = Console.ReadLine();
            Console.Write("\tNote (If applicable): ");
            string note = Console.ReadLine();

            accounts.AddAccountItem(new AccountItem(name, category, new Money(faceValue, currency), new DateTime(int.Parse(occuredTime[0]), int.Parse(occuredTime[1]), int.Parse(occuredTime[2])), content, note));
            Console.WriteLine("Account item added successfully.");
    }
        private static void RemoveAccountItem(Accounts accounts)
        {
            Console.Write("The name of account item that you want to delete:");
            string name = Console.ReadLine();
            if (!accounts.RemoveAccountItem(name))
            {
                Console.WriteLine($"There is no account item named{name} in the accouts");
            } else
            {
                Console.WriteLine("Account item deleted successfully.");
            }
        }

        private static void DisplayAllAccountItem(Accounts accounts)
        {
            Console.Write("Please give the month you want to display (yyyy/mm): ");
            string[] month = Console.ReadLine().Split('/');
            if (month.Length != 2)
            {
                Console.WriteLine("Wrong Month");
            }
            else
            {
                var accountItems = accounts.Display(new DateTime(int.Parse(month[0]), int.Parse(month[1]), 1));
                foreach (var ai in accountItems)
                {
                    Console.WriteLine(ai);
                    Console.WriteLine("--------------------------------------------------------------------------------");
                }
            }
        }

        private static void DisplayTotalIncome(Accounts accounts)
        {
            Console.Write("Please give the month you want to display (yyyy/mm): ");
            string[] month = Console.ReadLine().Split('/');
            if (month.Length != 2)
            {
                Console.WriteLine("Wrong format!");
            }
            else
            {
                Money totalIncome = accounts.TotalIncome(new DateTime(int.Parse(month[0]), int.Parse(month[1]), 1));
                Console.WriteLine($"Your total income of {month[0]}/{month[1]} is {totalIncome}");
            }
        }

        private static void DisplayTotalExpenditure(Accounts accounts)
        {
            Console.Write("Please give the month you want to display (yyyy/mm): ");
            string[] month = Console.ReadLine().Split('/');
            if (month.Length != 2)
            {
                Console.WriteLine("Wrong format!");
            }
            else
            {
                Money totalExpenditure=accounts.TotalExpenditure(new DateTime(int.Parse(month[0]), int.Parse(month[1]), 1));
                Console.WriteLine($"Your total expenditure of {month[0]}/{month[1]} is {totalExpenditure}");
            }
        }

        private static void DisplayTotalRevenue(Accounts accounts)
        {
            Console.Write("Please give the month you want to display (yyyy/mm): ");
            string[] month = Console.ReadLine().Split('/');
            if (month.Length != 2)
            {
                Console.WriteLine("Wrong Month");
            }
            else
            {
                Money totalRevenue=accounts.TotalRevenue(new DateTime(int.Parse(month[0]), int.Parse(month[1]), 1));
                Console.WriteLine($"Your total income of {month[0]}/{month[1]} is {totalRevenue}");
            }
        }

        public static void Main(string[] args)
        {
            Accounts accounts = new Accounts();
            accounts.AddAccountItem(new AccountItem("Salary", Category.Income, new Money(8000, Currency.RMB), new DateTime(2019, 5, 26)));
            accounts.AddAccountItem(new AccountItem("Cloth", Category.Spending, new Money(300, Currency.RMB), new DateTime(2019, 5, 30)));
            accounts.AddAccountItem(new AccountItem("Fruit", Category.Spending, new Money(50, Currency.RMB), new DateTime(2019, 6, 2)));
            accounts.AddAccountItem(new AccountItem("Bonus", Category.Income, new Money(100, Currency.USD), new DateTime(2019, 6, 5)));
            accounts.AddAccountItem(new AccountItem("Shoes", Category.Spending, new Money(500, Currency.RMB), new DateTime(2019, 6, 18)));

            Console.WriteLine("Hello, Welcome to the Accounts APP!");
            while (true)
            {
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("\t1. Add account item.");
                Console.WriteLine("\t2. Remove account item.");
                Console.WriteLine("\t3. View all account item of certain month.");
                Console.WriteLine("\t4. View total income of certain month.");
                Console.WriteLine("\t5. View total expenditure of certain month.");
                Console.WriteLine("\t6. View total revenue of certain month.");
                Console.WriteLine("\t7. Quit");
                Console.Write("Your choice:");

                int choice = 0;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7)
                {
                    Console.WriteLine("Wrong choice!");
                    continue;
                }
                if (choice == 7) break;
                switch (choice)
                {
                    case 1:
                        AddAccountItem(accounts);
                        break;
                    case 2:
                        RemoveAccountItem(accounts);
                        break;
                    case 3:
                        DisplayAllAccountItem(accounts);
                        break;
                    case 4:
                        DisplayTotalIncome(accounts);
                        break;
                    case 5:
                        DisplayTotalExpenditure(accounts);
                        break;
                    case 6:
                        DisplayTotalRevenue(accounts);
                        break;
                }
            }
        }
    }
}
