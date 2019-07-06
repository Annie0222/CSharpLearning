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
    public partial class AddItemForm : System.Windows.Forms.Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["AddItemForm"].Close();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            CategoryComboBox.SelectedIndex = 0;
            CurrencyComboBox.SelectedIndex = 0;
            AmountTextBox.Text = "0";
            OccuredTimePicker.Value = DateTime.Now;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AmountCheckLabel.Visible==true)
            {
                MessageBox.Show($"{AmountCheckLabel.Text}", "Error", MessageBoxButtons.OK);
                return;
            }
            if (OccuredTimeCheckLabel.Visible==true)
            {
                var result=MessageBox.Show("The selected occured time is in the future. Are you sure you want to add this item.","Warning",MessageBoxButtons.YesNoCancel);
                if (result!=DialogResult.Yes)
                {
                    return;
                }
            }
            AccountItem accountItem=new AccountItem(NameTextBox.Text,CategoryComboBox.Text,
                new Money(double.Parse(AmountTextBox.Text),CurrencyComboBox.Text),OccuredTimePicker.Value,ContentTextBox.Text,NoteTextBox.Text);
            Program.AddItem(accountItem);
            this.Close();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                NameCheckResultLabel.Text = "Name cannot be null";
                NameCheckResultLabel.Visible = true;
                AddButton.Enabled = false;
            } else {
                if (Program.accounts.IsDuplicateAccountItemName(NameTextBox.Text))
                {
                    
                    NameCheckResultLabel.Text = $"Account item {NameTextBox.Text} is already exsit.";
                    NameCheckResultLabel.Visible = true;
                    AddButton.Enabled = false;
                } else
                {
                    NameCheckResultLabel.Visible = false;
                    AddButton.Enabled = true;
                }
            }
        }

        private void OccuredTimePicker_CloseUp(object sender, EventArgs e)
        {
            if (OccuredTimePicker.Value>DateTime.Now)
            {
                OccuredTimeCheckLabel.Visible = true;
                OccuredTimeCheckLabel.Text = "The selected time is in the future.";
            } else
            {
                OccuredTimeCheckLabel.Visible = false;
            }
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AmountTextBox.Text))
            {
                AmountCheckLabel.Visible = true;
                AmountCheckLabel.Text = "Amount should not be empty.";
                return;
            }
            if (!double.TryParse(AmountTextBox.Text, out double amount))
            {
                AmountCheckLabel.Visible = true;
                AmountCheckLabel.Text = "Amount should be numbers.";
            }
            else
            {
                if (amount < 0)
                {
                    AmountCheckLabel.Visible = true;
                    AmountCheckLabel.Text = "Amount should be postive numbers.";
                }
                else
                {
                    AmountCheckLabel.Visible = false;
                }
            }
        }
    }
}
