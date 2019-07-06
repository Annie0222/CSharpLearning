using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace AccountsForm
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Events
       private void MainForm_Shown(object sender, EventArgs e)
        {
            AccountItemsGridView.ClearSelection();
        }

        private void MonthPicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshDataView(Program.accounts);
        }

        private void AccountItemsGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DeleteButton.Enabled = true;
            EditButton.Enabled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (AccountItemsGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("You can only edit one item at a time.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                EditItemForm editItemForm = new EditItemForm();
                editItemForm.SetControlsValue(AccountItemsGridView.SelectedRows[0]);
                editItemForm.ShowDialog();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show("Are you sure you want to delete selected items", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in AccountItemsGridView.SelectedRows)
                {
                    if (Program.DeleteItem(row.Cells[0].Value.ToString()))
                    {
                        AccountItemsGridView.Rows.Remove(row);
                    } else
                    {
                        MessageBox.Show($"Failed to delete item '{row.Cells[0].Value.ToString()}'.", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }
        #endregion
        public void SetMonthPicker(DateTime dateTime)
        {
            MonthPicker.Value = dateTime;
        }
        public void SetAccountItemGridView(Accounts accounts)
        {
            AccountItemsGridView.Rows.Clear();
            var accountItems = accounts.Display(MonthPicker.Value);
            if (accountItems.Count() > 0)
            {
                AccountItemsGridView.Rows.Add(accountItems.Count());
                for (int i = 0; i < accountItems.Count(); i++)
                {
                    AccountItemsGridView.Rows[i].Cells[0].Value = accountItems.ElementAt(i).Name;
                    AccountItemsGridView.Rows[i].Cells[1].Value = accountItems.ElementAt(i).Category;
                    AccountItemsGridView.Rows[i].Cells[2].Value = accountItems.ElementAt(i).Amount;
                    AccountItemsGridView.Rows[i].Cells[3].Value = accountItems.ElementAt(i).OccuredTime.ToString("yyyy/MM/dd hh:mm");
                    AccountItemsGridView.Rows[i].Cells[4].Value = accountItems.ElementAt(i).Content;
                    AccountItemsGridView.Rows[i].Cells[5].Value = accountItems.ElementAt(i).Note;
                }
            }
            AccountItemsGridView.ClearSelection();
        }

        public void RefreshDataView(Accounts accounts)
        {
            SetAccountItemGridView(accounts);
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            totalIncomeLabel.Text = accounts.TotalIncome(MonthPicker.Value).ToString();
            totalExpenditureLabel.Text = accounts.TotalExpenditure(MonthPicker.Value).ToString();
            totalRevenueLabel.Text = accounts.TotalRevenue(MonthPicker.Value).ToString();
        }
    }
}
