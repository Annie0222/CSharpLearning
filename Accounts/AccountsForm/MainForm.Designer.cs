namespace AccountsForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.accountItemListGroupBox = new System.Windows.Forms.GroupBox();
            this.AccountItemsGridView = new System.Windows.Forms.DataGridView();
            this.AccountItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountItemOccuredTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountItemContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountItemNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MonthPicker = new System.Windows.Forms.DateTimePicker();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.totalExpenditureLabel = new System.Windows.Forms.Label();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountItemListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountItemsGridView)).BeginInit();
            this.actionsGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.Location = new System.Drawing.Point(21, 28);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(122, 19);
            this.MonthLabel.TabIndex = 0;
            this.MonthLabel.Text = "Selected Month:";
            // 
            // accountItemListGroupBox
            // 
            this.accountItemListGroupBox.Controls.Add(this.AccountItemsGridView);
            this.accountItemListGroupBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountItemListGroupBox.Location = new System.Drawing.Point(25, 68);
            this.accountItemListGroupBox.Name = "accountItemListGroupBox";
            this.accountItemListGroupBox.Size = new System.Drawing.Size(729, 423);
            this.accountItemListGroupBox.TabIndex = 1;
            this.accountItemListGroupBox.TabStop = false;
            this.accountItemListGroupBox.Text = "Account Item List";
            // 
            // AccountItemsGridView
            // 
            this.AccountItemsGridView.AllowUserToAddRows = false;
            this.AccountItemsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AccountItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountItemName,
            this.AccountItemCategory,
            this.AccountItemAmount,
            this.AccountItemOccuredTime,
            this.AccountItemContent,
            this.AccountItemNote});
            this.AccountItemsGridView.Location = new System.Drawing.Point(18, 24);
            this.AccountItemsGridView.Name = "AccountItemsGridView";
            this.AccountItemsGridView.ReadOnly = true;
            this.AccountItemsGridView.RowTemplate.Height = 27;
            this.AccountItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountItemsGridView.Size = new System.Drawing.Size(695, 384);
            this.AccountItemsGridView.TabIndex = 0;
            this.AccountItemsGridView.TabStop = false;
            this.AccountItemsGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AccountItemsGridView_CellMouseClick);
            // 
            // AccountItemName
            // 
            this.AccountItemName.HeaderText = "Name";
            this.AccountItemName.Name = "AccountItemName";
            this.AccountItemName.ReadOnly = true;
            // 
            // AccountItemCategory
            // 
            this.AccountItemCategory.HeaderText = "Category";
            this.AccountItemCategory.Name = "AccountItemCategory";
            this.AccountItemCategory.ReadOnly = true;
            // 
            // AccountItemAmount
            // 
            this.AccountItemAmount.HeaderText = "Amount";
            this.AccountItemAmount.Name = "AccountItemAmount";
            this.AccountItemAmount.ReadOnly = true;
            // 
            // AccountItemOccuredTime
            // 
            this.AccountItemOccuredTime.HeaderText = "Occured Time";
            this.AccountItemOccuredTime.Name = "AccountItemOccuredTime";
            this.AccountItemOccuredTime.ReadOnly = true;
            this.AccountItemOccuredTime.Width = 150;
            // 
            // AccountItemContent
            // 
            this.AccountItemContent.HeaderText = "Content";
            this.AccountItemContent.Name = "AccountItemContent";
            this.AccountItemContent.ReadOnly = true;
            // 
            // AccountItemNote
            // 
            this.AccountItemNote.HeaderText = "Note";
            this.AccountItemNote.Name = "AccountItemNote";
            this.AccountItemNote.ReadOnly = true;
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.EditButton);
            this.actionsGroupBox.Controls.Add(this.DeleteButton);
            this.actionsGroupBox.Controls.Add(this.AddButton);
            this.actionsGroupBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsGroupBox.Location = new System.Drawing.Point(769, 297);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(191, 194);
            this.actionsGroupBox.TabIndex = 2;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Actions";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(35, 141);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(117, 38);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(35, 27);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 38);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MonthPicker
            // 
            this.MonthPicker.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthPicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MonthPicker.CustomFormat = "yyyy/MM";
            this.MonthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthPicker.Location = new System.Drawing.Point(163, 21);
            this.MonthPicker.Name = "MonthPicker";
            this.MonthPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MonthPicker.ShowUpDown = true;
            this.MonthPicker.Size = new System.Drawing.Size(222, 25);
            this.MonthPicker.TabIndex = 0;
            this.MonthPicker.TabStop = false;
            this.MonthPicker.Value = new System.DateTime(2019, 7, 6, 17, 43, 8, 519);
            this.MonthPicker.ValueChanged += new System.EventHandler(this.MonthPicker_ValueChanged);
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.AutoSize = true;
            this.totalRevenueLabel.Location = new System.Drawing.Point(51, 177);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(59, 19);
            this.totalRevenueLabel.TabIndex = 0;
            this.totalRevenueLabel.Text = "RMB 0";
            this.totalRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalExpenditureLabel
            // 
            this.totalExpenditureLabel.AutoSize = true;
            this.totalExpenditureLabel.Location = new System.Drawing.Point(51, 116);
            this.totalExpenditureLabel.Name = "totalExpenditureLabel";
            this.totalExpenditureLabel.Size = new System.Drawing.Size(59, 19);
            this.totalExpenditureLabel.TabIndex = 0;
            this.totalExpenditureLabel.Text = "RMB 0";
            this.totalExpenditureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.AutoSize = true;
            this.totalIncomeLabel.Location = new System.Drawing.Point(51, 55);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(59, 19);
            this.totalIncomeLabel.TabIndex = 0;
            this.totalIncomeLabel.Text = "RMB 0";
            this.totalIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.label2);
            this.summaryGroupBox.Controls.Add(this.totalRevenueLabel);
            this.summaryGroupBox.Controls.Add(this.label1);
            this.summaryGroupBox.Controls.Add(this.totalIncomeLabel);
            this.summaryGroupBox.Controls.Add(this.label3);
            this.summaryGroupBox.Controls.Add(this.totalExpenditureLabel);
            this.summaryGroupBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryGroupBox.Location = new System.Drawing.Point(769, 68);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(191, 214);
            this.summaryGroupBox.TabIndex = 2;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total revenue:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Income:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Expenditure:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(35, 85);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(117, 38);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(ClassLibrary.Accounts);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 499);
            this.Controls.Add(this.MonthPicker);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.accountItemListGroupBox);
            this.Controls.Add(this.MonthLabel);
            this.Name = "MainForm";
            this.Text = "Accounts";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.accountItemListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountItemsGridView)).EndInit();
            this.actionsGroupBox.ResumeLayout(false);
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.GroupBox accountItemListGroupBox;
        private System.Windows.Forms.DataGridView AccountItemsGridView;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.DateTimePicker MonthPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountItemOccuredTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountItemContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountItemNote;
        private System.Windows.Forms.Label totalRevenueLabel;
        private System.Windows.Forms.Label totalExpenditureLabel;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditButton;
    }
}

