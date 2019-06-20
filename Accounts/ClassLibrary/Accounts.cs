using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Accounts
    {
        // Field
        private List<AccountItem> accountItemList = new List<AccountItem>();

        /// <summary>
        /// Add one account item.
        /// </summary>
        /// <param name="accountItem">The item to add.</param>
        public void AddAccountItem(AccountItem accountItem)
        {
            accountItemList.Add(accountItem);
        }

        /// <summary>
        /// Delete specific account item.
        /// </summary>
        /// <param name="accountItem">The item to delete.</param>
        /// <returns>Whether the item is removed successfully or not.</returns>
        public bool RemoveAccountItem(string accountItemName)
        {
            foreach (var accountItem in accountItemList)
            {
                if (accountItem.Name == accountItemName)
                {
                    return accountItemList.Remove(accountItem);
                }
            }
            return false;
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
            Money totalExpenditure = new Money();
            foreach (AccountItem accountItem in accountItemList)
            {
                if (accountItem.OccuredTime.Year == dateTime.Year && accountItem.OccuredTime.Month == dateTime.Month && accountItem.Category == Category.Spending)
                {
                    totalExpenditure = totalExpenditure + accountItem.Amount;
                }
            }
            return totalExpenditure;
        }

        /// <summary>
        /// Calculate total income of given month.
        /// </summary>
        /// <param name="dateTime">Given month using DateTime type.</param>
        /// <returns>Total income of given month.</returns>
        public Money TotalIncome(DateTime dateTime)
        {
            Money totalIncome = new Money();
            foreach (AccountItem accountItem in accountItemList)
            {
                if (accountItem.OccuredTime.Year == dateTime.Year && accountItem.OccuredTime.Month == dateTime.Month && accountItem.Category == Category.Income)
                {
                    totalIncome = totalIncome + accountItem.Amount;
                }
            }
            return totalIncome;
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
    }
}
