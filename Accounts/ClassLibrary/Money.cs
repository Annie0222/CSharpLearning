using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Money
    {
        const double EURTORMBRATE = 7.7562;
        const double USDTORMBRATE = 6.9258;
        // Properties
        public double faceValue { get; }
        public Currency currency { get;  }

        // Constructor
        public Money() : this(0, Currency.RMB) { }
        public Money(double faceValue,string currency) : this(faceValue, ConvertStringToCurrency(currency)) { }
        public Money(double faceValue,Currency currency)
        {
            this.faceValue = faceValue;
            this.currency = currency;
        }

        public static Money operator+ (Money money1, Money money2)
        {
            if (money1.currency != Currency.RMB) money1 = ConvertToRMB(money1);
            if (money2.currency != Currency.RMB) money2 = ConvertToRMB(money2);
            return new Money(money1.faceValue + money2.faceValue, Currency.RMB);
        }

        public static Money operator- (Money money1, Money money2)
        {
            if (money1.currency != Currency.RMB) money1 = ConvertToRMB(money1);
            if (money2.currency != Currency.RMB) money2 = ConvertToRMB(money2);
            return new Money(money1.faceValue - money2.faceValue, Currency.RMB);
        }

        public override string ToString()
        {
            string toString = "";
            switch (currency)
            {
                case Currency.EUR:
                    toString += "EUR ";
                    break;
                case Currency.USD:
                    toString += "USD ";
                    break;
                default:
                    toString += "RMB ";
                    break;
            }
            return toString += faceValue.ToString("f2");
        }

        private static Currency ConvertStringToCurrency(string currency)
        {
            switch (currency)
            {
                case "EUR":
                    return Currency.EUR;
                case "USD":
                    return Currency.USD;
                default:
                    return Currency.RMB;
            }
        }

        private static Money ConvertToRMB(Money money)
        {
            switch (money.currency)
            {
                case Currency.EUR:
                    return new Money(money.faceValue * EURTORMBRATE, Currency.RMB);
                case Currency.USD:
                    return new Money(money.faceValue * USDTORMBRATE, Currency.RMB);
                default:
                    return money;
            }
        }
    }
}
