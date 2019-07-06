using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Extensions;

namespace ClassLibrary
{
    public class Accounts
    {
        // Field
        public List<AccountItem> accountItemList = new List<AccountItem>();

        /// <summary>
        /// Add one account item.
        /// </summary>
        /// <param name="accountItem">The item to add.</param>
        public void Add(AccountItem accountItem)
        {
            if (accountItem != null)
            {
                accountItemList.Add(accountItem);
            }
        }

        public void Edit(AccountItem accountItem)
        {
            int index = accountItemList.IndexOf(accountItem);
            if (index >= 0)
            {
                accountItemList[index] = accountItem;
            }
        }

        /// <summary>
        /// Delete specific account item.
        /// </summary>
        /// <param name="accountItem">The item to delete.</param>
        /// <returns>Whether the item is removed successfully or not.</returns>
        public bool Remove(string accountItemName)
        {
            return accountItemList.Remove(new AccountItem(accountItemName));
        }

        /// <summary>
        /// Calculate total revenue of given month.
        /// </summary>
        /// <param name="dateTime">Given month using DateTime type.</param>
        /// <returns>Total revenue of given month.</returns>
        public Money TotalRevenue(DateTime dateTime)
        {
            return TotalIncome(dateTime) - TotalExpenditure(dateTime);
        }

        /// <summary>
        /// Calculate total expenditure of given month.
        /// </summary>
        /// <param name="dateTime">Given month using DateTime type.</param>
        /// <returns>Total expenditure of given month.</returns>
        public Money TotalExpenditure(DateTime dateTime)
        {
            return Calculate(ai => ai.OccuredTime.SameMonthOfSameYear(dateTime) && ai.IsSpending());
        }

        /// <summary>
        /// Calculate total income of given month.
        /// </summary>
        /// <param name="dateTime">Given month using DateTime type.</param>
        /// <returns>Total income of given month.</returns>
        public Money TotalIncome(DateTime dateTime)
        {
            return Calculate(ai => ai.OccuredTime.SameMonthOfSameYear(dateTime) && ai.IsIncome());
        }

        /// <summary>
        /// IEnumerator. Can be use to display all account items of given month.
        /// </summary>
        /// <param name="dateTime">Given month using DateTime type.</param>
        /// <returns>All account items of given month.</returns>
        public IEnumerable<AccountItem> Display(DateTime dateTime)
        {
            foreach (AccountItem accountItem in accountItemList)
            {
                if (accountItem.OccuredTime.Year == dateTime.Year && accountItem.OccuredTime.Month == dateTime.Month)
                {
                    yield return accountItem;
                }
            }
        }

        public List<AccountItem> GetAccountItems()
        {
            return accountItemList;
        }

        public bool IsDuplicateAccountItemName(string accountItemName)
        {
            if (accountItemList.Contains(new AccountItem(accountItemName)))
            {
                Console.WriteLine($"Account Item {accountItemName} is already exist. Please give another name.");
                return true;
            }
            return false;
        }

        public bool IsCategoryInputValid(string category)
        {
            category = category.ToLower();
            return IsInputValid<string>(category, (cat) => cat == "spending" || cat == "income");
        }
        public bool IsCurrencyInputValid(string currency)
        {
            currency = currency.ToUpper();
            return IsInputValid<string>(currency, (cur) => cur == "RMB" || cur == "EUR" || cur == "USD");
        }
        public bool IsOccuredTimeInputValid(string[] occuredTime)
        {
            return IsInputValid<string[]>(occuredTime, ot => ot.Length != 3);
        }

        
        #region Help method
        private Money Calculate(Func<AccountItem, bool> func)
        {
            Money totalIncome = new Money();
            foreach (AccountItem accountItem in accountItemList)
            {
                if (func(accountItem))
                {
                    totalIncome = totalIncome + accountItem.Amount;
                }
            }
            return totalIncome;
        }

        private bool IsInputValid<T>(T input, Predicate<T> func)
        {
            if (!func(input))
            {
                Console.WriteLine($"Invalid Input {input.GetType()} format!");
                return false;
            }
            return true;
        }
        #endregion
    }
}
