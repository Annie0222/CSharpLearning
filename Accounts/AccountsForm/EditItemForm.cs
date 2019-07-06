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
    public partial class EditItemForm : System.Windows.Forms.Form
    {
        public EditItemForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (AmountCheckLabel.Visible == true)
            {
                MessageBox.Show($"{AmountCheckLabel.Text}", "Error", MessageBoxButtons.OK);
                return;
            }
            if (OccuredTimeCheckLabel.Visible == true)
            {
                var result = MessageBox.Show("The selected occured time is in the future. Are you sure you want to add this item.", "Warning", MessageBoxButtons.YesNoCancel);
                if (result != DialogResult.Yes)
                {
                    return;
                }
            }
            AccountItem accountItem = new AccountItem(NameTextBox.Text, CategoryComboBox.Text,
                new Money(double.Parse(AmountTextBox.Text), CurrencyComboBox.Text), OccuredTimePicker.Value, ContentTextBox.Text, NoteTextBox.Text);
            Program.EditItem(accountItem);
            this.Close();
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

        public void SetControlsValue(DataGridViewRow dataGridViewRow)
        {
            NameTextBox.Text = dataGridViewRow.Cells[0].Value.ToString();
            CategoryComboBox.Text = dataGridViewRow.Cells[1].Value.ToString();
            CurrencyComboBox.Text = dataGridViewRow.Cells[2].Value.ToString().Split(' ')[0];
            AmountTextBox.Text = dataGridViewRow.Cells[2].Value.ToString().Split(' ')[1];
            OccuredTimePicker.Value = Convert.ToDateTime(dataGridViewRow.Cells[3].Value.ToString());
            ContentTextBox.Text = dataGridViewRow.Cells[4].Value.ToString();
            NoteTextBox.Text = dataGridViewRow.Cells[5].Value.ToString();
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
