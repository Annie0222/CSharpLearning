using System;

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

        // Constructor
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
            toString += Category == Category.Spending ? "Category: Spending\n" : "Category: Income\n";
            toString += $"Amount: {Amount}\n";
            toString += $"OccuredTime: {OccuredTime:yyyy/MM/dd}\n";
            toString += $"Content: {Content}\n";
            toString += $"Note: {Note}";
            return toString;
        }

        private static Category ConvertStringToCategory(string category)
        {
            if (category == "Income") return Category.Income;
            else return Category.Spending;
        }

    }
}
