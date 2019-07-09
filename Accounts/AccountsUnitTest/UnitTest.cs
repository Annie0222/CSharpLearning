using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace AccountsUnitTest
{
    [TestClass]
    public class UnitTest
    {
        private Accounts accounts = new Accounts();
        [TestInitialize]
        public void InitializeAccounts()
        {
            accounts.Add(new AccountItem("Salary", Category.Income, new Money(8000, Currency.RMB), new DateTime(2019, 5, 26)));
            accounts.Add(new AccountItem("Cloth", Category.Spending, new Money(300, Currency.RMB), new DateTime(2019, 5, 30)));
            accounts.Add(new AccountItem("Fruit", Category.Spending, new Money(50, Currency.RMB), new DateTime(2019, 6, 2)));
            accounts.Add(new AccountItem("Bonus", Category.Income, new Money(100, Currency.USD), new DateTime(2019, 6, 5)));
            accounts.Add(new AccountItem("Shoes", Category.Spending, new Money(500, Currency.RMB), new DateTime(2019, 6, 18)));
        }

        #region Unit Test for Money
        [TestCategory("Money Unit Test")]
        [TestMethod]
        public void given_same_currency_money_should_return_correct_sum()
        {
            Money money1 = new Money(100, Currency.RMB);
            Money money2 = new Money(200, Currency.RMB);
            Money expectedMoneySum = new Money(300, Currency.RMB);
            Assert.AreEqual(expectedMoneySum, money1+money2);
        }

        [TestCategory("Money Unit Test")]
        [TestMethod]
        public void given_different_currency_money_should_return_correct_sum_with_rmb_currency()
        {
            Money money1 = new Money(100, Currency.USD);
            Money money2 = new Money(100, Currency.RMB);
            Assert.AreEqual("RMB 792.58", (money1 + money2).ToString());
        }

        [TestCategory("Money Unit Test")]
        [TestMethod]
        public void given_same_currency_money_should_return_correct_substract()
        {
            Money money1 = new Money(100, Currency.RMB);
            Money money2 = new Money(200, Currency.RMB);
            Money expectedMoneySum = new Money(100, Currency.RMB);
            Assert.AreEqual(expectedMoneySum, money2 - money1);
        }

        [TestCategory("Money Unit Test")]
        [TestMethod]
        public void given_different_currency_money_should_return_correct_substract_with_rmb_currency()
        {
            Money money1 = new Money(100, Currency.USD);
            Money money2 = new Money(100, Currency.RMB);
            Assert.AreEqual("RMB 592.58", (money1-money2).ToString());
        }
        #endregion

        #region Unit Test for AccountItem Class
        [TestCategory("AccountItem Unit Test")]
        [TestMethod]
        public void given_income_account_item_return_is_income_true()
        {
            AccountItem accountItem = new AccountItem("Salary", Category.Income, new Money(8000, Currency.RMB), new DateTime(2019, 5, 26));
            Assert.AreEqual(false, accountItem.IsIncome());
        }

        [TestCategory("AccountItem Unit Test")]
        [TestMethod]
        public void given_income_account_item_return_is_spending_false()
        {
            AccountItem accountItem = new AccountItem("Salary", Category.Income, new Money(8000, Currency.RMB), new DateTime(2019, 5, 26));
            Assert.AreEqual(false, accountItem.IsSpending());
        }

        [TestCategory("AccountItem Unit Test")]
        [TestMethod]
        public void given_account_item_return_correct_csv_format_string()
        {
            AccountItem accountItem = new AccountItem("Salary", Category.Income, new Money(8000, Currency.RMB), new DateTime(2019, 5, 26));
            string csvFormatString = "Salary;Income;RMB 8000.00;2019/05/26 12:00;;";
            Assert.AreEqual(csvFormatString, accountItem.ToCsvFormatString());
        }
        #endregion

        #region Unit Test for Accounts Class
        [TestCategory("Accounts Unit Test")]
        [TestMethod]
        public void given_existing_account_item_name_should_return_true()
        {
            Assert.AreEqual(true,accounts.IsDuplicateAccountItemName("Salary"));
        }

        [TestCategory("Accounts Unit Test")]
        [TestMethod]
        public void given_not_existing_account_item_name_should_return_false()
        {
            Assert.AreEqual(false, accounts.IsDuplicateAccountItemName("Lunch"));
        }

        [TestCategory("Accounts Unit Test")]
        [TestMethod]
        public void given_spending_category_should_return_true()
        {
            Assert.AreEqual(true, accounts.IsCategoryInputValid("spending"));
        }

        [TestCategory("Accounts Unit Test")]
        [TestMethod]
        public void given_spend_category_should_return_false()
        {
            Assert.AreEqual(false, accounts.IsCategoryInputValid("spend"));
        }

        [TestCategory("Accounts Unit Test")]
        [TestMethod]
        public void given_rmb_currency_should_return_true()
        {
            Assert.AreEqual(true, accounts.IsCurrencyInputValid("rmb"));
        }

        [TestCategory("Accounts Unit Test")]
        [TestMethod]
        public void given_krw_currency_should_return_false()
        {
            Assert.AreEqual(false, accounts.IsCurrencyInputValid("krw"));
        }

        [TestCategory("Accounts Unit Test")]
        [TestMethod]
        public void given_may_2019_should_return_total_income_correctly()
        {
            Money totalIncome = accounts.TotalIncome(new DateTime(2019, 5, 1));
            Money expectedTotalIncome = new Money(8000, Currency.RMB);
            Assert.AreEqual(expectedTotalIncome,totalIncome);
        }

        [TestCategory("Accounts Unit Test")]
        [TestMethod]
        public void given_may_2019_should_return_total_expenditure_correctly()
        {
            Money totalExpenditure = accounts.TotalExpenditure(new DateTime(2019, 5, 1));
            Money expectedTotalExpenditure = new Money(300, Currency.RMB);
            Assert.AreEqual(expectedTotalExpenditure, totalExpenditure);
        }

        [TestCategory("Accounts Unit Test")]
        [TestMethod]
        public void given_may_2019_should_return_total_revenue_correctly()
        {
            Money totalRevenue = accounts.TotalRevenue(new DateTime(2019, 5, 1));
            Money expectedTotalRevenue = new Money(7700, Currency.RMB);
            Assert.AreEqual(expectedTotalRevenue, totalRevenue);
        }

        [TestCategory("Accounts Unit Test")]
        [TestMethod]
        public void given_may_2019_should_return_salary_and_cloth_account_item ()
        {
            List<string> accountItemList =accounts.Display(new DateTime(2019,5,1)).Select(ai=>ai.Name).ToList();
            Assert.AreEqual(2, accountItemList.Count);
            Assert.AreEqual("Salary",accountItemList[0]);
            Assert.AreEqual("Cloth", accountItemList[1]);
        }
        #endregion
    }
}
