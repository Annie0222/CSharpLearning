using System;
using System.Globalization;
using ClassLibrary;

namespace AccountsAPP
{
    class Program
    {
        private static void AddAccountItem(Accounts accounts)
        {
            Console.WriteLine("Please fill follow part of your account item");
            string name = "";
            do
            {
                Console.Write("\tName: ");
                name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name can't be empty or only whitespace.");
                }
            } while (String.IsNullOrWhiteSpace(name) || accounts.IsDuplicateAccountItemName(name));
            string category = "";
            do
            {
                Console.Write("\tCategory (Spending or Income): ");
                category = Console.ReadLine();
            } while (!accounts.IsCategoryInputValid(category));
            string currency = "";
            do
            {
                Console.Write("\tCurrency(RMB, EUR or USD): ");
                currency = Console.ReadLine();
            } while (!accounts.IsCurrencyInputValid(currency));
            Console.Write("\tAmount: ");
            double faceValue = 0;
            double.TryParse(Console.ReadLine(),out faceValue);
            DateTime occuredTime=default;
            do {
                Console.Write("\tTime (yyyy/mm/dd [hh:mm]): ");
                try
                {
                    occuredTime = Convert.ToDateTime(Console.ReadLine(), AccountItem.OccuredTimeFormat);
                    break;
                } catch 
                {
                    Console.WriteLine($"Invalid occured time format. Correct format can be {AccountItem.OccuredTimeFormat.LongDatePattern} or {AccountItem.OccuredTimeFormat.ShortDatePattern}.");
                }
            } while (true);
            Console.Write("\tContent (If applicable): ");
            string content = Console.ReadLine();
            Console.Write("\tNote (If applicable): ");
            string note = Console.ReadLine();

            accounts.Add(new AccountItem(name, category, new Money(faceValue, currency), occuredTime, content, note));
            Console.WriteLine($"Account item {name} added successfully.");
    }
        private static void RemoveAccountItem(Accounts accounts)
        {
            Console.Write("The name of account item that you want to delete:");
            string name = Console.ReadLine();
            if (!accounts.Remove(name))
            {
                Console.WriteLine($"There is no account item named {name} in the accounts");
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
            accounts.Add(new AccountItem("Salary", Category.Income, new Money(8000, Currency.RMB), new DateTime(2019, 5, 26)));
            accounts.Add(new AccountItem("Cloth", Category.Spending, new Money(300, Currency.RMB), new DateTime(2019, 5, 30)));
            accounts.Add(new AccountItem("Fruit", Category.Spending, new Money(50, Currency.RMB), new DateTime(2019, 6, 2)));
            accounts.Add(new AccountItem("Bonus", Category.Income, new Money(100, Currency.USD), new DateTime(2019, 6, 5)));
            accounts.Add(new AccountItem("Shoes", Category.Spending, new Money(500, Currency.RMB), new DateTime(2019, 6, 18)));

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
