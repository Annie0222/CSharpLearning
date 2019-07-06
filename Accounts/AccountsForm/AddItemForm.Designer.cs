namespace AccountsForm
{
    partial class AddItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OccuredTimeLable = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.OccuredTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MandatoryLabel1 = new System.Windows.Forms.Label();
            this.MandatoryLabel2 = new System.Windows.Forms.Label();
            this.NameCheckResultLabel = new System.Windows.Forms.Label();
            this.OccuredTimeCheckLabel = new System.Windows.Forms.Label();
            this.AmountCheckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(53, 44);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 22);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(53, 92);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(87, 22);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(53, 140);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(77, 22);
            this.AmountLabel.TabIndex = 0;
            this.AmountLabel.Text = "Amount:";
            // 
            // OccuredTimeLable
            // 
            this.OccuredTimeLable.AutoSize = true;
            this.OccuredTimeLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccuredTimeLable.Location = new System.Drawing.Point(53, 194);
            this.OccuredTimeLable.Name = "OccuredTimeLable";
            this.OccuredTimeLable.Size = new System.Drawing.Size(128, 22);
            this.OccuredTimeLable.TabIndex = 0;
            this.OccuredTimeLable.Text = "Occured Time:";
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentLabel.Location = new System.Drawing.Point(53, 239);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(76, 22);
            this.ContentLabel.TabIndex = 0;
            this.ContentLabel.Text = "Content:";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.Location = new System.Drawing.Point(53, 289);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(54, 22);
            this.NoteLabel.TabIndex = 0;
            this.NoteLabel.Text = "Note:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(193, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(341, 27);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Spending",
            "Income"});
            this.CategoryComboBox.Location = new System.Drawing.Point(193, 92);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(341, 27);
            this.CategoryComboBox.TabIndex = 2;
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CurrencyComboBox.Items.AddRange(new object[] {
            "RMB",
            "USD",
            "EUR"});
            this.CurrencyComboBox.Location = new System.Drawing.Point(193, 140);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(92, 27);
            this.CurrencyComboBox.TabIndex = 3;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(291, 140);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(243, 27);
            this.AmountTextBox.TabIndex = 4;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
            // 
            // OccuredTimePicker
            // 
            this.OccuredTimePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.OccuredTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OccuredTimePicker.Location = new System.Drawing.Point(193, 190);
            this.OccuredTimePicker.Name = "OccuredTimePicker";
            this.OccuredTimePicker.Size = new System.Drawing.Size(341, 27);
            this.OccuredTimePicker.TabIndex = 5;
            this.OccuredTimePicker.CloseUp += new System.EventHandler(this.OccuredTimePicker_CloseUp);
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(193, 239);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(341, 27);
            this.ContentTextBox.TabIndex = 6;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(193, 289);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(341, 75);
            this.NoteTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(57, 408);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(143, 34);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(391, 408);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(143, 34);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MandatoryLabel1
            // 
            this.MandatoryLabel1.AutoSize = true;
            this.MandatoryLabel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MandatoryLabel1.ForeColor = System.Drawing.Color.Red;
            this.MandatoryLabel1.Location = new System.Drawing.Point(540, 45);
            this.MandatoryLabel1.Name = "MandatoryLabel1";
            this.MandatoryLabel1.Size = new System.Drawing.Size(18, 19);
            this.MandatoryLabel1.TabIndex = 0;
            this.MandatoryLabel1.Text = "*";
            // 
            // MandatoryLabel2
            // 
            this.MandatoryLabel2.AutoSize = true;
            this.MandatoryLabel2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MandatoryLabel2.ForeColor = System.Drawing.Color.Red;
            this.MandatoryLabel2.Location = new System.Drawing.Point(540, 92);
            this.MandatoryLabel2.Name = "MandatoryLabel2";
            this.MandatoryLabel2.Size = new System.Drawing.Size(18, 19);
            this.MandatoryLabel2.TabIndex = 0;
            this.MandatoryLabel2.Text = "*";
            // 
            // NameCheckResultLabel
            // 
            this.NameCheckResultLabel.AutoSize = true;
            this.NameCheckResultLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameCheckResultLabel.ForeColor = System.Drawing.Color.Red;
            this.NameCheckResultLabel.Location = new System.Drawing.Point(189, 67);
            this.NameCheckResultLabel.Name = "NameCheckResultLabel";
            this.NameCheckResultLabel.Size = new System.Drawing.Size(114, 16);
            this.NameCheckResultLabel.TabIndex = 0;
            this.NameCheckResultLabel.Text = "Name check result";
            this.NameCheckResultLabel.Visible = false;
            // 
            // OccuredTimeCheckLabel
            // 
            this.OccuredTimeCheckLabel.AutoSize = true;
            this.OccuredTimeCheckLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccuredTimeCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.OccuredTimeCheckLabel.Location = new System.Drawing.Point(190, 220);
            this.OccuredTimeCheckLabel.Name = "OccuredTimeCheckLabel";
            this.OccuredTimeCheckLabel.Size = new System.Drawing.Size(54, 16);
            this.OccuredTimeCheckLabel.TabIndex = 0;
            this.OccuredTimeCheckLabel.Text = "warning";
            this.OccuredTimeCheckLabel.Visible = false;
            // 
            // AmountCheckLabel
            // 
            this.AmountCheckLabel.AutoSize = true;
            this.AmountCheckLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.AmountCheckLabel.Location = new System.Drawing.Point(190, 170);
            this.AmountCheckLabel.Name = "AmountCheckLabel";
            this.AmountCheckLabel.Size = new System.Drawing.Size(54, 16);
            this.AmountCheckLabel.TabIndex = 0;
            this.AmountCheckLabel.Text = "warning";
            this.AmountCheckLabel.Visible = false;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 474);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.OccuredTimePicker);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.OccuredTimeLable);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.MandatoryLabel2);
            this.Controls.Add(this.MandatoryLabel1);
            this.Controls.Add(this.AmountCheckLabel);
            this.Controls.Add(this.OccuredTimeCheckLabel);
            this.Controls.Add(this.NameCheckResultLabel);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddItemForm";
            this.Text = "Add Account Item";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label OccuredTimeLable;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.DateTimePicker OccuredTimePicker;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label MandatoryLabel2;
        private System.Windows.Forms.Label MandatoryLabel1;
        private System.Windows.Forms.Label NameCheckResultLabel;
        private System.Windows.Forms.Label OccuredTimeCheckLabel;
        private System.Windows.Forms.Label AmountCheckLabel;
    }
}