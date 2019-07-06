using System;
using System.Globalization;

namespace ClassLibrary
{
    public class AccountItem
    {
        // Properties
        public string Name { get; set; }
        public Category Category { get; set; }
        public Money Amount { get; set; }
        public DateTime OccuredTime { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }
        public static DateTimeFormatInfo OccuredTimeFormat
        {
            get
            {
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy/MM/dd";
                dtFormat.LongDatePattern = "yyyy/MM/dd hh:mm";
                return dtFormat;
            }
        }

        // Constructor
        internal AccountItem(string name) : this(name, Category.Spending) { }
        public AccountItem(string name, Category category) : this(name, category, new Money(), DateTime.Now) { }
        public AccountItem(string name, string category) : this(name, ConvertStringToCategory(category), new Money(), DateTime.Now) { }
        public AccountItem(string name, string category, Money amount, DateTime occoredTime, string content = "", string note = ""):this (name,ConvertStringToCategory(category),amount,occoredTime,content,note) { }
        public AccountItem(string name, Category category, Money amount,  DateTime occoredTime, string content="", string note="")
        {
            this.Name = name;
            this.Category = category;
            this.Amount = amount;
            this.OccuredTime = occoredTime;
            this.Content = content;
            this.Note = note;
        }

        public override string ToString()
        {
            string toString = $"Name: { Name}\n";
            toString += $"Category: {Category}\n";
            toString += $"Amount: {Amount}\n";
            toString += $"OccuredTime: {OccuredTime:yyyy/MM/dd hh:mm}\n";
            toString += $"Content: {Content}\n";
            toString += $"Note: {Note}";
            return toString;
        }

        public string ToCsvFormatString()
        {
            return $"{ Name};{Category};{Amount};{OccuredTime:yyyy/MM/dd hh:mm};{Content};{Note}";
        }

        public bool IsSpending()
        {
            return this.Category == Category.Spending;
        }

        public bool IsIncome()
        {
            return this.Category == Category.Income;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as AccountItem);
        }

        public bool Equals(AccountItem accountItem)
        {
            return this.Name == accountItem.Name;
        }

        private static Category ConvertStringToCategory(string category)
        {
            if (category == null) throw new Exception("Empty category string.");
            if ("income" == category.ToLower()) return Category.Income;
            if ("spending"==category.ToLower()) return Category.Spending;
            throw new Exception("Invalid category type.");
        }
    }
}
