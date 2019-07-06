using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace AccountsForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        internal static Accounts accounts=new Accounts();
        private static string dataFilePath = "../../AccountsData.csv";
        private static MainForm mainForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ReadData(dataFilePath);
            mainForm = new MainForm();
            mainForm.RefreshDataView(accounts);
            Application.Run(mainForm);
        }

        private static void ReadData(string filePath)
        {
            if (File.Exists(filePath))
            {
                FileStream dataFileStream = new FileStream(filePath, FileMode.Open);
                StreamReader reader = new StreamReader(dataFileStream, System.Text.Encoding.UTF8);
                reader.ReadLine();
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string[] properties = line.Split(';');
                    string itemName = properties[0];
                    string category = properties[1];
                    Money amount = new Money(double.Parse(properties[2].Split(' ')[1]), properties[2].Split(' ')[0]);
                    DateTime occuredTime = Convert.ToDateTime(properties[3]);
                    string content = properties[4];
                    string note = properties[5];
                    accounts.Add(new AccountItem(itemName, category, amount, occuredTime, content, note));
                }
                reader.Close();
                dataFileStream.Close();
            }
        }

        private static void WriteData(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            FileStream dataFileStream = new FileStream(filePath, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(dataFileStream, System.Text.Encoding.UTF8);
            sw.WriteLine("Name;Category;Amount;OccuredTime;Content;Note");
            foreach (AccountItem ai in accounts.GetAccountItems())
            {
                sw.WriteLine(ai.ToCsvFormatString());
            }
            sw.Flush();
            sw.Close();
            dataFileStream.Close();
        }

        internal static void AddItem(AccountItem accountItem)
        {
            accounts.Add(accountItem);
            WriteData(dataFilePath);
            mainForm.SetMonthPicker(accountItem.OccuredTime);
            mainForm.RefreshDataView(accounts);
        }

        internal static void EditItem(AccountItem accountItem)
        {
            accounts.Edit(accountItem);
            WriteData(dataFilePath);
            mainForm.RefreshDataView(accounts);
        }

        internal static bool DeleteItem(string accountItemName)
        {
            bool result=accounts.Remove(accountItemName);
            if (result)
            {
                WriteData(dataFilePath);
            }
            return result;
        }

        
    }
}
